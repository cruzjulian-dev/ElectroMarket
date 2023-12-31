﻿using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objCd_Venta = new CD_Venta();

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objCd_Venta.RestarStock(idproducto, cantidad);
        }

        public int ObtenerSiguienteId()
        {
            return objCd_Venta.ObtenerSiguienteId();
        }


        public bool RegistrarVenta(Venta obj, DataTable detalleVenta, out string Mensaje)
        {
            return objCd_Venta.RegistrarVenta(obj, detalleVenta, out Mensaje);

        }

        public List<Venta> traerVentas()
        {
            return objCd_Venta.traerVentas();
        }

        public List<Venta> traerVentasFechas(string fechaDesde, string fechaHasta)
        {
            return objCd_Venta.traerVentasFechas(fechaDesde, fechaHasta);
        }

        public Venta buscarVenta(int idVenta)
        {
            return objCd_Venta.buscarVenta(idVenta);
        }

    }
}
