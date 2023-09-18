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

        bool editar = false;

        public ProductosAdmin()
        {
            InitializeComponent();

            // Suscribe el evento CellContentClick del DataGridView
            datagridProd.CellContentClick += new DataGridViewCellEventHandler(datagridProd_CellContentClick);
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
                datagridProd.Rows[rowIndex].Cells["Ceditar"].Value = "Editar";

                limpiar();
               
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limpiar()
        {
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

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (editar == false)
            {
                MessageBox.Show("No seleccionaste ningun registro para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                // Obtén los valores de las celdas seleccionadas y realiza la edición
                string codProducto = textBoxCodprod.Text;
                string nombre = txtNombre.Text;
                string opcionSeleccionada = comboBox1Cate.SelectedItem as string;
                string stock = textBoxStock.Text;
                string opcionSeleccionada2 = comboBoxEstado.SelectedItem as string;
                string descripcion = txtDescripcion.Text;
                string precio = txtPrecio.Text;

                // Actualiza la fila seleccionada en el DataGridView
                DataGridViewRow selectedRow = datagridProd.Rows[datagridProd.CurrentCell.RowIndex];
                selectedRow.Cells["Ccodigo"].Value = codProducto;
                selectedRow.Cells["Cnombre"].Value = nombre;
                selectedRow.Cells["ColStock"].Value = stock;
                selectedRow.Cells["Cdescripcion"].Value = descripcion;
                selectedRow.Cells["cprecio"].Value = precio;
                selectedRow.Cells["Ccategoria"].Value = opcionSeleccionada;
                selectedRow.Cells["Cestado"].Value = opcionSeleccionada2;

                // Limpia los controles del formulario
                limpiar();

                // Deshabilita el botón "Modificar" nuevamente
                btnEditar.Enabled = false;

                editar = false;
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

        private void datagridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridProd.Columns[e.ColumnIndex].Name == "Ceditar")
            {

                if (editar)
                {
                    return;
                }
                   
                
                if (MessageBox.Show("Seguro que quieres editar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    
                    // Obtén los valores de las celdas de la fila seleccionada
                    DataGridViewRow selectedRow = datagridProd.Rows[e.RowIndex];
                    textBoxCodprod.Text = selectedRow.Cells["Ccodigo"].Value.ToString();
                    txtNombre.Text = selectedRow.Cells["Cnombre"].Value.ToString();
                    comboBox1Cate.SelectedItem = selectedRow.Cells["Ccategoria"].Value.ToString();
                    comboBoxEstado.SelectedItem = selectedRow.Cells["Cestado"].Value.ToString();
                    txtDescripcion.Text = selectedRow.Cells["Cdescripcion"].Value.ToString();
                    txtPrecio.Text = selectedRow.Cells["cprecio"].Value.ToString();
                    textBoxStock.Text = selectedRow.Cells["ColStock"].Value.ToString();


                    // Habilita el botón "Editar" para guardar los cambios después de la edición
                    btnEditar.Enabled = true;
                    btnGuardar.Enabled = false;
                    editar = true;
                }
            }
        }

       

        
    }
}
