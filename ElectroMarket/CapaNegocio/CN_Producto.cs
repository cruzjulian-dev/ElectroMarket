using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {

        private CD_Producto objCd_Producto = new CD_Producto();

        public List<Producto> Listar()
        {
            return objCd_Producto.Listar();
        }


        public int RegistrarProducto(Producto obj, out string Mensaje) // MOSTRAR MENSAJE DE ERROR SI EL Producto ESTA DADO DE BAJA
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion del Producto\n";
            }


            if (Mensaje == string.Empty)
            {
                return objCd_Producto.RegistrarProducto(obj, out Mensaje);
            }
            else
            {
                return 0;
            }

        }

        public bool EditarProducto(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion del Producto\n";
            }

            if (Mensaje == string.Empty)
            {
                return objCd_Producto.EditarProducto(obj, out Mensaje);
            }
            else
            {
                return false;
            }

        }
    }
}
  
