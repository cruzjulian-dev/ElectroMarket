using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class VistaVendedor : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public static Usuario usuarioActual;
        public VistaVendedor(Usuario objUsuario)
        {
            usuarioActual = objUsuario;
            InitializeComponent();
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            PContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        private void MenuReportes_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MenuUser_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new ClientesVendedor());
        }

        private void MenuProd_Click(object sender, EventArgs e)
        {
            ListaProductos listaProd = new ListaProductos();
            listaProd.FuenteFormulario = "VistaVendedor";
            AbrirFormulario((IconMenuItem)sender, listaProd);
        }

        private void SMCategoria_Click_1(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void SMCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new RegistrarVenta());
        }

        private void SMdetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new MisVentas());
        }

        private void MenuVendedor_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void VistaVendedor_Load(object sender, EventArgs e)
        {
            LUsuario.Text = usuarioActual.Nombre + " " + usuarioActual.Apellido;
        }
    }
}
