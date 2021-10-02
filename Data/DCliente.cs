using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DCliente
    {

        public List<Cliente> GetClientes(Cliente Cliente)
        {
            List<Cliente> Clientes = new List<Cliente>();
            string commandText = "USP_ListarClientes";
            SqlParameter[] parameters = null;

            using (SqlDataReader reader =
                                    SqlHelper.ExecuteReader(SqlHelper.Connection, commandText,
                                                             System.Data.CommandType.StoredProcedure,
                                                             parameters
                                                             ))
            {
                while (reader.Read())
                {
                    Clientes.Add(new Cliente
                    {
                        IdCliente = reader["IdCliente"] != null ? Convert.ToInt32(reader["IdCliente"]) : 0,
                        DNI = reader["DNI"] != null ? Convert.ToString(reader["DNI"]) : "",
                        Nombres = reader["Nombres"] != null ? Convert.ToString(reader["Nombres"]) : "",
                        Apellidos = reader["Apellidos"] != null ? Convert.ToString(reader["Apellidos"]) : "",                        
                    });
                }

            }
            return Clientes;
        }

    

    }
}
