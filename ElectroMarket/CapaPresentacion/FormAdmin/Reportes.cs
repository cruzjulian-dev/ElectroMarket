using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            CN_Venta cnVenta = new CN_Venta();

            List<Venta> listaVentas = cnVenta.traerVentas();

            // Pregunto si hay ventas
            if (listaVentas != null)
            {
                // Relleno el datagrid con las ventas
                foreach (Venta item in listaVentas)
                {
                        DGVentas.Rows.Add(new object[] { item.IdVenta, item.NumeroDocumento, item.oUsuario.Nombre + " " + item.oUsuario.Apellido, item.DniCliente, item.NombreCliente, item.ApellidoCliente,
                    item.MontoTotal, item.oFormaPago.Descripcion, Convert.ToDateTime(item.FechaRegistro).ToString("dd-MM-yyyy"), "Ver Detalle"
                    });

                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiarTabla();
            string fechaDesde = DTDesde.Value.ToString("dd-MM-yyyy");
            string fechaHasta = DTHasta.Value.ToString("dd-MM-yyyy");

            CN_Venta cnVenta = new CN_Venta();

            List<Venta> listaVentas = cnVenta.traerVentasFechas(fechaDesde, fechaHasta);

            // Pregunto si hay ventas
            if (listaVentas != null)
            {
                // Relleno el datagrid con las ventas
                foreach (Venta item in listaVentas)
                {
                    DGVentas.Rows.Add(new object[] { item.IdVenta, item.NumeroDocumento, item.oUsuario.Nombre + " " + item.oUsuario.Apellido, item.DniCliente, item.NombreCliente, item.ApellidoCliente,
                    item.MontoTotal, item.oFormaPago.Descripcion, Convert.ToDateTime(item.FechaRegistro).ToString("dd-MM-yyyy"), "Ver Detalle"
                    });

                }
            }
        }

        private void limpiarTabla()
        {
            DGVentas.Rows.Clear();
        }
    }
}
