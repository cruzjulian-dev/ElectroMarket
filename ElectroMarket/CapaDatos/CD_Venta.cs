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
        public int obtenerSiguienteId()
        {
            int siguienteId = 0;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT count(*) + 1 from COMPRA");

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
                    cmd.Parameters.AddWithValue("MontoPago", objVenta.MontoPago);
                    cmd.Parameters.AddWithValue("MontoCambio", objVenta.MontoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", objVenta.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleVenta", detalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output; // parametros de salida
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametros de salida

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    oConexion.Open();

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


    }
}
