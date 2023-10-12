using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objCd_Categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return objCd_Categoria.Listar();
        }


        public int RegistrarCategoria(Categoria obj, out string Mensaje) // MOSTRAR MENSAJE DE ERROR SI EL Categoria ESTA DADO DE BAJA
        {
            Mensaje = string.Empty;

           

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la Descripcion de la Categoria\n";
            }

            if (Mensaje == string.Empty)
            {
                return objCd_Categoria.RegistrarCategoria(obj, out Mensaje);
            }
            else
            {
                return 0;
            }

        }

        public bool EditarCategoria(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la Descripcion de la Categoria\n";
            }

            if (Mensaje == string.Empty)
            {
                return objCd_Categoria.EditarCategoria(obj, out Mensaje);
            }
            else
            {
                return false;
            }

        }
    }
}
