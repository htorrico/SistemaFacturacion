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
    public class DProducto
    {

        public List<Producto> GetProductos(Producto Producto)
        {
            List<Producto> Productos = new List<Producto>();
            string commandText = "USP_ListarProductos";
            SqlParameter[] parameters = null;

            using (SqlDataReader reader =
                                    SqlHelper.ExecuteReader(SqlHelper.Connection, commandText,
                                                             System.Data.CommandType.StoredProcedure,
                                                             parameters
                                                             ))
            {
                while (reader.Read())
                {
                    Productos.Add(new Producto
                    {
                        IdProducto = reader["IdProducto"] != null ? Convert.ToInt32(reader["IdProducto"]) : 0,
                        Nombre = reader["Nombre"] != null ? Convert.ToString(reader["Nombre"]) : "",
                        Descripcion = reader["Descripcion"] != null ? Convert.ToString(reader["Descripcion"]) : "",
                        PrecioUnitario = reader["PrecioUnitario"] != null ? Convert.ToDecimal(reader["PrecioUnitario"]) : 0,
                    });
                }

            }
            return Productos;
        }



    }
}
