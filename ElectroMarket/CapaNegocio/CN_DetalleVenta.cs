using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_DetalleVenta
    {
        private CD_DetalleVenta objCd_DetalleVenta = new CD_DetalleVenta();
        public List<DetalleVenta> buscarDetalle(int idVenta)
        {
            return objCd_DetalleVenta.buscarDetalle(idVenta);
        }
    }
}
