using CapaPresentacion.Modales;
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
    public partial class RegistrarVenta : Form
    {
        public RegistrarVenta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {



            DTFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIDPROD.Text = "0";
            txtIDCLIE.Text = "0";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void icoBtnBuscar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdClientes())
            {
                var result = modal.ShowDialog();
            }
        }

        private void btnBuscarProduc_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos())
            {
                var result = modal.ShowDialog();
            }
        }
    }
}
