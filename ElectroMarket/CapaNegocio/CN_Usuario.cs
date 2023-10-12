using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objCd_Usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return objCd_Usuario.Listar();
        }


        public int RegistrarUsuario(Usuario obj, out string Mensaje) // MOSTRAR MENSAJE DE ERROR SI EL USUARIO ESTA DADO DE BAJA
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario el apellido del usuario\n";
            }

            if (obj.Dni.ToString().Length != 8)
            {
                Mensaje += "El DNI debe tener exactamente 8 digitos\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario el usuario del usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesaria la clave del usuario\n";
            }

            if (Mensaje == string.Empty)
            {
                return objCd_Usuario.RegistrarUsuario(obj, out Mensaje);
            } else
            {
                return 0;
            }

        }

        public bool EditarUsuario(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Dni.ToString().Length != 8)
            {
                Mensaje += "El DNI debe tener exactamente 8 digitos\n";
            }

            if (Mensaje == string.Empty)
            {
                return objCd_Usuario.EditarUsuario(obj, out Mensaje);
            }
            else
            {
                return false;
            }
            
        }
    }
}
