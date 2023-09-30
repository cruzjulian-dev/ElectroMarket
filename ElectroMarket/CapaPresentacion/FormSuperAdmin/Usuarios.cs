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
using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Utilidades;

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

            DGUsuarios.Rows.Add(new object[] { TNombre.Text, TApellido.Text, TDni.Text, TUsuario.Text, TContra.Text,
            ((OpcionCombo)CBRol.SelectedItem).Valor.ToString(), ((OpcionCombo)CBRol.SelectedItem).Texto.ToString(),
            DTFecha.Text, TTelefono.Text, TDomicilio.Text,
            ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString(), ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString(),

            });

            Limpiar();

            /*
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
            */
        }

        private void Limpiar()
        {
            
            TNombre.Text = "";
            TApellido.Text = "";
            TDni.Text = "";
            TUsuario.Text = "";
            TContra.Text = "";
            DTFecha.Text = "";
            TDomicilio.Text = "";
            TTelefono.Text = "";
            CBRol.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
        }

        private void BEditar_Click(object sender, EventArgs e)
        {

        }

        private void DGUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                CBRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }

            CBRol.DisplayMember = "Texto";
            CBRol.ValueMember = "Valor";
            CBRol.SelectedIndex = 0;
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
