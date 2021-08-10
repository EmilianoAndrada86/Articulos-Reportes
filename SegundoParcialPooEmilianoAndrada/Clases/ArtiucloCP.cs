using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPooEmilianoAndrada.Clases
{
    class ArtiucloCP : Articulos
    {
        public ArtiucloCP(string cod, string descrip, int stock, double cu)
        {
            this.codigo = cod;
            this.descripcion = descrip;
            this.costo = cu;
            this.StockArticulo = stock;
            this.FechaAlta = DateTime.Now;
        }
        public override void CalcularCosto(double precioUnitario, int stockingreso) 
        {
            costo = (((costo + precioUnitario) / 2)*1.1);
            StockArticulo = StockArticulo + stockingreso;
        }
    }

    
}
