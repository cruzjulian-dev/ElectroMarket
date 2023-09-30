using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string UsuarioLogin { get; set; }
        public string Clave { get; set; }
        public int IdRol { get; set; } //era Rol oRol
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
