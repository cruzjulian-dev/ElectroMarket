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
using System.Windows.Forms.VisualStyles;

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
                string codProducto = textBoxCodprod.Text;
                string nombre = txtNombre.Text;
                string opcionSeleccionada = comboBox1Cate.SelectedItem as string;
                string stock = textBoxStock.Text;
                string opcionSeleccionada2 = comboBoxEstado.SelectedItem as string;
                string descripcion = txtDescripcion.Text;
                string precio = txtPrecio.Text;

                // Agregar fila al DataGridView
                int rowIndex = datagridProd.Rows.Count;
                datagridProd.Rows.Add(1);

                datagridProd.Rows[rowIndex].Cells["Cestado"].Value = opcionSeleccionada2;
                datagridProd.Rows[rowIndex].Cells["Ccategoria"].Value = opcionSeleccionada;
                datagridProd.Rows[rowIndex].Cells["ColStock"].Value = stock;
                datagridProd.Rows[rowIndex].Cells["Ccodigo"].Value = codProducto;
                datagridProd.Rows[rowIndex].Cells["Cnombre"].Value = nombre;
                datagridProd.Rows[rowIndex].Cells["Cdescripcion"].Value = descripcion;
                datagridProd.Rows[rowIndex].Cells["cprecio"].Value = precio;

                //limpiar todo
                textBoxCodprod.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                textBoxStock.Clear();
                txtPrecio.Clear();
                // Limpia la selección en el ComboBox para que aparezca vacío
                comboBox1Cate.SelectedIndex = -1;
                comboBoxEstado.SelectedIndex = -1;
               
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (datagridProd.SelectedRows.Count > 0)
            {
                // Se ha seleccionado al menos una fila, procede a la edición

                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = datagridProd.SelectedRows[0];

                // Obtén los valores de las celdas y asígnalos a los controles en el formulario
                string codProducto = selectedRow.Cells["Ccodigo"].Value.ToString();
                string nombre = selectedRow.Cells["Cnombre"].Value.ToString();
                string categoria = selectedRow.Cells["Ccategoria"].Value.ToString();
                string estado = selectedRow.Cells["Cestado"].Value.ToString();
                string descripcion = selectedRow.Cells["Cdescripcion"].Value.ToString();
                string precio = selectedRow.Cells["cprecio"].Value.ToString();

                // Asigna los valores a los controles en el formulario para su edición
                textBoxCodprod.Text = codProducto;
                txtNombre.Text = nombre;
                comboBox1Cate.SelectedItem = categoria;
                comboBoxEstado.SelectedItem = estado;
                txtDescripcion.Text = descripcion;
                txtPrecio.Text = precio;

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private bool ValidarCampos()
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(textBoxCodprod.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxStock.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }

            // Verificar si se ha seleccionado una opción en los ComboBox
          if (comboBox1Cate.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxEstado.SelectedIndex == -1)
            {
          
                MessageBox.Show("Por favor, seleccione un estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            } 

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
