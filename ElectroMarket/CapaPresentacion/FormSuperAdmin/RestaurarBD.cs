using Microsoft.Win32;
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
    public partial class RestaurarBD : Form
    {
        public RestaurarBD()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RestaurarBD_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OPSeleccionarBd.Filter = "Archivos de Base de Datos (*.bak)|*.bak|Todos los archivos (*.*)|*.*";

            if (OPSeleccionarBd.ShowDialog() == DialogResult.OK)
            {
                TSeleccionado.Text = OPSeleccionarBd.FileName;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres restaurar la base de datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TSeleccionado.Text == "")
                {
                    MessageBox.Show("No has seleccionado ninguna base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    TSeleccionado.Text = "";
                    MessageBox.Show("Base de datos restaurada con exito!");
                }
                
            }
        }
    }
}
