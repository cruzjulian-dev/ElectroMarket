using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Usuarios : Form
    {
        //SistemaEntidades bd = new SistemaEntidades();
        int filaSeleccionada;
        bool editar = false;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || TTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que quieres guardar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Agregar nueva fila
                    DGUsuarios.Rows.Add(1, TUsuario.Text.Trim(), TNombre.Text.Trim(), TApellido.Text.Trim(), TDni.Text.Trim(), DTFecha.Text.Trim(), TDomicilio.Text.Trim(), TTelefono.Text.Trim());

                    //Usuario usuario = new Usuario();
                    //bd.Usuarios.Add(usuario);
                    //bd.SaveChanges();

                    foreach (DataGridViewRow row in DGUsuarios.Rows)
                    {
                        row.Cells["Ceditar"].Value = "Editar";
                    }
                    TUsuario.Text = "";
                    TNombre.Text = "";
                    TApellido.Text = "";
                    TDni.Text = "";
                    DTFecha.Text = "";
                    TDomicilio.Text = "";
                    TTelefono.Text = "";

                    editar = false;
                }
            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {

        }

        private void DGUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            //DGUsuarios.DataSource = bd.Usuarios.ToList();
        }

        private void TUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            */
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void TUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
