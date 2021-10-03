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
    public class DVenta
    {

        public List<Venta> GetVentas(Venta venta)
        {
            List<Venta> Ventas = new List<Venta>();
            string commandText = "USP_ListarVentas";
            SqlParameter[] parameters = null;
            parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@IdCliente", SqlDbType.Int);
            parameters[0].Value = venta.Cliente.IdCliente;
            parameters[1] = new SqlParameter("@NumeroFactura", SqlDbType.VarChar);
            parameters[1].Value = venta.NumeroFactura;
            parameters[2] = new SqlParameter("@FechaInicio", SqlDbType.DateTime);
            parameters[2].Value = venta.FechaInicio;
            parameters[3] = new SqlParameter("@FechaFin", SqlDbType.Date);
            parameters[3].Value = venta.FechaFin;


            using (SqlDataReader reader =
                                    SqlHelper.ExecuteReader(SqlHelper.Connection, commandText,
                                                             System.Data.CommandType.StoredProcedure,
                                                             parameters
                                                             ))
            {
                while (reader.Read())
                {
                    Ventas.Add(new Venta
                    {
                        IdVenta = reader["IdVenta"] != null ? Convert.ToInt32(reader["IdVenta"]) : 0,
                        NumeroFactura = reader["NumeroFactura"] != null ? Convert.ToString(reader["NumeroFactura"]) : "",
                        Fecha = reader["Fecha"] != null ? Convert.ToDateTime(reader["Fecha"]) : DateTime.Now,
                        SubTotal = reader["SubTotal"] != null ? Convert.ToDecimal(reader["SubTotal"]) : 0,
                        IGV = reader["IGV"] != null ? Convert.ToDecimal(reader["IGV"]) :0,
                        Total = reader["Total"] != null ? Convert.ToDecimal(reader["Total"]) : 0,
                        Cliente= new Cliente
                        {
                            IdCliente = reader["IdCliente"] != null ? Convert.ToInt32(reader["IdCliente"]) : 0,
                            NombresCompletos= reader["Cliente"] != null ? Convert.ToString(reader["Cliente"]) : ""                            
                        }

                        //IdCliente = reader["IdCliente"] != null ? Convert.ToInt32(reader["IdCliente"]) : 0,
                        //Cliente = reader["Cliente"] != null ? Convert.ToString(reader["Cliente"]) : "",

                    });
                }

            }
            return Ventas;
        }



    }
}
