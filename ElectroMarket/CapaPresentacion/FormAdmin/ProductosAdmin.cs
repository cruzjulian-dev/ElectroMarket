using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
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
            BEditar.Enabled = false;
            TIndice.Text = "0";
            CBCategoria.SelectedIndex = 0;
            TCodProd.BackColor = Color.Yellow;

            // combobox estado
            CBEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;


            //combobox filtros de busqueda
            foreach (DataGridViewColumn columna in DGProductos.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "Fecha de Nacimiento" && columna.HeaderText != "Estado" && columna.HeaderText != "Editar")
                {
                    CBBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            CBBusqueda.DisplayMember = "Texto";
            CBBusqueda.ValueMember = "Valor";
            CBBusqueda.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (TIndice.Text.Trim() == "" || TNombre.Text.Trim() == "" || TDescripcion.Text.Trim() == "" || TPrecio.Text.Trim() == "" || TStock.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que quieres guardar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TIndice.Text = (Convert.ToInt32(TIndice.Text) + 1).ToString();

                    // Agregar nueva fila
                    DGProductos.Rows.Add(TIndice.Text.Trim(), TNombre.Text.Trim(), TDescripcion.Text.Trim(), TPrecio.Text.Trim(), TStock.Text.Trim(), "", CBCategoria.SelectedItem.ToString(), ((OpcionCombo)CBEstado.SelectedItem).Texto, ((OpcionCombo)CBEstado.SelectedItem).Valor, "Editar");

                    LimpiarCampos();
                }
            }

        }

        void LimpiarCampos()
        {
            TCodProd.Clear();
            TNombre.Clear();
            TDescripcion.Clear();
            TStock.Clear();
            TPrecio.Clear();
            CBCategoria.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string codProducto = TCodProd.Text;
            string nombre = TNombre.Text;
            string descripcion = TDescripcion.Text;
            string stock = TStock.Text;
            string precio = TPrecio.Text;
            string categoria = CBCategoria.SelectedItem.ToString();
            string Estado = ((OpcionCombo)CBEstado.SelectedItem).Texto;

            if (TCodProd.Text.Trim() == "" || TNombre.Text.Trim() == "" || TDescripcion.Text.Trim() == "" || TStock.Text.Trim() == "" || TPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Actualiza la fila seleccionada en el DataGridView
                DataGridViewRow selectedRow = DGProductos.Rows[DGProductos.CurrentCell.RowIndex];

                selectedRow.Cells["Ccodigo"].Value = codProducto;
                selectedRow.Cells["Cnombre"].Value = nombre;
                selectedRow.Cells["CStock"].Value = stock;
                selectedRow.Cells["Cdescripcion"].Value = descripcion;
                selectedRow.Cells["cprecio"].Value = precio;
                selectedRow.Cells["Ccategoria"].Value = categoria;
                selectedRow.Cells["Cestado"].Value = Estado;
                selectedRow.Cells["CestadoVAlor"].Value = ((OpcionCombo)CBEstado.SelectedItem).Valor;

                foreach (DataGridViewRow row in DGProductos.Rows)
                {
                    // Obtener el valor de la celda en la columna "CEstado"
                    string estado = row.Cells["Cestado"].Value as string;

                    // Verificar si el estado es "No Activo"
                    if (estado == "No Activo")
                    {

                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }

                LimpiarCampos();
                BEditar.Enabled = false;
                BGuardar.Enabled = true;
            
            }
           
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número, un punto decimal o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número, un punto decimal ni una tecla de borrar, cancela la entrada.
                e.Handled = true;
            }
        }

        private void datagridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGProductos.Columns[e.ColumnIndex].Name == "Ceditar" && e.RowIndex >= 0)
            {

                if (MessageBox.Show("Seguro que quieres editar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BEditar.Enabled = true;
                    BGuardar.Enabled = false;

                    //TId.Text = DGClientes.Rows[e.RowIndex];
                    TIndice.Text = e.RowIndex.ToString();
                    int indice = e.RowIndex;

                    // Obtengo los valores de las celdas de la fila seleccionada
                    DataGridViewRow selectedRow = DGProductos.Rows[e.RowIndex];

                    TCodProd.Text = selectedRow.Cells["Ccodigo"].Value.ToString();
                    TNombre.Text = selectedRow.Cells["Cnombre"].Value.ToString();
                    CBCategoria.SelectedItem = selectedRow.Cells["Ccategoria"].Value.ToString();
                    TDescripcion.Text = selectedRow.Cells["Cdescripcion"].Value.ToString();
                    TPrecio.Text = selectedRow.Cells["cprecio"].Value.ToString();
                    TStock.Text = selectedRow.Cells["CStock"].Value.ToString();

                    foreach (OpcionCombo oc in CBEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGProductos.Rows[indice].Cells["CestadoVAlor"].Value))
                        {
                            int indice_combo = CBEstado.Items.IndexOf(oc);
                            CBEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ';' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
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

        private void BBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CBBusqueda.SelectedItem).Valor.ToString();

            if (DGProductos.Rows.Count > 0)  // pregunta si hay filas
            {
                foreach (DataGridViewRow row in DGProductos.Rows) // recorro cada fila del datagrid
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TBusqueda.Text.Trim().ToUpper())) //obtengo el valor de la fila que estoy recorriendo
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }

                }
            }
        }

        private void DGProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in DGProductos.Rows)
            {
                // Obtener el valor de la celda en la columna "CEstado"
                string estado = row.Cells["Cestado"].Value as string;

                // Verificar si el estado es "No Activo"
                if (estado == "No Activo")
                {

                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
