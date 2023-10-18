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
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class BackupBD : Form
    {
        public BackupBD()
        {
            InitializeComponent();
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            CN_Backup backupBD = new CN_Backup();

            using (SFBackup)
            {
                SFBackup.Title = "Guardar Backup";
                SFBackup.Filter = "Archivo Backup de SQL Server (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
                SFBackup.FileName = "Backup"; 


                if (SFBackup.ShowDialog() == DialogResult.OK)
                {
                    string rutaSeleccionada = SFBackup.FileName;

                    try
                    {
                        if (backupBD.RealizarBackup(rutaSeleccionada))
                        {
                            MessageBox.Show("Backup completado con éxito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al realizar el backup.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al realizar el backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
