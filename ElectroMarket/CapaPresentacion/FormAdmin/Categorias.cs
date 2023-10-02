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
                    BEditar.Enabled = true;


                    // Obtén los valores de las celdas de la fila seleccionada
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    
                    TEstado.SelectedItem = selectedRow.Cells["Cestado"].Value.ToString();
                    TDescripcion.Text = selectedRow.Cells["Cdescripcion"].Value.ToString();
                   


                    // Habilita el botón "Editar" para guardar los cambios después de la edición
                    BEditar.Enabled = true;
                    // btnGuardar.Enabled = false;
                    editar = true;
                    BAgregar.Enabled = false; // Deshabilita el botón "Agregar" mientras editas
                }
            }
        }

        private bool ValidarCampos()
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(TDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            // Verificar si se ha seleccionado una opción en los ComboBox
            
              if (TEstado.SelectedIndex == -1)
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
                string opcionSeleccionada2 = TEstado.SelectedItem as string;
                string descripcion = TDescripcion.Text;
        

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
                string descripcion = TDescripcion.Text;
                string opcionSeleccionada2 = TEstado.SelectedItem as string;

                // Actualiza la fila seleccionada en el DataGridView
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                selectedRow.Cells["Cdescripcion"].Value = descripcion;
                selectedRow.Cells["Cestado"].Value = opcionSeleccionada2;



                // Limpia los controles del formulario
                limpiar();
                // Deshabilita el botón "Modificar" nuevamente
                BEditar.Enabled = false;

                editar = false;

                BAgregar.Enabled = true;
            }

        }



        void limpiar()
        {
            //limpiar todo
           
            TDescripcion.Clear();
            
            // Limpia la selección en el ComboBox para que aparezca vacío
            
            TEstado.SelectedIndex = -1;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es una letra, número, espacio en blanco, coma o cualquier otro carácter permitido,
            // o si es el carácter de borrado (Retroceso o Suprimir)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ';' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                // Si no es válido, marca el evento como manejado para evitar que se ingrese
                e.Handled = true;
            }
        }


        private void CategoriasAdmin_Load(object sender, EventArgs e)
        {
            // Por defecto, deshabilita el botón "Editar"
            BEditar.Enabled = false;
        }
    }
}
