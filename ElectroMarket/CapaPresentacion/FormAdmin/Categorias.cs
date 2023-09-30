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

    public partial class CategoriasAdmin : Form
    {

        bool editar = false;
        public CategoriasAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Ceditar")
            {

                if (editar)
                {
                    return;
                }


                if (MessageBox.Show("Seguro que quieres editar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Habilita el botón "Editar"
                    btnEditar.Enabled = true;


                    // Obtén los valores de las celdas de la fila seleccionada
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    
                    comboBoxEstado.SelectedItem = selectedRow.Cells["Cestado"].Value.ToString();
                    txtDescripcion.Text = selectedRow.Cells["Cdescripcion"].Value.ToString();
                   


                    // Habilita el botón "Editar" para guardar los cambios después de la edición
                    btnEditar.Enabled = true;
                    // btnGuardar.Enabled = false;
                    editar = true;
                    btnAgregar.Enabled = false; // Deshabilita el botón "Agregar" mientras editas
                }
            }
        }

        private bool ValidarCampos()
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            // Verificar si se ha seleccionado una opción en los ComboBox
            
              if (comboBoxEstado.SelectedIndex == -1)
              {
                  MessageBox.Show("Por favor, seleccione un estado.");
                  return false;
              }

            // Si todos los campos están completos y se ha seleccionado una opción en los ComboBox, devuelve true
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                string opcionSeleccionada2 = comboBoxEstado.SelectedItem as string;
                string descripcion = txtDescripcion.Text;
        

                // Agregar fila al DataGridView
                int rowIndex = dataGridView1.Rows.Count;
                dataGridView1.Rows.Add(1);

                dataGridView1.Rows[rowIndex].Cells["Cestado"].Value = opcionSeleccionada2;
                dataGridView1.Rows[rowIndex].Cells["Cdescripcion"].Value = descripcion;

                dataGridView1.Rows[rowIndex].Cells["Ceditar"].Value = "Editar";

                limpiar();


            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                MessageBox.Show("No seleccionaste ninguna Categoria para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Preguntar al usuario si está seguro de editar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas modificar esta categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string descripcion = txtDescripcion.Text;
                    string opcionSeleccionada2 = comboBoxEstado.SelectedItem as string;

                    // Actualiza la fila seleccionada en el DataGridView
                    DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                    selectedRow.Cells["Cdescripcion"].Value = descripcion;
                    selectedRow.Cells["Cestado"].Value = opcionSeleccionada2;

                    // Limpia los controles del formulario
                    limpiar();

                    // Deshabilita el botón "Modificar" nuevamente
                    btnEditar.Enabled = false;
                    editar = false;

                    // Habilita el botón "Agregar" después de editar
                    btnAgregar.Enabled = true;
                }
                else if (result == DialogResult.No)
                {
                    // Si el usuario elige "No", habilita el botón "Agregar"
                    btnAgregar.Enabled = true;
                    btnEditar.Enabled = false;
                    limpiar() ; 
                }
            }
        }



        void limpiar()
        {
            //limpiar todo
           
            txtDescripcion.Clear();
            
            // Limpia la selección en el ComboBox para que aparezca vacío
            
            comboBoxEstado.SelectedIndex = -1;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancela la pulsación de la tecla si no es válida
                e.Handled = true;
            }

        }

        private void CategoriasAdmin_Load(object sender, EventArgs e)
        {
            // Por defecto, deshabilita el botón "Editar"
            btnEditar.Enabled = false;
        }
    }
}
