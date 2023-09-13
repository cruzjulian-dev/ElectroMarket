using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class VistaAdmin : Form
    {

        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public VistaAdmin()
        {
            InitializeComponent();
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {


        }

        private void VistaAdmin_Load(object sender, EventArgs e)
        {

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
            //formulario.BackColor = Color.White;
            PContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void MenuUser_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new ClientesAdmin());
        }

        private void SMCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuProd, new Categorias());
        }

        private void MenuCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new ClientesVendedor());
        }

        private void SMProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuProd, new ProductosAdmin());
        }

        private void PContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LTitulo_Click(object sender, EventArgs e)
        {

        }

        private void MenuProd_Click(object sender, EventArgs e)
        {

        }

        private void MenuVentas_Click(object sender, EventArgs e)
        {

        }

        private void MenuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuProd, new Reportes());
        }

        private void MenuAdmin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuLogo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
