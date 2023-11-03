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
    public class CD_DetalleVenta
    {
        public List<DetalleVenta> buscarDetalle(int idVenta)
        {
            List<DetalleVenta> listaDetalle = new List<DetalleVenta>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.Nombre, p.Descripcion, c.IdCategoria, c.Descripcion , p.Stock, p.PrecioVenta, p.Estado");
                    query.AppendLine("FROM PRODUCTOS p");
                    query.AppendLine("INNER JOIN CATEGORIAS c ON c.IdCategoria = p.IdCategoria");
                    query.AppendLine("INNER JOIN DETALLE_VENTA dv ON dv.IdProducto = p.IdProducto");
                    query.AppendLine("WHERE dv.IdVenta = @IdVenta");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaDetalle.Add(new DetalleVenta()
                            {
                                IdDetalleVenta = Convert.ToInt32(dr["IdDetalleVenta"]),
                                IdVenta = Convert.ToInt32(dr["IdVenta"]),
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString(), Descripcion = dr["DescripcionCategoria"].ToString(), Precio = Convert.ToDecimal(dr["PrecioVenta"])},
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"])
                            });
                        }
                    }

                }
                catch (Exception)
                {
                    listaDetalle = new List<DetalleVenta>();
                }

            }

            return listaDetalle;
        }
    }
}
