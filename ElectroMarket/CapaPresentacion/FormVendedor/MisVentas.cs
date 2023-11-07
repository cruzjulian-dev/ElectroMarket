using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CapaPresentacion
{
    public partial class MisVentas : Form
    {
        private List<Venta> ventasFicticias = new List<Venta>();
        public MisVentas()
        {
            InitializeComponent();
        }

        private void MisVentas_Load(object sender, EventArgs e)
        {
            CN_Venta cnVenta = new CN_Venta();

            List<Venta> listaVentas = cnVenta.traerVentas();

            // Pregunto si hay ventas
            if (listaVentas != null)
            {
                // Relleno el datagrid con las ventas
                foreach (Venta item in listaVentas)
                {
                    if (VistaVendedor.usuarioActual.UsuarioLogin == item.oUsuario.UsuarioLogin)
                    {
                        DGMisVentas.Rows.Add(new object[] { item.IdVenta, item.NumeroDocumento, item.oUsuario.Nombre + " " + item.oUsuario.Apellido, item.DniCliente, item.NombreCliente, item.ApellidoCliente,
                    item.MontoTotal, item.oFormaPago.Descripcion, Convert.ToDateTime(item.FechaRegistro).ToString("dd-MM-yyyy"), "Ver Detalle"
                    });
                    }

                }
            }
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGMisVentas.Columns[e.ColumnIndex].Name == "CDetalle")
            {
                FormDetalleVenta detalleForm = new FormDetalleVenta(Convert.ToInt32(DGMisVentas.Rows[e.RowIndex].Cells["CIdVenta"].Value.ToString()));
                detalleForm.ShowDialog();
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
                    DGMisVentas.Rows.Add(new object[] { item.IdVenta, item.NumeroDocumento, item.oUsuario.Nombre + " " + item.oUsuario.Apellido, item.DniCliente, item.NombreCliente, item.ApellidoCliente,
                    item.MontoTotal, item.oFormaPago.Descripcion, Convert.ToDateTime(item.FechaRegistro).ToString("dd-MM-yyyy"), "Ver Detalle"
                    });

                }
            }
        }

        private void limpiarTabla()
        {
            DGMisVentas.Rows.Clear();
        }
    }
}
