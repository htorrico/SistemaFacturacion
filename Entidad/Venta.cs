using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class Venta
    {
        public int IdVenta { get; set; }       
        public string NumeroFactura { get; set; }

        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal IGV { get; set; }
        public decimal Total { get; set; }

        //public int IdCliente { get; set; }
        //public string Cliente { get; set; }

        public Cliente Cliente { get; set; }
    

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
