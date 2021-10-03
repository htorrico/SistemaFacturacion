using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Data;


namespace Business
{
    public class BCliente
    {
        public List<Cliente> GetClientes()
        {
            DCliente dCliente = new DCliente();
            return dCliente.GetClientes();
        }

    


    }
}
