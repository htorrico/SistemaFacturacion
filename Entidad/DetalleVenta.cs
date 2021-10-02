using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public decimal PrecioUnitario { get; set; }

        public decimal IGV { get; set; }

        public decimal Total { get; set; }
    }
}
