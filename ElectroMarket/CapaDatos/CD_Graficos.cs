using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaDatos
{
    public class CD_Graficos
    {
        SqlConnection oConexion = new SqlConnection(Conexion.cadena);
        public ArrayList VendedorConMasVentas(string fechaDesde, string fechaHasta)
        {
            ArrayList VendedoresVentas = new ArrayList();
            using (oConexion)
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT");
                    query.AppendLine("U.Nombre + ' ' + U.Apellido AS Vendedor,");
                    query.AppendLine("COUNT(V.IdVenta) AS CantidadVentas");
                    query.AppendLine("FROM");
                    query.AppendLine("USUARIOS AS U");
                    query.AppendLine("INNER JOIN VENTAS AS V ON U.IdUsuario = V.IdUsuario");
                    query.AppendLine("WHERE");
                    query.AppendLine("CONVERT(DATE, V.FechaRegistro, 105) >= CONVERT(DATE, @FechaDesde, 105) AND");
                    query.AppendLine("CONVERT(DATE, V.FechaRegistro, 105) <= CONVERT(DATE, @FechaHasta, 105)");
                    query.AppendLine("GROUP BY");
                    query.AppendLine("U.Nombre, U.Apellido");
                    query.AppendLine("ORDER BY");
                    query.AppendLine("CantidadVentas DESC;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string vendedorActual = dr.GetString(0);
                            int cantidadActual = dr.GetInt32(1);

                            // Agregar datos al gráfico
                            VendedoresVentas.Add(new object[] { vendedorActual, cantidadActual });
                        }
                        dr.Close();
                    }
                } catch (Exception)
                {
                    VendedoresVentas = null;
                }
            }
            return VendedoresVentas;
        }

        public ArrayList Top5Clientes(string fechaDesde, string fechaHasta)
        {
            ArrayList ClienteCantidad = new ArrayList();
            using (oConexion)
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT TOP 5");
                    query.AppendLine("C.Nombre + ' ' + C.Apellido AS Cliente,");
                    query.AppendLine("COUNT(V.IdVenta) AS CantidadCompras");
                    query.AppendLine("FROM CLIENTES AS C");
                    query.AppendLine("INNER JOIN VENTAS AS V ON C.Dni = V.DniCliente");
                    query.AppendLine("WHERE");
                    query.AppendLine("CONVERT(DATE, V.FechaRegistro, 105) >= CONVERT(DATE, @FechaDesde, 105) AND");
                    query.AppendLine("CONVERT(DATE, V.FechaRegistro, 105) <= CONVERT(DATE, @FechaHasta, 105)");
                    query.AppendLine("GROUP BY");
                    query.AppendLine("C.Nombre, C.Apellido");
                    query.AppendLine("ORDER BY");
                    query.AppendLine("CantidadCompras DESC;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string clienteActual = dr.GetString(0);
                            int cantidadActual = dr.GetInt32(1);

                            // Agregar datos al gráfico
                            ClienteCantidad.Add(new object[] { clienteActual, cantidadActual });
                        }
                        dr.Close();
                    }
                }
                catch (Exception)
                {
                    ClienteCantidad = null;
                }
            }
            return ClienteCantidad;
        }

        public ArrayList Top5Productos(string fechaDesde, string fechaHasta)
        {
            ArrayList ProductoCantidad = new ArrayList();
            using (oConexion)
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT TOP 5 P.Nombre + ' || ' + P.Descripcion,");
                    query.AppendLine("SUM(DV.Cantidad) as Cantidad");
                    query.AppendLine("FROM DETALLE_VENTA AS DV");
                    query.AppendLine("INNER JOIN PRODUCTOS AS P ON P.IdProducto = DV.IdProducto");
                    query.AppendLine("INNER JOIN CATEGORIAS AS C ON C.IdCategoria = P.IdCategoria");
                    query.AppendLine("INNER JOIN VENTAS AS V ON V.IdVenta = DV.IdVenta");
                    query.AppendLine("WHERE");
                    query.AppendLine("CONVERT(DATE, V.FechaRegistro, 105) >= CONVERT(DATE, @FechaDesde, 105) AND");
                    query.AppendLine("CONVERT(DATE, V.FechaRegistro, 105) <= CONVERT(DATE, @FechaHasta, 105)");
                    query.AppendLine("GROUP BY");
                    query.AppendLine("DV.IdProducto, C.Descripcion, P.Nombre, P.Descripcion");
                    query.AppendLine("ORDER BY");
                    query.AppendLine("Cantidad DESC;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string productoActual = dr.GetString(0);
                            int cantidadActual = dr.GetInt32(1);

                            // Agregar datos al gráfico
                            ProductoCantidad.Add(new object[] { productoActual, cantidadActual });
                        }
                        dr.Close();
                    }
                }
                catch (Exception)
                {
                    ProductoCantidad = null;
                }
            }
            return ProductoCantidad;
        }


        public ArrayList FormasPagoMasUtilizadas(string fechaDesde, string fechaHasta)
        {
            ArrayList FormaCantidad = new ArrayList();
            using (oConexion)
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT");
                    query.AppendLine("    FP.Descripcion AS FormaDePago,");
                    query.AppendLine("    COUNT(V.IdFormaPago) AS CantidadUtilizada");
                    query.AppendLine("FROM FORMA_PAGO AS FP");
                    query.AppendLine("LEFT JOIN VENTAS AS V ON FP.IdFormaPago = V.IdFormaPago");
                    query.AppendLine("WHERE");
                    query.AppendLine("CONVERT(DATE, V.FechaRegistro, 105) >= CONVERT(DATE, @FechaDesde, 105) AND");
                    query.AppendLine("CONVERT(DATE, V.FechaRegistro, 105) <= CONVERT(DATE, @FechaHasta, 105)");
                    query.AppendLine("GROUP BY FP.Descripcion");
                    query.AppendLine("ORDER BY CantidadUtilizada DESC;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string formaActual = dr.GetString(0);
                            int cantidadActual = dr.GetInt32(1);

                            // Agregar datos al gráfico
                            FormaCantidad.Add(new object[] { formaActual, cantidadActual });
                        }
                        dr.Close();
                    }
                }
                catch (Exception)
                {
                    FormaCantidad = null;
                }
            }
            return FormaCantidad;
        }


        public ArrayList CategoriasMasVendidas(string fechaDesde, string fechaHasta)
        {
            ArrayList CategoriaCantidad = new ArrayList();
            using (oConexion)
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT");
                    query.AppendLine("    C.Descripcion AS Categoria,");
                    query.AppendLine("    SUM(DV.Cantidad) AS CantidadVentas");
                    query.AppendLine("FROM CATEGORIAS AS C");
                    query.AppendLine("LEFT JOIN PRODUCTOS AS P ON C.IdCategoria = P.IdCategoria");
                    query.AppendLine("LEFT JOIN DETALLE_VENTA AS DV ON P.IdProducto = DV.IdProducto");
                    query.AppendLine("LEFT JOIN VENTAS AS V ON DV.IdVenta = V.IdVenta");
                    query.AppendLine("WHERE");
                    query.AppendLine("CONVERT(DATE, V.FechaRegistro, 105) >= CONVERT(DATE, @FechaDesde, 105) AND");
                    query.AppendLine("CONVERT(DATE, V.FechaRegistro, 105) <= CONVERT(DATE, @FechaHasta, 105)");
                    query.AppendLine("GROUP BY C.Descripcion");
                    query.AppendLine("ORDER BY CantidadVentas DESC;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string categoriaActual = dr.GetString(0);
                            int cantidadActual = dr.GetInt32(1);

                            // Agregar datos al gráfico
                            CategoriaCantidad.Add(new object[] { categoriaActual, cantidadActual });
                        }
                        dr.Close();
                    }
                }
                catch (Exception)
                {
                    CategoriaCantidad = null;
                }
            }
            return CategoriaCantidad;

        }
    }
}
