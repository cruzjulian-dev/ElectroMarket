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
    public partial class ProductosAdmin : Form
    {
        public ProductosAdmin()
        {
            InitializeComponent();
        }

        private void AgregarProcucto_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Mostrar un MessageBox satisfactorio
                MessageBox.Show("Operación completada con éxito.", "Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Continúa con la acción de guardar u otra acción.
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(textBoxCodprod.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }

            // Verificar si se ha seleccionado una opción en los ComboBox
          /* if (comboBox1Cate.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una categoría.");
                return false;
            }

            if (comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un estado.");
                return false;
            } */

            // Si todos los campos están completos y se ha seleccionado una opción en los ComboBox, devuelve true
            return true;
        }

        private void textBoxCodprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni una tecla de borrar, cancela la entrada.
                e.Handled = true;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número, un punto decimal o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número, un punto decimal ni una tecla de borrar, cancela la entrada.
                e.Handled = true;
            }
        }
    }
}
