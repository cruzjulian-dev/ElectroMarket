using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Venta
    {
        public int ObtenerSiguienteId()
        {
            int siguienteId = 0;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT count(*) + 1 from VENTAS");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    siguienteId = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception)
                {
                    siguienteId = 0;
                }

            }

            return siguienteId;
        }

        public bool RegistrarVenta(Venta objVenta, DataTable detalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;


            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarVenta", oConexion);
                    cmd.Parameters.AddWithValue("IdUsuario", objVenta.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("DniCliente", objVenta.DniCliente);
                    cmd.Parameters.AddWithValue("IdFormaPago", objVenta.oFormaPago.IdFormaPago);
                    cmd.Parameters.AddWithValue("NombreCliente", objVenta.NombreCliente);
                    cmd.Parameters.AddWithValue("ApellidoCliente", objVenta.ApellidoCliente);
                    cmd.Parameters.AddWithValue("TipoDocumento", objVenta.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", objVenta.NumeroDocumento);
                    cmd.Parameters.AddWithValue("MontoPago", objVenta.MontoPago);
                    cmd.Parameters.AddWithValue("MontoCambio", objVenta.MontoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", objVenta.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleVenta", detalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output; // parametros de salida
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametros de salida

                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex) 
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }

                return Respuesta;
            }
        }

        public Venta buscarVenta(int idVenta)
        {
            Venta venta = new Venta();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT v.IdVenta, v.FechaRegistro, u.Nombre, u.Apellido, fp.Descripcion, v.NombreCliente, v.ApellidoCliente, v.DniCliente, v.MontoTotal, v.MontoPago, v.MontoCambio");
                    query.AppendLine("FROM VENTAS v");
                    query.AppendLine("INNER JOIN USUARIOS u ON u.IdUsuario = v.IdUsuario");
                    query.AppendLine("INNER JOIN FORMA_PAGO fp ON fp.IdFormaPago = v.IdFormaPago");
                    query.AppendLine("WHERE v.IdVenta = @IdVenta;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) // VER SI ES NECESARIO EL WHILE
                        {
                            venta.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                            venta.oUsuario = new Usuario() { Nombre = dr["Nombre"].ToString(), Apellido = dr["Apellido"].ToString() };
                            venta.NombreCliente = dr["NombreCliente"].ToString();
                            venta.ApellidoCliente = dr["ApellidoCliente"].ToString();
                            venta.DniCliente = Convert.ToInt32(dr["DniCliente"]);
                            venta.MontoTotal = Convert.ToDecimal(dr["MontoTotal"]);
                            venta.MontoPago = Convert.ToInt32(dr["MontoPago"]);
                            venta.MontoCambio = Convert.ToDecimal(dr["MontoCambio"]);
                            venta.oFormaPago = new FormaPago() { Descripcion = dr["Descripcion"].ToString() };
                            venta.FechaRegistro = dr["FechaRegistro"].ToString();
                        }
                    }

                }
                catch (Exception)
                {
                    venta = new Venta();
                }

            }

            return venta;
        }

    }
}
