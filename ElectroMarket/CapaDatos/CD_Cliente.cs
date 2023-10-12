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
    public class CD_Cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCliente, Nombre, Apellido, Dni, FechaNacimiento, Telefono, Domicilio, Estado FROM CLIENTES");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Dni = Convert.ToInt32(dr["Dni"]),
                                FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                                Telefono = dr["Telefono"].ToString(),
                                Domicilio = dr["Domicilio"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Cliente>();
                }

            }

            return lista;
        }

        public int RegistrarCliente(Cliente obj, out string Mensaje)
        {
            int idClienteGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCLIENTE".ToString(), oConexion);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("Dni", obj.Dni);
                    cmd.Parameters.AddWithValue("FechaNacimiento", obj.FechaNacimiento);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Domicilio", obj.Domicilio);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("IdClienteResultado", SqlDbType.Int).Direction = ParameterDirection.Output; // parametros de salida
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametros de salida

                    cmd.CommandType = CommandType.StoredProcedure; // comando de tipo procedimiento almacenado

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    idClienteGenerado = Convert.ToInt32(cmd.Parameters["IdClienteResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                Mensaje = ex.Message;
            }


            return idClienteGenerado;
        }


        public bool EditarCliente(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARCLIENTE".ToString(), oConexion);
                    cmd.Parameters.AddWithValue("IdCliente", obj.IdCliente);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("Dni", obj.Dni);
                    cmd.Parameters.AddWithValue("FechaNacimiento", obj.FechaNacimiento);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Domicilio", obj.Domicilio);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output; // parametros de salida
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametros de salida

                    cmd.CommandType = CommandType.StoredProcedure; // comando de tipo procedimiento almacenado

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }


            return respuesta;
        }

    }
}
