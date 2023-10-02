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

        private void txtnombrecliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNombreCliente_Click(object sender, EventArgs e)
        {

        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            TIdVenta.Text = venta.IdVenta.ToString();
            TVendedor.Text = venta.oUsuario.Nombre + " " + venta.oUsuario.Apellido;
            TFecha.Text = venta.FechaRegistro.ToString();


        }
    }
}
