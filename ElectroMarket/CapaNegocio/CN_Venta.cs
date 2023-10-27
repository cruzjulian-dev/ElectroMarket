using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objCd_Venta = new CD_Venta();

        public int ObtenerSiguienteId()
        {
            return objCd_Venta.ObtenerSiguienteId();
        }


        public bool RegistrarVenta(Venta obj, DataTable detalleVenta, out string Mensaje)
        {
            return objCd_Venta.RegistrarVenta(obj, detalleVenta, out Mensaje);

        }


    }
}
