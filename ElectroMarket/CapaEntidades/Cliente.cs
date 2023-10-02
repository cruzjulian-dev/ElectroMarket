using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNacimiento  { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }

}
