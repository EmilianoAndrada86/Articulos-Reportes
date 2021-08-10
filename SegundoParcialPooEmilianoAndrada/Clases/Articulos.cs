using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialPooEmilianoAndrada.Clases
{
    public class Articulos 
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public double costo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public int StockArticulo { get; set; }
        public bool estado = true;

        

        public virtual void CalcularCosto(double precioUnitario, int stockingreso)
        {
            MessageBox.Show("Te esta tomando el de articulos");
        }
        public void DardeBaja()
        {
            estado = false;
            FechaBaja = DateTime.Now;
        }
        public void ReducirStock(int Ingreso)
        {
            if ((StockArticulo - Ingreso) < 0) { Interaction.MsgBox("Imposible El stock no pueden ser menor a 0"); }
            else StockArticulo = StockArticulo - Ingreso; 
            

        }
        
        

    }

    public class ArticulosxAlfabetoAsc : IComparer<VistaArticulos>
    {
        public int Compare(VistaArticulos x, VistaArticulos y)
        {
            int rdo = 0;
            if (string.Compare(x.descri, y.descri) > 0) rdo = 1;
            if (string.Compare(x.descri, y.descri) < 0) rdo = -1;

            return rdo;

        }
    }
    public class ArticulosxAlfabetoDesc : IComparer<VistaArticulos>
    {
        public int Compare(VistaArticulos x, VistaArticulos y)
        {
            int rdo = 0;
            if (string.Compare(x.descri, y.descri) > 0) rdo = -1;
            if (string.Compare(x.descri, y.descri) < 0) rdo = 1;

            return rdo;

        }
    }


    public class ArticulosxMes : IComparer<Articulos>
    {
        public int Compare(Articulos x, Articulos y)
        {
            
            var diferenciax = x.FechaBaja - x.FechaAlta;
            int mesesx = (int)(((diferenciax.TotalDays) / 365.25) * 12);
            var diferenciay = y.FechaBaja - y.FechaAlta;
            int mesesy = (int)(((diferenciax.TotalDays) / 365.25) * 12);

            if (mesesx > mesesy) return 1;
            if (mesesy > mesesx) return -1;
            else return 0;


        }
    }
    

  

}
