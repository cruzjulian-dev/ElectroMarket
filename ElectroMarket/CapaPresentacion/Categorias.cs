using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CapaPresentacion
{
    public partial class CategoriasAdmin : Form
    {
        public CategoriasAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
               


                txtDescripcion.Clear();
                // Limpia la selección en el ComboBox para que aparezca vacío
                comboBoxEstado.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
