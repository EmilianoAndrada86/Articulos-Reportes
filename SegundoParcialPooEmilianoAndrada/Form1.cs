using Microsoft.VisualBasic;
using SegundoParcialPooEmilianoAndrada.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialPooEmilianoAndrada
{
    public partial class Form1 : Form
    {
        Listas lArticulos = new Listas(); //Instancia una clase lista que es donde van a estar las listas y los metodos relacionados con eso.

        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            lArticulos.StockCero += StockCero; //Suscripcion al evento stock cero.




        }
        private void button1_Click(object sender, EventArgs e) //Boton para ingresar los articulos.
        {
            IngresoArticulo Nuevo = new IngresoArticulo(); //Muestra el Formulario para ingresar los articulos
            Nuevo.ShowDialog();
             if (Nuevo.crear)
             {
                 lArticulos.AltaArticulo(Nuevo.rArticulos());
                 lArticulos.ActualizarListaVista();
                 dataGridView1.DataSource = null;
                 dataGridView1.DataSource = lArticulos;
                 textBox1.Text = lArticulos.valorTotalMercader();
             }

           
            

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lArticulos.ActualizarListaVista();
            textBox1.Text = lArticulos.valorTotalMercader();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Dar de Baja Arituclo
        {
            lArticulos.BajaArticulo((VistaArticulos)dataGridView1.SelectedRows[0].DataBoundItem);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lArticulos.ActualizarListaVista();
        }

        private void button3_Click(object sender, EventArgs e) //Boton para modificar Articulo
        {
            try //El try catch busca fundamentalmente Errores a la hora de cerrar el formulario
            {

                int filaseleecionada = dataGridView1.SelectedRows[0].Index;
                if (lArticulos.verEstadoArticulo(((VistaArticulos)dataGridView1.SelectedRows[0].DataBoundItem).codArt)) //Este if utiliza el metodo verEstadoArticulo para valir si esta dado de baja
                {
                    IngresoArticulo formulario = new IngresoArticulo();
                    formulario.anularTextbox();
                    formulario.ShowDialog();
                    dataGridView1.Rows[filaseleecionada].Selected = true;
                    lArticulos.ModificarArticulo((VistaArticulos)dataGridView1.SelectedRows[0].DataBoundItem, formulario.rArticulos());
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = lArticulos.ActualizarListaVista();
                }
                else Interaction.MsgBox("El Articulo no puede ser modificado, esta dado de baja");
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("No se Puede Modificar Persona"); }
        }

        private void button5_Click(object sender, EventArgs e) // Agrega una cantidad y precio para aumentar el stock y modifica el precio segun el tipo de articulo que es
        {
            int filaseleecionada = dataGridView1.SelectedRows[0].Index;
            if (lArticulos.verEstadoArticulo(((VistaArticulos)dataGridView1.SelectedRows[0].DataBoundItem).codArt)) //Validar si el articulo esta dado de baja
            {

                ModificacionStock aModificar = new ModificacionStock();
                aModificar.ShowDialog();
                dataGridView1.Rows[filaseleecionada].Selected = true;
                if (aModificar.rStock() != 0)
                {
                    lArticulos.AgregarStock(aModificar.rStock(), aModificar.rPrecio(), (VistaArticulos)dataGridView1.SelectedRows[0].DataBoundItem);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = lArticulos.ActualizarListaVista();
                    textBox1.Text = lArticulos.valorTotalMercader();
                }
                
            }

            else Interaction.MsgBox("El Articulo no puede ser modificado, esta dado de baja");


        }

        private void button4_Click(object sender, EventArgs e) //Este reduce el stock solamente utiliza el valor de stock y anula el precio.
        {
            int filaseleecionada = dataGridView1.SelectedRows[0].Index;
            if (lArticulos.verEstadoArticulo(((VistaArticulos)dataGridView1.SelectedRows[0].DataBoundItem).codArt))//Validar si el articulo esta dado de baja
            {
                ModificacionStock aModificar = new ModificacionStock();
                aModificar.AnularTextbox();
                aModificar.ShowDialog();
                dataGridView1.Rows[filaseleecionada].Selected = true;
                lArticulos.ReducirStock(aModificar.rStock(), (VistaArticulos)dataGridView1.SelectedRows[0].DataBoundItem);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lArticulos.ActualizarListaVista();
                textBox1.Text = lArticulos.valorTotalMercader();
            }

            else Interaction.MsgBox("El Articulo no puede ser modificado, esta dado de baja");
        }

        private void button6_Click(object sender, EventArgs e)//Este proyecta todos los articulos con stock actual mayor al numero ingresado.
        {
            try //aca el try busca cualquier valor que no sea numero
            {
                string valorConsumo = Interaction.InputBox("Stock", "Ingrese el Valor del consumo", "");
                int stock = Int32.Parse(valorConsumo);
                var aux = from art in lArticulos.ActualizarListaVista() where art.stock > stock select art;
                List<VistaArticulos> nueva = new List<VistaArticulos>();
                foreach (var p in aux)
                {
                    nueva.Add(p);
                }
                
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = nueva;
            }
            catch (System.FormatException) { Interaction.MsgBox("Ingrese un valor de stock"); }
        }



        private void button7_Click(object sender, EventArgs e)
        {

            var aux = from art in lArticulos.ListaArticulos where art.StockArticulo == 0 select art.descripcion;
            List<MostrarString> nueva = new List<MostrarString>();
            foreach (var p in aux)
            {
                MostrarString aux1 = new MostrarString(p);
                nueva.Add(aux1);
            }

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = nueva;


        }

        private void button8_Click(object sender, EventArgs e)
        {

            List<VistaArticulos> aux = new List<VistaArticulos>();
            foreach (var b in lArticulos.ActualizarListaVista())
            {
                aux.Add(b);
            }
            DialogResult dialogResult = MessageBox.Show("Si desea ordenar descendente ponga si, si desea que sea ascendente ponga no", "Ordenar segun Descripcion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                aux.Sort(new ArticulosxAlfabetoAsc());
            }
            else if (dialogResult == DialogResult.No)
            {
                aux.Sort(new ArticulosxAlfabetoDesc());
            }
            
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = aux;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var aux = from art in lArticulos.ListaArticulos where art.estado == false select art;
            List<Articulos> auxiliar = new List<Articulos>();
            foreach (var a in aux)
            {
                auxiliar.Add(a);
            }
            auxiliar.Sort(new ArticulosxMes());
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = auxiliar;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string n1 = Interaction.InputBox("N1", "Ingrese el Valor de N1", "");
            string n2 = Interaction.InputBox("N2", "Ingrese el Valor de N2", "");
            try
            {
                int aux1 = Int32.Parse(n1);
                int aux2 = Int32.Parse(n2);
                if (aux1 > aux2) { MessageBox.Show("Error n2 debe ser mayor que n1"); }
                else
                {
                    List<VistaArticulos> aux = new List<VistaArticulos>();
                    aux = lArticulos.ActualizarListaVista().FindAll(x => x.stock > aux1 && x.stock < aux2);
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = aux;
                }

            }
            catch (System.FormatException) { MessageBox.Show("Coloque un numero entero valido"); }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void StockCero(object sender, StockCeroEventArg e)
        {
            MessageBox.Show("El producto: " + e.Descripcion + " de codigo: " + e.codigo + " Tiene Stock Cero");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    public class MostrarString
    {
        public string Descripcion { set; get; }
        public MostrarString(string desc) { Descripcion = desc; }
    }
}
