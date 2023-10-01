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
            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || Ttel.Text.Trim() == "" || CBEstado.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que quieres guardar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    // Agregar nueva fila
                    DGClientes.Rows.Add(TNombre.Text.Trim(), TApellido.Text.Trim(), TDni.Text.Trim(), DTFecha.Text.Trim(), Ttel.Text.Trim(), TDomicilio.Text.Trim() , CBEstado.SelectedItem.ToString());


                    foreach (DataGridViewRow row in DGClientes.Rows)
                    {
                        row.Cells["Ceditar"].Value = "Editar";
                    }
                    TNombre.Text = "";
                    TApellido.Text = "";
                    TDni.Text = "";
                    DTFecha.Text = "";
                    TDomicilio.Text = "";
                    Ttel.Text = "";

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
                string domicilio = TDomicilio.Text;
                string nombre = TNombre.Text;
                string apellido = TApellido.Text;
                string telefono = Ttel.Text;
                string dni = TDni.Text;
                string Estado = CBEstado.SelectedItem as string;

                // Actualiza la fila seleccionada en el DataGridView
                DataGridViewRow selectedRow = DGClientes.Rows[DGClientes.CurrentCell.RowIndex];
                selectedRow.Cells["CDomicilio"].Value = domicilio;
                selectedRow.Cells["Cdni"].Value = dni;
                selectedRow.Cells["CTelefono"].Value = telefono;

                selectedRow.Cells["CNombre"].Value = nombre;
                selectedRow.Cells["CApellido"].Value = apellido;


                selectedRow.Cells["Cestado"].Value = Estado;
                // Obtiene la fecha seleccionada en el DateTimePicker.
                DateTime nuevaFecha = DTFecha.Value;
                // Actualiza el valor de la columna "CFechaNacim" en la fila seleccionada.
                selectedRow.Cells["CFechaNacim"].Value = nuevaFecha.ToString("d");

                // Limpia los controles del formulario
                TNombre.Text = "";
                TApellido.Text = "";
                TDni.Text = "";
                DTFecha.Text = "";
                TDomicilio.Text = "";
                Ttel.Text = "";
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
            if (DGClientes.Columns[e.ColumnIndex].Name == "Ceditar")
            {

                if (editar)
                {
                    return;
                }


                if (MessageBox.Show("Seguro que quieres editar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Habilita el botón "Editar"
                    BEditar.Enabled = true;


                    // Obtén los valores de las celdas de la fila seleccionada
                    DataGridViewRow selectedRow = DGClientes.Rows[e.RowIndex];

                    CBEstado.SelectedItem = selectedRow.Cells["Cestado"].Value.ToString();
                    TNombre.Text = selectedRow.Cells["CNombre"].Value.ToString();
                    TApellido.Text = selectedRow.Cells["CApellido"].Value.ToString();
                    TDni.Text = selectedRow.Cells["Cdni"].Value.ToString();

                    // Obtiene la fecha de la columna "Fecha" de la fila seleccionada.
                    string fechaString = DGClientes.Rows[e.RowIndex].Cells["CFechaNacim"].Value.ToString();

                    // Convierte la cadena de fecha en un objeto DateTime.
                    if (DateTime.TryParse(fechaString, out DateTime fecha))
                    {
                        // Establece la fecha en el DateTimePicker con el formato corto.
                        DTFecha.Value = fecha;
                    }
                    else
                    {
                        // Manejar el caso en el que no se pueda convertir la fecha.
                        MessageBox.Show("No se pudo obtener la fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Ttel.Text = selectedRow.Cells["CTelefono"].Value.ToString();
                    TDomicilio.Text = selectedRow.Cells["CDomicilio"].Value.ToString();

                    // Habilita el botón "Editar" para guardar los cambios después de la edición
                    BEditar.Enabled = true;
                    // btnGuardar.Enabled = false;
                    editar = true;
                    BGuardar.Enabled = false; // Deshabilita el botón "Agregar" mientras editas
                }
            }
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
        { }


        private void TDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es una letra, número o espacio en blanco
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Si no es válido, marca el evento como manejado para evitar que se ingrese
                e.Handled = true;
            }
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lEstado_Click(object sender, EventArgs e)
        {

        }

        private void Ttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni una tecla de borrar, cancela la entrada.
                e.Handled = true;
            }
        }
    }
}
