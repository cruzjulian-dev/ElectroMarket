using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using System.Net;
using System.Reflection;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario> ();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.IdUsuario, u.Dni, u.Nombre, u.Apellido, u.UsuarioLogin, u.Clave, r.IdRol, r.Descripcion, u.FechaNacimiento, u.Telefono, u.Domicilio, u.Estado FROM USUARIOS u");
                    query.AppendLine("inner join ROLES r on r.IdRol = u.IdRol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Dni = Convert.ToInt32(dr["Dni"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                UsuarioLogin = dr["UsuarioLogin"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), Descripcion = dr["Descripcion"].ToString() },
                                FechaNacimiento = dr["FechaNacimiento"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Domicilio = dr["Domicilio"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            }) ;
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }

            }

            return lista;
        }
    }
}
