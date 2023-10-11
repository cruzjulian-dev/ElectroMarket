using CapaNegocio;
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OPSeleccionarBd.Title = "Seleccionar Archivo de Backup";
            OPSeleccionarBd.Filter = "Archivo Backup de SQL Server (*.bak)|*.bak|Todos los archivos (*.*)|*.*";

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
                    if (!TSeleccionado.Text.EndsWith(".bak"))
                    {
                        MessageBox.Show("Debes seleccionar un archivo .bak!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        CN_Restaurar restaurarBD = new CN_Restaurar();
                        try
                        {
                            if (restaurarBD.RestaurarBackup(TSeleccionado.Text))
                            {
                                MessageBox.Show("Restauración completada con éxito.");
                            }
                            else
                            {
                                MessageBox.Show("Error al realizar la restauración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al realizar la restauración: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
                
            }
        }
    }
}
