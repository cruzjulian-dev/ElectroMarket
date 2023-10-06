using CapaEntidades;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
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
    public partial class RegistrarVenta : Form
    {
        public RegistrarVenta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            TTipoDoc.SelectedIndex = -1;
            TCantidad.Minimum = 1;
            TFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            // Ajusta automáticamente el tamaño del encabezado al contenido de las celdas
            DGDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTotal.Text = Convert.ToDecimal(0).ToString();
            TCambio.Text = Convert.ToDecimal(0).ToString();
        }

        private void icoBtnBuscar_Click(object sender, EventArgs e)
        {
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.ShowDialog();

            if (listaClientes.ClienteSeleccionado != null)
            {
                Cliente ClienteSeleccionado = listaClientes.ClienteSeleccionado;
                TDni.Text = ClienteSeleccionado.Dni.ToString();
                TNomApe.Text = ClienteSeleccionado.Nombre + " " + ClienteSeleccionado.Apellido;
            }
        }

        private void btnBuscarProduc_Click(object sender, EventArgs e)
        {
            ListaProductos listaProd = new ListaProductos();
            listaProd.FuenteFormulario = "RegistrarVenta";
            listaProd.ShowDialog();
            

            if (listaProd.ProductoSeleccionado != null)
            {
                Producto productoSeleccionado = listaProd.ProductoSeleccionado;
                TCod.Text = productoSeleccionado.Codigo.ToString();
                TProd.Text = productoSeleccionado.Nombre.ToString();
                TPrecio.Text = productoSeleccionado.Precio.ToString();
                TStock.Text = productoSeleccionado.Stock.ToString();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TCod.Text == "" || TProd.Text == "" || TPrecio.Text == "" || TStock.Text == "" || TCantidad.Value < 1)
                {
                    MessageBox.Show("Debes seleccionar un producto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show("Seguro que quieres agregar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string codigo = TCod.Text;
                        string nombre = TProd.Text;
                        decimal precio = 0.0m; // Inicializado a 0.0m
                        int cantidad = 0;
                        decimal subtotal = 0.0m; // Inicializado a 0.0m

                        if (!decimal.TryParse(TPrecio.Text, out precio))
                        {
                            MessageBox.Show("El precio no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Salir del método si el precio no es válido
                        }

                        if (!int.TryParse(TCantidad.Value.ToString(), out cantidad))
                        {
                            MessageBox.Show("La cantidad no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Salir del método si la cantidad no es válida
                        }

                        subtotal = precio * cantidad;

                        // Agregar la fila al DataGridView
                        DGDetalle.Rows.Add("", codigo, nombre, precio.ToString(), cantidad.ToString(), subtotal.ToString(), "Eliminar");

                        // Limpia los TextBox y el NumericUpDown después de agregar los datos al DataGridView
                        TCod.Clear();
                        TProd.Clear();
                        TPrecio.Clear();
                        TStock.Clear();
                        TCantidad.Value = 1;

                        // Actualizar precio total
                        TTotal.Text = (Convert.ToDecimal(TTotal.Text) + precio).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y muestra información de depuración
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void iconButtonVenta_Click(object sender, EventArgs e)
        {
            if (DGDetalle.RowCount > 0)
            {
                if (TFecha.Text == "" || TTipoDoc.Text == "" || TDni.Text == "" || TNomApe.Text == "" || TTotal.Text == "" || TPagaCon.Text == "" || TCambio.Text == "" || CBForma.SelectedIndex == -1 || TTipoDoc.SelectedIndex == -1)
                {
                    MessageBox.Show("Debes completar todos los campos antes de realizar una venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    decimal pago = Convert.ToDecimal(TPagaCon.Text);
                    decimal total = Convert.ToDecimal(TTotal.Text);
                    if (pago <= total)
                    {
                        MessageBox.Show("El Monto pagado es menor que el Precio Total!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (MessageBox.Show("Seguro que quieres realizar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Venta realizada con exito!", "Nueva venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VaciarCampos();
                        }
                        
                    }
                }

            } else
            {
                MessageBox.Show("No has agregado ningun producto al detalle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void VaciarCampos()
        {
            TDni.Text = "";
            TNomApe.Text = "";
            TCod.Text = "";
            TProd.Text = "";
            TPrecio.Text = "";
            TStock.Text = "";
            TTotal.Text = Convert.ToDecimal(0).ToString();
            TPagaCon.Text = "";
            TCambio.Text = Convert.ToDecimal(0).ToString();
            CBForma.SelectedIndex = -1;
            TTipoDoc.SelectedIndex = -1;
            DGDetalle.Rows.Clear();
        }

        private void TPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni una tecla de borrar, cancela la entrada.
                e.Handled = true;
            }
        }

        private void TPagaCon_TextChanged(object sender, EventArgs e)
        {
            // Verifica si el texto ingresado en TPagaCon es un número válido.
            if (decimal.TryParse(TPagaCon.Text, out decimal pago))
            {
                decimal total = Convert.ToDecimal(TTotal.Text);

                if (pago >= total)
                {
                    // Si el pago es mayor o igual al total, calcula el cambio y actualiza TCambio.
                    decimal cambio = pago - total;
                    TCambio.Text = cambio.ToString();
                }
                else
                {
                    // Si el pago es menor que el total, muestra un mensaje de error o realiza otra acción apropiada.
                    TCambio.Text = "Pago insuficiente"; // O muestra un mensaje de error
                }
            }
            else
            {
                // Si el texto ingresado no es un número válido, muestra un mensaje de error o realiza otra acción apropiada.
                TCambio.Text = "Error"; // O muestra un mensaje de error
            }
        }

        private void DGDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGDetalle.Columns[e.ColumnIndex].Name == "CEliminar" && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Seguro que quitar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    // Obtén los valores de las celdas de la fila seleccionada
                    DataGridViewRow selectedRow = DGDetalle.Rows[e.RowIndex];

                    // Actualizar precio total
                    decimal precioProducto = Convert.ToDecimal(selectedRow.Cells["CPrecio"].Value);
                    decimal precioTotalActual = Convert.ToDecimal(TTotal.Text);
                    TTotal.Text = (precioTotalActual - precioProducto).ToString();

                    //eliminar fila seleccionada
                    DGDetalle.Rows.Remove(selectedRow);
                }
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            VaciarCampos();
        }

    }
}
