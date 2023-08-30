using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroMarket
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Validar que no ingresen ,.'@# pero si numeros y digitos
             * 
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            */
        }

        private void TContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Validar que no ingresen ,.'@# pero si numeros y digitos
             * 
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            */
        }

        private void BIniciar_Click(object sender, EventArgs e)
        {
            if (TUsuario.Text.Trim() == "" || TContra.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                
            }
        }
    }
}