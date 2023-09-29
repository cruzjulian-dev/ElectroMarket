using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CapaPresentacion
{
    public partial class ClientesAdmin : Form
    {

        bool editar = false;
        public ClientesAdmin()
        {
            InitializeComponent();
        }

        private void ClientesAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || TCorreo.Text.Trim() == "" || comboBoxEstado.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que quieres guardar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Agregar nueva fila
                    DGClientes.Rows.Add(TId.Text.Trim(), TNombre.Text.Trim(), TApellido.Text.Trim(), TDni.Text.Trim(), TFecha.Text.Trim(), TDomicilio.Text.Trim(), TCorreo.Text.Trim(), comboBoxEstado.SelectedItem.ToString());

                    foreach (DataGridViewRow row in DGClientes.Rows)
                    {
                        row.Cells["Ceditar"].Value = "Editar";
                    }
                    TId.Text = "";
                    TNombre.Text = "";
                    TApellido.Text = "";
                    TDni.Text = "";
                    TFecha.Text = "";
                    TDomicilio.Text = "";
                    TCorreo.Text = "";

                    //editar = false;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void TDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LCorreo_Click(object sender, EventArgs e)
        {

        }

        private void LFecha_Click(object sender, EventArgs e)
        {

        }

        private void LDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void LDni_Click(object sender, EventArgs e)
        {

        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                MessageBox.Show("No seleccionaste ningun registro para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

             

                // Limpia los controles del formulario
                //limpiar();

                // Deshabilita el botón "Modificar" nuevamente
                BEditar.Enabled = false;

                editar = false;

                BGuardar.Enabled = true;
            }
        }

        private void DGClientes_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Cambiar el color de fondo de la fila en función de alguna condición
            if (e.RowIndex >= 0)
            {
                String estado = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells["Cestado"].Value);
                DGClientes.DefaultCellStyle.BackColor = Color.White;
                if (estado == "No Activo")
                {
                    // Cambiar el color de fondo de la fila
                    DGClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    // Restaurar el color de fondo predeterminado
                    DGClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void DGClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
