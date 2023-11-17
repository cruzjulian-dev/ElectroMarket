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
                    cmd.Parameters.AddWithValue("MontoTotal", objVenta.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleVenta", detalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output; // parámetros de salida
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parámetros de salida

                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                    if (Respuesta)
                    {
                        // Actualiza el stock de los productos vendidos
                        foreach (DataRow row in detalleVenta.Rows)
                        {
                            int idProducto = Convert.ToInt32(row["IdProducto"]);
                            int cantidad = Convert.ToInt32(row["Cantidad"]);
                            // Llama a la función para restar el stock
                            bool stockActualizado = RestarStock(idProducto, cantidad);
                            if (!stockActualizado)
                            {
                                // Si la actualización del stock falla, muestra un mensaje de error
                                Mensaje = "Error al restar el stock de los productos.";
                                Respuesta = false; // Establece la respuesta en false
                                break; // Sale del bucle
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }

                return Respuesta;
            }
        }

        public List<Venta> traerVentas()
        {
            List<Venta> listaVentas = new List<Venta>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT V.IdVenta,");
                    query.AppendLine("V.NumeroDocumento,");
                    query.AppendLine("U.Nombre,");
                    query.AppendLine("U.Apellido,");
                    query.AppendLine("U.UsuarioLogin,");
                    query.AppendLine("V.DniCliente,");
                    query.AppendLine("V.NombreCliente,");
                    query.AppendLine("V.ApellidoCliente,");
                    query.AppendLine("V.MontoTotal,");
                    query.AppendLine("FP.Descripcion,");
                    query.AppendLine("V.FechaRegistro");
                    query.AppendLine("FROM VENTAS V");
                    query.AppendLine("INNER JOIN USUARIOS U ON V.IdUsuario = U.IdUsuario");
                    query.AppendLine("INNER JOIN FORMA_PAGO FP ON V.IdFormaPago = FP.IdFormaPago");
                    query.AppendLine("ORDER BY FechaRegistro DESC");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Venta venta = new Venta
                            {
                                IdVenta = Convert.ToInt32(dr["IdVenta"]),
                                oUsuario = new Usuario { Nombre = dr["Nombre"].ToString(), Apellido = dr["Apellido"].ToString(), UsuarioLogin = dr["UsuarioLogin"].ToString() },
                                NombreCliente = dr["NombreCliente"].ToString(),
                                ApellidoCliente = dr["ApellidoCliente"].ToString(),
                                DniCliente = Convert.ToInt32(dr["DniCliente"]),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                                oFormaPago = new FormaPago { Descripcion = dr["Descripcion"].ToString() },
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                            listaVentas.Add(venta);
                        }
                    }

                }
                catch (Exception)
                {
                    listaVentas = null;
                }

            }

            return listaVentas;
        }

        public List<Venta> traerVentasFechas(string fechaDesde, string fechaHasta)
        {
            List<Venta> listaVentas = new List<Venta>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT V.IdVenta,");
                    query.AppendLine("V.NumeroDocumento,");
                    query.AppendLine("U.Nombre,");
                    query.AppendLine("U.Apellido,");
                    query.AppendLine("U.UsuarioLogin,");
                    query.AppendLine("V.DniCliente,");
                    query.AppendLine("V.NombreCliente,");
                    query.AppendLine("V.ApellidoCliente,");
                    query.AppendLine("V.MontoTotal,");
                    query.AppendLine("FP.Descripcion,");
                    query.AppendLine("V.FechaRegistro");
                    query.AppendLine("FROM VENTAS V");
                    query.AppendLine("INNER JOIN USUARIOS U ON V.IdUsuario = U.IdUsuario");
                    query.AppendLine("INNER JOIN FORMA_PAGO FP ON V.IdFormaPago = FP.IdFormaPago");
                    query.AppendLine("WHERE CONVERT(DATE, V.FechaRegistro,105) >= CONVERT(DATE, @FechaDesde,105) AND CONVERT(DATE, V.FechaRegistro,105) <= CONVERT(DATE, @FechaHasta,105)");
                    query.AppendLine("ORDER BY FechaRegistro DESC");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Venta venta = new Venta
                            {
                                IdVenta = Convert.ToInt32(dr["IdVenta"]),
                                oUsuario = new Usuario { Nombre = dr["Nombre"].ToString(), Apellido = dr["Apellido"].ToString(), UsuarioLogin = dr["UsuarioLogin"].ToString() },
                                NombreCliente = dr["NombreCliente"].ToString(),
                                ApellidoCliente = dr["ApellidoCliente"].ToString(),
                                DniCliente = Convert.ToInt32(dr["DniCliente"]),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                                oFormaPago = new FormaPago { Descripcion = dr["Descripcion"].ToString() },
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                            listaVentas.Add(venta);
                        }
                    }

                }
                catch (Exception)
                {
                    listaVentas = null;
                }

            }

            return listaVentas;
        }

        public Venta buscarVenta(int idVenta)
        {
            Venta venta = null;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT v.IdVenta, v.FechaRegistro, u.Nombre, u.Apellido, fp.Descripcion, v.NombreCliente, v.ApellidoCliente, v.DniCliente, v.MontoTotal, v.NumeroDocumento, v.TipoDocumento");
                    query.AppendLine("FROM VENTAS v");
                    query.AppendLine("INNER JOIN USUARIOS u ON u.IdUsuario = v.IdUsuario");
                    query.AppendLine("INNER JOIN FORMA_PAGO fp ON fp.IdFormaPago = v.IdFormaPago");
                    query.AppendLine("WHERE v.IdVenta = @IdVenta;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta); 


                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            venta = new Venta
                            {
                                IdVenta = Convert.ToInt32(dr["IdVenta"]),
                                oUsuario = new Usuario { Nombre = dr["Nombre"].ToString(), Apellido = dr["Apellido"].ToString() },
                                NombreCliente = dr["NombreCliente"].ToString(),
                                ApellidoCliente = dr["ApellidoCliente"].ToString(),
                                DniCliente = Convert.ToInt32(dr["DniCliente"]),
                                Detalle_Venta = null,
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                                oFormaPago = new FormaPago { Descripcion = dr["Descripcion"].ToString() },
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }
                    }

                }
                catch (Exception)
                {
                    venta = null;
                }

            }

            return venta;
        }


        public bool RestarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update productos set Stock = Stock - @cantidad where idproducto = @idproducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception)
                {
                    respuesta=false;
                }
            }
            return respuesta;
        }
    }
}
