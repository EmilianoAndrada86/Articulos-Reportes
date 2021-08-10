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
    public partial class IngresoArticulo : Form
    {
        private Articulos articulos = new Articulos();
        public bool crear = false;
      
        public IngresoArticulo()
        {
            
            InitializeComponent();
            

        }

        public Articulos rArticulos()
        {
            return articulos;
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (chequearID(textBox1.Text))
                {
                    if (radioButton1.Checked)
                    {
                        ArticuloCPP nuevo = new ArticuloCPP((string)textBox1.Text, (string)textBox2.Text, int.Parse((string)textBox3.Text), double.Parse((string)textBox4.Text));
                        articulos = nuevo;
                        crear = true;
                    }
                    if (radioButton2.Checked)
                    {
                        ArticuloCUE nuevo = new ArticuloCUE((string)textBox1.Text, (string)textBox2.Text, int.Parse((string)textBox3.Text), double.Parse((string)textBox4.Text));
                        articulos = nuevo;
                        crear = true;

                    }
                    if (radioButton3.Checked)
                    {
                        ArtiucloCP nuevo = new ArtiucloCP((string)textBox1.Text, (string)textBox2.Text, int.Parse((string)textBox3.Text), double.Parse((string)textBox4.Text));
                        articulos = nuevo;
                        crear = true;
                    }
                }
            }
            catch (System.FormatException) { Interaction.MsgBox("Ingrese un valor a stock y a precio"); }
            
            this.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IngresoArticulo_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            {

                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                  if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {

                    e.Handled = true;
                }
            }
        }

        private bool chequearID (string id)
        {
            if (id[0] < 65 || id[0] > 90) { Interaction.MsgBox( "El Primer del codigo debe ser una letra en mayuscula");return false; }
            else
            {
                for (int i = 1; i < id.Length; i++)
                {
                    if(id[i]<48 || id[i] > 57) { Interaction.MsgBox("Luego de la primer mayuscula solo puede ingresar numeros"); return false; }
                }
            }
            return true;
        }
        public void anularTextbox()
        {
            this.textBox3.Enabled = false;
            this.textBox4.Enabled = false;
        }
            
    }
}
