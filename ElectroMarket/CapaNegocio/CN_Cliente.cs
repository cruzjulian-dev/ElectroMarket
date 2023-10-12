using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objCd_Cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return objCd_Cliente.Listar();
        }


        public int RegistrarCliente(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del cliente\n";
            }

            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario el apellido del cliente\n";
            }

            if (obj.Dni.ToString().Length != 8)
            {
                Mensaje += "El DNI debe tener exactamente 8 digitos\n";
            }

            if (Mensaje == string.Empty)
            {
                return objCd_Cliente.RegistrarCliente(obj, out Mensaje);
            }
            else
            {
                return 0;
            }

        }

        public bool EditarCliente(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Dni.ToString().Length != 8)
            {
                Mensaje += "El DNI debe tener exactamente 8 digitos\n";
            }

            if (Mensaje == string.Empty)
            {
                return objCd_Cliente.EditarCliente(obj, out Mensaje);
            }
            else
            {
                return false;
            }

        }
    }
}
