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
        private int idVenta;
        public FormDetalleVenta(int idVenta)
        {
            InitializeComponent();
            this.idVenta = idVenta;
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            CN_Venta cnVenta = new CN_Venta(); 
            CN_DetalleVenta cnDetalleVenta = new CN_DetalleVenta(); 

            Venta cabeceraVenta = cnVenta.buscarVenta(idVenta);
            List<DetalleVenta> detalle = cnDetalleVenta.buscarDetalle(idVenta);


            // Limpia el DataGridView antes de agregar nuevos detalles
            DGDetalle.Rows.Clear();

            // Relleno cabecera de venta
            TIdVenta.Text = cabeceraVenta.NumeroDocumento.ToString();
            TVendedor.Text = cabeceraVenta.oUsuario.Nombre + " " + cabeceraVenta.oUsuario.Apellido;
            TFormaPago.Text = cabeceraVenta.oFormaPago.Descripcion;
            TFecha.Text = Convert.ToDateTime(cabeceraVenta.FechaRegistro).ToString("dd-MM-yyyy");
            TNombre.Text = cabeceraVenta.NombreCliente;
            TApellido.Text = cabeceraVenta.ApellidoCliente;
            TDocumento.Text = Convert.ToInt32(cabeceraVenta.DniCliente).ToString();
            TTotal.Text = cabeceraVenta.MontoTotal.ToString();
            TCambio.Text = cabeceraVenta.MontoCambio.ToString();
            TPago.Text = cabeceraVenta.MontoPago.ToString();

            // Relleno detalle de venta
            foreach (DetalleVenta item in detalle)
            {

                DGDetalle.Rows.Add(new object[] { item.oProducto.Nombre, item.oProducto.Descripcion, item.Cantidad, item.PrecioVenta, item.SubTotal,
                });
            }
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
