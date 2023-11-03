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
    public partial class FormDetalleVenta : Form
    {
        public FormDetalleVenta(int idVenta)
        {
            InitializeComponent();
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            Venta cabeceraVenta = new Venta();
            DetalleVenta detalleVenta = new DetalleVenta();

            //cabeceraVenta = CN_Venta.buscarVenta(idVenta); no funciona

            // Limpia el DataGridView antes de agregar nuevos detalles
            DGDetalle.Rows.Clear();

            TIdVenta.Text = cabeceraVenta.NumeroDocumento.ToString();
            TVendedor.Text = cabeceraVenta.oUsuario.Nombre + " " + venta.oUsuario.Apellido;
            TFormaPago.Text = cabeceraVenta.oFormaPago.Descripcion;
            TFecha.Text = cabeceraVenta.FechaRegistro.ToString();
            TNombre.Text = cabeceraVenta.NombreCliente;
            TApellido.Text = cabeceraVenta.ApellidoCliente;
            TDocumento.Text = Convert.ToInt32(cabeceraVenta.DniCliente).ToString();
            TTotal.Text = cabeceraVenta.MontoTotal.ToString();
            TCambio.Text = cabeceraVenta.MontoCambio.ToString();
            TPago.Text = cabeceraVenta.MontoPago.ToString();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
