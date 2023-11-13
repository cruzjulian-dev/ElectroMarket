using CapaDatos;
using CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Graficos
    {
        private CD_Graficos objCd_Graficos = new CD_Graficos();

        public ArrayList VendedorConMasVentas(string fechaDesde, string fechaHasta)
        {
            return objCd_Graficos.VendedorConMasVentas(fechaDesde, fechaHasta);
        }

        public ArrayList Top5Clientes(string fechaDesde, string fechaHasta)
        {
            return objCd_Graficos.Top5Clientes(fechaDesde, fechaHasta);
        }

        public ArrayList Top5Productos(string fechaDesde, string fechaHasta)
        {
            return objCd_Graficos.Top5Productos(fechaDesde, fechaHasta);
        }

        public ArrayList FormasPagoMasUtilizadas(string fechaDesde, string fechaHasta)
        {
            return objCd_Graficos.FormasPagoMasUtilizadas(fechaDesde, fechaHasta);
        }

        public ArrayList CategoriasMasVendidas(string fechaDesde, string fechaHasta)
        {
            return objCd_Graficos.CategoriasMasVendidas(fechaDesde, fechaHasta);
        }

    }
}
