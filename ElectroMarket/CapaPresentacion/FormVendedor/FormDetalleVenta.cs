using CapaEntidades;
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
        private Venta venta;
        public FormDetalleVenta(Venta venta)
        {
            InitializeComponent();
            this.venta = venta; // Almacena la venta recibida en el campo privado
            //MostrarDatosVenta(); // Llama a un método para mostrar los datos en los controles
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            
            // Limpia el DataGridView antes de agregar nuevos detalles
            DGDetalle.Rows.Clear();

            TIdVenta.Text = venta.NumeroDocumento.ToString();
            TVendedor.Text = venta.oUsuario.Nombre + " " + venta.oUsuario.Apellido;
            TFormaPago.Text = venta.oFormaPago.Descripcion;
            TFecha.Text = venta.FechaRegistro.ToString();
            TNombre.Text = venta.NombreCliente;
            TApellido.Text = venta.ApellidoCliente;
            TDocumento.Text = Convert.ToInt32(venta.DniCliente).ToString();
            TTotal.Text = venta.MontoTotal.ToString();
            TCambio.Text = venta.MontoCambio.ToString();
            TPago.Text = venta.MontoPago.ToString();

            foreach (DetalleVenta detalle in venta.Detalle_Venta)
            {
                // Acceder al producto del detalle
                Producto producto = detalle.oProducto;

                // Agregar una fila al DataGridView con los detalles del producto
                DGDetalle.Rows.Add(
                    "",
                    producto.Nombre,
                    producto.Descripcion,
                   // producto.oCategoria.Descripcion,
                    detalle.PrecioVenta,
                    detalle.Cantidad,
                    detalle.SubTotal
                    //detalle.FechaRegistro
                ) ;
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
