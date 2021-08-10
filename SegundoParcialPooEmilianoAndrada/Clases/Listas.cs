using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPooEmilianoAndrada.Clases
{
    public class Listas
    {
       public List<Articulos> ListaArticulos = new List<Articulos>();
       public List<VistaArticulos> auxiliar = new List<VistaArticulos>();


        public void AltaArticulo(Articulos articulo) 
        {
            Articulos aux = ListaArticulos.Find(x => x.codigo == articulo.codigo);
            if (aux==null)ListaArticulos.Add(articulo);
            else { Interaction.MsgBox("Imposible Crear el articulo ya existe"); }// Comprueba que no exista un articulo con el codigo
        }
        public void BajaArticulo(VistaArticulos articulo) 
        {
            Articulos aux = ListaArticulos.Find(x => x.codigo == articulo.codArt);
            aux.DardeBaja();     
        
        }
        public void ModificarArticulo(VistaArticulos aModificar, Articulos modificado) 
        {
            
            Articulos aux = ListaArticulos.Find(x => x.codigo == aModificar.codArt);
            Articulos aux2 = ListaArticulos.Find(x => x.codigo == modificado.codigo);
            if (modificado.codigo != null && aux2 == null  ) 
            { 

                aux.codigo = modificado.codigo; 
            
            }
            if (modificado.descripcion != null) aux.descripcion = modificado.descripcion;
        }

        public void AgregarStock(int stock, double precio, VistaArticulos aModificar) 
        {
            Articulos aux = ListaArticulos.Find(x => x.codigo == aModificar.codArt);
            aux.CalcularCosto(precio, stock);
        }
        
        public void ReducirStock(int stock, VistaArticulos aModificar) 
        {
            Articulos aux = ListaArticulos.Find(x => x.codigo == aModificar.codArt);
            aux.ReducirStock(stock);
            if ((aux.StockArticulo == 0)) { StockCero?.Invoke(this, new StockCeroEventArg(aux.codigo, aux.descripcion)); }

        }
        
        public List<VistaArticulos> ActualizarListaVista()
        {
            auxiliar.Clear();
            foreach (Articulos c in ListaArticulos)
            {
                auxiliar.Add(new VistaArticulos(c));
            }
            return auxiliar;
        }
        public bool verEstadoArticulo(string codigo)
        {
            Articulos aux = ListaArticulos.Find(x => x.codigo == codigo);
            return aux.estado;
        }
        public string valorTotalMercader()
        {
            double ValorMercaderia = 0;
            foreach(Articulos a in ListaArticulos)
            {
                ValorMercaderia = ValorMercaderia + (a.costo * a.StockArticulo);
            }
           string ValorTotalMercaderia = ValorMercaderia.ToString();
            return ValorTotalMercaderia;
        }
        public EventHandler<StockCeroEventArg> StockCero;

    }
    public class StockCeroEventArg : EventArgs
    {
        public string codigo;
        public string Descripcion;
        public StockCeroEventArg(string cod, string desc) { codigo = cod; Descripcion = desc; }
    }
}
