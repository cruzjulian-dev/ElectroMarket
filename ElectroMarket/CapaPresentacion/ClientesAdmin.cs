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

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni una tecla de borrar, cancela la entrada.
                e.Handled = true;
            }
        }

        private void TFecha_Validating(object sender, CancelEventArgs e)
        {
            DateTime fecha;
            if (!DateTime.TryParse(TFecha.Text, out fecha))
            {
                // La fecha ingresada no es válida
                MessageBox.Show("Por favor, ingrese una fecha válida en formato dd/mm/aaaa.", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Evita que el foco cambie al siguiente control
                e.Cancel = true;
            }
        }

        private void TDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es una letra, número o espacio en blanco
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Si no es válido, marca el evento como manejado para evitar que se ingrese
                e.Handled = true;
            }
        }
    }
}
