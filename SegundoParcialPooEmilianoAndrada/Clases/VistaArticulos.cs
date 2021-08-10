using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPooEmilianoAndrada.Clases
{
    public class VistaArticulos { 
        public string codArt { get; set; }
        public string descri { get; set; }
        public string  FA { get; set; }
        public string  FB { get; set; }
        public string MesesVigente { get; set; }
        public double costo { get; set; }
        public string DMetodoCosto { get; set; }
        public int stock { get; set; }

        public VistaArticulos (Articulos articulo) 
        {
            codArt = articulo.codigo;
            descri = articulo.descripcion;
            FA = articulo.FechaAlta.ToString("dd/MM/yyyy");
            if(articulo.FechaBaja== new DateTime(0001, 1, 1, 00, 00, 00)) { FB = "--"; }
            else FB = articulo.FechaBaja.ToString("dd/MM/yyyy");
            costo = articulo.costo;
            stock = articulo.StockArticulo;
            if (articulo is ArticuloCUE) { DMetodoCosto = "CUE"; }
            if (articulo is ArticuloCPP) { DMetodoCosto = "CPP"; }
            if (articulo is ArtiucloCP) { DMetodoCosto = "CP"; }
            if (articulo.FechaBaja == new DateTime(0001, 1, 1, 00, 00, 00)) { MesesVigente = "--"; }
            else {

                var diferencia = articulo.FechaBaja - articulo.FechaAlta;
                int meses = (int)(((diferencia.TotalDays)/365.25)*12);
                MesesVigente = meses.ToString() + " Meses";
            }




        }

        
    }
}
