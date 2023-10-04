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
    public partial class BackupBD : Form
    {
        public BackupBD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas realizar un backup a la BD?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Base de datos restaurada con exito!");
            }
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            SFBackup.Title = "ElectroMarket_DB";

            SFBackup.Filter = "Archivos de texto (*.bak)|*.bak|Todos los archivos (*.*)|*.*";

            if (SFBackup.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Backup completado!");
            }
        }

    }
}
