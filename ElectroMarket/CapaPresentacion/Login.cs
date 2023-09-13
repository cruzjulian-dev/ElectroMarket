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

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseas cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            if (TUser.Text.Trim() == "" || TContra.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if ((TUser.Text.Trim() == "admin" && TContra.Text.Trim() == "123") || (TUser.Text.Trim() == "vendedor" && TContra.Text.Trim() == "123") || (TUser.Text.Trim() == "super" && TContra.Text.Trim() == "123"))
                {
                    if (TUser.Text.Trim() == "admin" && TContra.Text.Trim() == "123")
                    {
                        VistaAdmin vistaAdmin = new VistaAdmin();
                        vistaAdmin.Show();
                        this.Close();
                    }
                    if (TUser.Text.Trim() == "vendedor" && TContra.Text.Trim() == "123")
                    {
                        VistaVendedor vistaVendedor = new VistaVendedor();
                        vistaVendedor.Show();
                        this.Close();
                    }
                    if (TUser.Text.Trim() == "super" && TContra.Text.Trim() == "123")
                    {
                        VistaSuper vistaSuper = new VistaSuper();
                        vistaSuper.Show();
                        this.Close();
                    }
                } else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BIngresar_Click(sender, e);
            }
        }

        private void TContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void TUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BIngresar_Click(sender, e);
            }
        }
    }
}
