using CapaEntidades;
using CapaNegocio;
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
        private CN_Producto negocioProducto = new CN_Producto();
        private List<Producto> listaProductos = new List<Producto>();

        public RegistrarVenta()
        {
            InitializeComponent();
            // Aquí obtienes la lista de productos desde la capa de negocios.
            listaProductos = negocioProducto.ObtenerListaDeProductos();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            BEditar.Enabled = false;
            TTipoDoc.SelectedIndex = -1;
            TCantidad.Minimum = 1;
            TCantidad.Maximum = 999999;
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

        private Producto ObtenerProductoPorCodigo(string codigo)
        {
            // Aquí buscas el producto en la lista completa de productos por su código
            Producto productoEncontrado = listaProductos.FirstOrDefault(producto => producto.Codigo == codigo);
            return productoEncontrado;
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
                    string codigo = TCod.Text;

                    // Verifica si el producto ya existe en el DataGridView
                    bool productoExistente = false;

                    foreach (DataGridViewRow row in DGDetalle.Rows)
                    {
                        if (row.Cells["CCod"].Value != null && row.Cells["CCod"].Value.ToString() == codigo)
                        {
                            productoExistente = true;
                            break;
                        }
                    }

                    if (productoExistente)
                    {
                        MessageBox.Show("El producto ya fue agregado anteriormente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Seguro que quieres agregar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
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
                            DGDetalle.Rows.Add("", codigo, nombre, precio.ToString(), cantidad.ToString(), subtotal.ToString(), "Eliminar", "Editar");

                            // Limpia los TextBox y el NumericUpDown después de agregar los datos al DataGridView
                            TCod.Clear();
                            TProd.Clear();
                            TPrecio.Clear();
                            TStock.Clear();
                            TCantidad.Value = 1;

                            // Actualizar precio total
                            TTotal.Text = (Convert.ToDecimal(TTotal.Text) + subtotal).ToString();
                        }
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
            if (e.RowIndex >= 0)
            {
                if (DGDetalle.Columns[e.ColumnIndex].Name == "CEliminar")
                {
                    if (MessageBox.Show("Seguro que quitar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Obtén los valores de las celdas de la fila seleccionada
                        DataGridViewRow selectedRow = DGDetalle.Rows[e.RowIndex];

                        // Actualizar precio total
                        decimal precioProducto = Convert.ToDecimal(selectedRow.Cells["CPrecio"].Value);
                        decimal precioTotalActual = Convert.ToDecimal(TTotal.Text);
                        TTotal.Text = (precioTotalActual - precioProducto).ToString();

                        // Eliminar fila seleccionada
                        DGDetalle.Rows.Remove(selectedRow);
                    }
                }
                else if (DGDetalle.Columns[e.ColumnIndex].Name == "Ceditar")
                {
                    if (MessageBox.Show("Seguro que quieres editar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Deshabilito el boton buscar producto
                        BProd.Enabled = false;

                        // Habilita el botón "Editar"
                        BEditar.Enabled = true;

                        // Deshabilita el botón "Guardar"
                        BAgregar.Enabled = false;

                        // Obtén el código del producto seleccionado en el DataGridView
                        string codigoProductoSeleccionado = DGDetalle.Rows[e.RowIndex].Cells["CCod"].Value.ToString();

                        // Busca el producto en la lista completa de productos por su código
                        Producto productoSeleccionado = ObtenerProductoPorCodigo(codigoProductoSeleccionado);

                        if (productoSeleccionado != null)
                        {
                            // Rellenar los TextBox con los valores del producto seleccionado
                            TCod.Text = productoSeleccionado.Codigo;
                            TProd.Text = productoSeleccionado.Nombre;
                            TPrecio.Text = productoSeleccionado.Precio.ToString();

                            // Aquí obtén el stock del producto seleccionado
                            int stock = productoSeleccionado.Stock;

                            // Luego, asigna el stock a tu campo TStock o donde desees mostrarlo
                            TStock.Text = stock.ToString();

                            TCantidad.Value = Convert.ToInt32(DGDetalle.Rows[e.RowIndex].Cells["Ccantidad"].Value);
                        }
                        else
                        {
                            MessageBox.Show("El producto no se encontró en la lista de productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            VaciarCampos();
        }

        private void TCantidad_ValueChanged(object sender, EventArgs e)
        {
            int stockDisponible = 0;

            if (!string.IsNullOrEmpty(TStock.Text) && int.TryParse(TStock.Text, out stockDisponible))
            {
                if (TCantidad.Value > stockDisponible)
                {
                    // Si la cantidad ingresada es mayor que el stock disponible, establece la cantidad máxima al valor del stock.
                    TCantidad.Value = stockDisponible;
                }
            }
        }

        private void RecalcularPrecioTotal()
        {
            decimal precioTotal = 0;

            foreach (DataGridViewRow row in DGDetalle.Rows)
            {
                decimal subtotal = decimal.Parse(row.Cells["Csubtotal"].Value.ToString());
                precioTotal += subtotal;
            }

            TTotal.Text = precioTotal.ToString();
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TCod.Text) || string.IsNullOrWhiteSpace(TProd.Text) || string.IsNullOrWhiteSpace(TPrecio.Text) || string.IsNullOrWhiteSpace(TStock.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos para editar un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Obtén el índice de la fila seleccionada en el DataGridView
            int rowIndex = DGDetalle.CurrentCell.RowIndex;

            // Actualiza la fila en el DataGridView con la información editada
            DGDetalle.Rows[rowIndex].Cells["CCod"].Value = TCod.Text;
            DGDetalle.Rows[rowIndex].Cells["Cproducto"].Value = TProd.Text;
            DGDetalle.Rows[rowIndex].Cells["CPrecio"].Value = TPrecio.Text;
            DGDetalle.Rows[rowIndex].Cells["Ccantidad"].Value = TCantidad.Value;

            // Calcula y actualiza el subtotal
            decimal precio = decimal.Parse(TPrecio.Text);
            int cantidad = (int)TCantidad.Value;
            decimal subtotal = precio * cantidad;
            DGDetalle.Rows[rowIndex].Cells["Csubtotal"].Value = subtotal;

            // Actualiza el precio total
            RecalcularPrecioTotal();

            // Limpia los campos TextBox y restablece los botones
            TCod.Clear();
            TProd.Clear();
            TPrecio.Clear();
            TStock.Clear();
            TCantidad.Value = 1;
            BEditar.Enabled = false;
            BAgregar.Enabled = true;
            BProd.Enabled = true; // Habilito el boton de buscar prodcuto
            MessageBox.Show("Se ha editado correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CBForma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
