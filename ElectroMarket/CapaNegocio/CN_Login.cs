using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Login
    {
        private Conexion conexion = new Conexion(); 

        public bool Conectar()
        {
            return conexion.AbrirConexion(); 
        }
    }
}
