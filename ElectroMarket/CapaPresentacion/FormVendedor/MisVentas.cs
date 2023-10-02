using CapaEntidades;
using CapaPresentacion.Utilidades;
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
    public partial class MisVentas : Form
    {
        private List<Venta> ventasFicticias = new List<Venta>();
        public MisVentas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MisVentas_Load(object sender, EventArgs e)
        {
            decimal total = 0.0m;
            int totalVentas = 0;

            Venta venta1 = new Venta
            {
                IdVenta = 1,
                oUsuario = new Usuario { Nombre = "Yamila", Apellido = "Davalos" },
                DniCliente = 23765432,
                NombreCliente = "Juan",
                ApellidoCliente = "Perez",
                MontoPago = 2500,
                MontoCambio = 500,
                MontoTotal = 2000,
                FechaRegistro = DateTime.Now.ToShortDateString()
            };

            Venta venta2 = new Venta
            {
                IdVenta = 2,
                oUsuario = new Usuario { Nombre = "Yamila", Apellido = "Davalos" },
                DniCliente = 11765432,
                NombreCliente = "Roberto",
                ApellidoCliente = "Godoy",
                MontoPago = 4400,
                MontoCambio = 200,
                MontoTotal = 4200,
                FechaRegistro = DateTime.Now.ToShortDateString()
            };

            ventasFicticias.Add(venta1);
            ventasFicticias.Add(venta2);

            foreach (Venta venta in ventasFicticias)
            {
                DGMisVentas.Rows.Add(venta.IdVenta, venta.oUsuario.Nombre + " " + venta.oUsuario.Apellido, venta.DniCliente, venta.NombreCliente, venta.ApellidoCliente, venta.MontoTotal, venta.FechaRegistro, "Ver detalle");
                // Actualiza los valores de resumen
                total += venta.MontoTotal;
                totalVentas += 1;
            }

            // Actualiza los controles de resumen
            LTotal.Text = total.ToString();
            LVentas.Text = totalVentas.ToString();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGMisVentas.Columns[e.ColumnIndex].Name == "CDetalle")
            {
                FormDetalleVenta detalleForm = new FormDetalleVenta(ventasFicticias[0]);
                detalleForm.ShowDialog();
            }
        }
    }
}
