using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Data;


namespace Business
{
    public class BVenta
    {
        public List<Venta> GetVentas(Venta venta)
        {
            DVenta dVenta = new DVenta();
            return dVenta.GetVentas(venta);
        }

    }
}
