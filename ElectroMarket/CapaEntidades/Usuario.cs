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
        public Rol oRol { get; set; }
        public DateTime FechaNacimiento { get; set; }   
        //public string FechaNacimiento { get; set; }   formato string daba problemas con horas minutos y segundos
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
