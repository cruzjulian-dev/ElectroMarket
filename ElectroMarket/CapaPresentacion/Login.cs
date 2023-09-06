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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            VistaAdmin vistaAdmin = new VistaAdmin();
            vistaAdmin.Show();
            this.Close();









        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
