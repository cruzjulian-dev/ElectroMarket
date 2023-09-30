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
                string codProducto = TCodProd.Text;
                string nombre = TNombre.Text;
                string opcionSeleccionada = CBCategoria.SelectedItem as string;
                string stock = TStock.Text;
                string opcionSeleccionada2 = CBEstado.SelectedItem as string;
                string descripcion = TDescripcion.Text;
                string precio = TPrecio.Text;

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
            TCodProd.Clear();
            TNombre.Clear();
            TDescripcion.Clear();
            TStock.Clear();
            TPrecio.Clear();
            // Limpia la selección en el ComboBox para que aparezca vacío
            CBCategoria.SelectedIndex = -1;
            CBEstado.SelectedIndex = -1;
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
                string codProducto = TCodProd.Text;
                string nombre = TNombre.Text;
                string opcionSeleccionada = CBCategoria.SelectedItem as string;
                string stock = TStock.Text;
                string opcionSeleccionada2 = CBEstado.SelectedItem as string;
                string descripcion = TDescripcion.Text;
                string precio = TPrecio.Text;

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

                btnGuardar.Enabled = true;
            }
           
        }

        private bool ValidarCampos()
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(TCodProd.Text) ||
                string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TStock.Text) ||
                string.IsNullOrWhiteSpace(TDescripcion.Text) ||
                string.IsNullOrWhiteSpace(TPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }

            // Verificar si se ha seleccionado una opción en los ComboBox
          if (CBCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CBEstado.SelectedIndex == -1)
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
                    TCodProd.Text = selectedRow.Cells["Ccodigo"].Value.ToString();
                    TNombre.Text = selectedRow.Cells["Cnombre"].Value.ToString();
                    CBCategoria.SelectedItem = selectedRow.Cells["Ccategoria"].Value.ToString();
                    CBEstado.SelectedItem = selectedRow.Cells["Cestado"].Value.ToString();
                    TDescripcion.Text = selectedRow.Cells["Cdescripcion"].Value.ToString();
                    TPrecio.Text = selectedRow.Cells["cprecio"].Value.ToString();
                    TStock.Text = selectedRow.Cells["ColStock"].Value.ToString();


                    // Habilita el botón "Editar" para guardar los cambios después de la edición
                    btnEditar.Enabled = true;
                     // btnGuardar.Enabled = false;
                    editar = true;
                    btnGuardar.Enabled = false; // Deshabilita el botón "Agregar" mientras editas
                }
            }
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datagridProd_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            /*
            foreach (DataGridViewRow row in datagridProd.Rows)
            {
                datagridProd.DefaultCellStyle.BackColor = Color.White;
                if (row.Cells["Estado"].Value.ToString() == "No Activo")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            
            // Cambiar el color de fondo de la fila en función de alguna condición

            String estado = Convert.ToString(datagridProd.Rows[e.RowIndex].Cells["Estado"].Value);
            if (e.RowIndex >= 0)
            {
                datagridProd.DefaultCellStyle.BackColor = Color.White;
                if (estado == "No Activo")
                {
                    // Cambiar el color de fondo de la fila
                    datagridProd.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    // Restaurar el color de fondo predeterminado
                    datagridProd.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
            */
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es una letra, número o espacio en blanco
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Si no es válido, marca el evento como manejado para evitar que se ingrese
                e.Handled = true;
            }
        }

        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni una tecla de borrar, cancela la entrada.
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }
    }
}
