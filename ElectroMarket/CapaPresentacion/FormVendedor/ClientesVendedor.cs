using CapaPresentacion.Utilidades;
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

namespace CapaPresentacion
{
    public partial class ClientesVendedor : Form
    {
        public ClientesVendedor()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            BEditar.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void LDni_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || Ttel.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TDni.Text.Trim().Length != 8)
                {
                    MessageBox.Show("El DNI debe tener exactamente 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Seguro que quieres guardar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        // Agregar nueva fila
                        DGClientes.Rows.Add("", TNombre.Text.Trim(), TApellido.Text.Trim(), TDni.Text.Trim(), DTFecha.Text.Trim(), Ttel.Text.Trim(), TDomicilio.Text.Trim(), "Editar");

                        LimpiarCampos();
                    }
                }

            }
           
        }

        private void DGCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGClientes.Columns[e.ColumnIndex].Name == "Ceditar" && e.RowIndex >= 0)
            {

                if (MessageBox.Show("Seguro que quieres editar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Habilita el botón "Editar"
                    BEditar.Enabled = true;
                    BGuardar.Enabled = false;

                    //TId.Text = DGClientes.Rows[e.RowIndex];
                    //TIndice.Text = e.RowIndex.ToString();
                    int indice = e.RowIndex;

                    // Obtengo los valores de las celdas de la fila seleccionada
                    DataGridViewRow selectedRow = DGClientes.Rows[e.RowIndex];

                    TNombre.Text = selectedRow.Cells["CNombre"].Value.ToString();
                    TApellido.Text = selectedRow.Cells["CApellido"].Value.ToString();
                    TDni.Text = selectedRow.Cells["Cdni"].Value.ToString();
                    DTFecha.Text = selectedRow.Cells["CFechaNacim"].Value.ToString();
                    Ttel.Text = selectedRow.Cells["CTelefono"].Value.ToString();
                    TDomicilio.Text = selectedRow.Cells["CDomicilio"].Value.ToString();
                }
            }


        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            string domicilio = TDomicilio.Text;
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;
            string telefono = Ttel.Text;
            string dni = TDni.Text;

            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || Ttel.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TDni.Text.Trim().Length != 8)
                {
                    MessageBox.Show("El DNI debe tener 8 exactamente 8 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Actualiza la fila seleccionada en el DataGridView
                    DataGridViewRow selectedRow = DGClientes.Rows[DGClientes.CurrentCell.RowIndex];
                    selectedRow.Cells["CDomicilio"].Value = domicilio;
                    selectedRow.Cells["Cdni"].Value = dni;
                    selectedRow.Cells["CTelefono"].Value = telefono;
                    selectedRow.Cells["CNombre"].Value = nombre;
                    selectedRow.Cells["CApellido"].Value = apellido;


                    DateTime nuevaFecha = DTFecha.Value;
                    selectedRow.Cells["CFechaNacim"].Value = nuevaFecha.ToString("d");

                    LimpiarCampos();
                    BEditar.Enabled = false;
                    BGuardar.Enabled = true;
                }

            }


        }

        private void LimpiarCampos()
        {
            // Limpia los campos
            TNombre.Text = "";
            TApellido.Text = "";
            TDni.Text = "";
            DTFecha.Text = "";
            TDomicilio.Text = "";
            Ttel.Text = "";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DTFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void LCorreo_Click(object sender, EventArgs e)
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

        private void Ttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni una tecla de borrar, cancela la entrada.
                e.Handled = true;
            }
        }

        private void TDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es una letra, número o espacio en blanco,
            // o si es el carácter de borrado (Retroceso o Suprimir)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                // Si no es válido, marca el evento como manejado para evitar que se ingrese
                e.Handled = true;
            }
        }


        private bool ValidarCampos()
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TDomicilio.Text) ||
                string.IsNullOrWhiteSpace(Ttel.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            // Verificar si se ha seleccionado una fecha en el DateTimePicker
            if (DTFecha.Value == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, seleccione una fecha de nacimiento válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Si todos los campos están completos y se ha seleccionado una opción en los ComboBox, y una fecha en el DateTimePicker, devuelve true
            return true;
        }
    }
}
