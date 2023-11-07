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
        private List<Producto> listaProductos = new List<Producto>();

        public RegistrarVenta()
        {
            InitializeComponent();
            listaProductos = new CN_Producto().ListarProductos();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            BEditar.Enabled = false;
            TCantidad.Minimum = 1;
            TCantidad.Maximum = 999999;
            TFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TTotal.Text = Convert.ToDecimal(0).ToString();
            TCambio.Text = Convert.ToDecimal(0).ToString();

            // combo box tipo de documento
            TTipoDoc.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura"});
            //TTipoDoc.Items.Add(new OpcionCombo() { Valor = "Presupuesto", Texto = "Presupuesto" });
            TTipoDoc.DisplayMember = "Texto";
            TTipoDoc.ValueMember = "Valor";
            TTipoDoc.SelectedIndex = -1;


            // combo box forma de pago
            CBForma.Items.Add(new OpcionCombo() { Valor = "1", Texto = "Efectivo" });
            CBForma.Items.Add(new OpcionCombo() { Valor = "2", Texto = "Tarjeta" });
            CBForma.Items.Add(new OpcionCombo() { Valor = "3", Texto = "Mercado Pago" });
            CBForma.DisplayMember = "Texto";
            CBForma.ValueMember = "Valor";
            CBForma.SelectedIndex = -1;
        }

        private void icoBtnBuscar_Click(object sender, EventArgs e)
        {
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.ShowDialog();

            if (listaClientes.ClienteSeleccionado != null)
            {
                Cliente ClienteSeleccionado = listaClientes.ClienteSeleccionado;
                TNombre.Text = ClienteSeleccionado.Nombre;
                TApe.Text = ClienteSeleccionado.Apellido;
                TDni.Text = ClienteSeleccionado.Dni.ToString();
                TNomApe.Text = ClienteSeleccionado.Nombre + " " + ClienteSeleccionado.Apellido;
            }
        }

        private Producto ObtenerProductoPorCodigo(string codigo)
        {
            Producto productoEncontrado = listaProductos.FirstOrDefault(producto => producto.Codigo == codigo);
            return productoEncontrado;
        }

        private void btnBuscarProduc_Click(object sender, EventArgs e)
        {
            ListaProductos listaProd = new ListaProductos();
            listaProd.FuenteFormulario = "RegistrarVenta";
            listaProd.ShowDialog();

            TCantidad.Value = 1;

            if (listaProd.ProductoSeleccionado != null)
            {
                Producto productoSeleccionado = listaProd.ProductoSeleccionado;
                TIdProd.Text = productoSeleccionado.IdProducto.ToString();
                TCod.Text = productoSeleccionado.Codigo.ToString();
                TProd.Text = productoSeleccionado.Nombre.ToString();
                TDescripcion.Text = productoSeleccionado.Descripcion.ToString();
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
                        MessageBox.Show("El producto ya fue agregado anteriormente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (MessageBox.Show("Seguro que quieres agregar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(TIdProd.Text);
                            string nombre = TProd.Text;
                            string descripcion = TDescripcion.Text;
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
                            DGDetalle.Rows.Add(id, codigo, nombre, precio.ToString(), cantidad.ToString(), subtotal.ToString(), "Eliminar", "Editar", descripcion);

                            // Limpia los TextBox y el NumericUpDown después de agregar los datos al DataGridView
                            TIdProd.Clear();
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
                if (TFecha.Text == "" || TDni.Text == "" || TNomApe.Text == "" || TTotal.Text == "" || TPagaCon.Text == "" || TCambio.Text == "" || CBForma.SelectedIndex == -1 || TTipoDoc.SelectedIndex == -1)
                {
                    MessageBox.Show("Debes completar todos los campos antes de realizar una venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    decimal pago = Convert.ToDecimal(TPagaCon.Text);
                    decimal total = Convert.ToDecimal(TTotal.Text);
                    if (pago < total)
                    {
                        MessageBox.Show("El Monto pagado es menor que el Precio Total!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (MessageBox.Show("Seguro que quieres realizar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            List<DetalleVenta> listaDetalle = new List<DetalleVenta>();

                            DataTable detalle_venta = new DataTable();

                            detalle_venta.Columns.Add("IdProducto", typeof(int));
                            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
                            detalle_venta.Columns.Add("Cantidad", typeof(int));
                            detalle_venta.Columns.Add("SubTotal", typeof(decimal));

  
                            foreach (DataGridViewRow row in DGDetalle.Rows)
                            {
                                DetalleVenta detalle = new DetalleVenta();
                                detalle.oProducto = new Producto() {IdProducto = Convert.ToInt32(row.Cells["idProducto"].Value.ToString()), Nombre = row.Cells["Cproducto"].Value.ToString(), Descripcion = row.Cells["CDescripcion"].Value.ToString()  } ;
                                detalle.PrecioVenta = Convert.ToDecimal(row.Cells["CPrecio"].Value.ToString());
                                detalle.Cantidad = Convert.ToInt32(row.Cells["Ccantidad"].Value.ToString());
                                detalle.SubTotal = Convert.ToDecimal(row.Cells["Csubtotal"].Value.ToString());

                                listaDetalle.Add(detalle);

                                detalle_venta.Rows.Add(
                                    new object[]
                                    {
                                        Convert.ToInt32(row.Cells["idProducto"].Value.ToString()),
                                        Convert.ToDecimal(row.Cells["CPrecio"].Value.ToString()),
                                        Convert.ToInt32(row.Cells["Ccantidad"].Value.ToString()),
                                        Convert.ToDecimal(row.Cells["Csubtotal"].Value.ToString())
                                    }
                                );
                            }


                            int siguienteId = new CN_Venta().ObtenerSiguienteId();
                            string numeroDocumento = string.Format("{0:00000}", siguienteId);



                            Venta oVenta = new Venta()
                            {
                                oUsuario = new Usuario() { IdUsuario = VistaVendedor.usuarioActual.IdUsuario },
                                DniCliente = Convert.ToInt32(TDni.Text),
                                NombreCliente = TNombre.Text.ToString(),
                                ApellidoCliente = TApe.Text.ToString(),
                                oFormaPago = new FormaPago() { IdFormaPago = Convert.ToInt32(((OpcionCombo)CBForma.SelectedItem).Valor)},
                                TipoDocumento = ((OpcionCombo)TTipoDoc.SelectedItem).Texto,
                                NumeroDocumento = numeroDocumento,
                                MontoPago = Convert.ToDecimal(TPagaCon.Text),
                                MontoCambio = Convert.ToDecimal(TCambio.Text),
                                MontoTotal = Convert.ToDecimal(TTotal.Text)
                            };

                            string mensaje = string.Empty;
                            bool respuesta = new CN_Venta().RegistrarVenta(oVenta, detalle_venta, out mensaje);

                            if (respuesta)
                            {
                                FormDetalleVenta detalle = new FormDetalleVenta(siguienteId);
                                detalle.Show();
                                
                            } else
                            {
                                MessageBox.Show(mensaje);
                            }

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
            TNombre.Text = "";
            TApe.Text = "";
            TNomApe.Text = "";
            TIdProd.Text = "";
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
            // Verifica si la tecla presionada no es un número, una coma decimal o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Evita múltiples puntos decimales o comas
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Evita que se empiece con una coma o un punto
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (sender as TextBox).Text.Length == 0)
            {
                e.Handled = true;
            }

            // Evita que se ingresen comas o puntos después de un espacio en blanco
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (sender as TextBox).Text.EndsWith(" "))
            {
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
                        BAgregar.Enabled = true;
                        BEditar.Enabled = false;
                        BProd.Enabled = true;

                        // Obtén los valores de las celdas de la fila seleccionada
                        DataGridViewRow selectedRow = DGDetalle.Rows[e.RowIndex];

                        // Actualizar precio total
                        decimal precioProducto = Convert.ToDecimal(selectedRow.Cells["CPrecio"].Value);
                        decimal precioTotalActual = Convert.ToDecimal(TTotal.Text);
                        TTotal.Text = (precioTotalActual - precioProducto).ToString();

                        // Eliminar fila seleccionada
                        DGDetalle.Rows.Remove(selectedRow);

                        // limpia campos referidos al producto
                        TCod.Text = "";
                        TProd.Text = "";
                        TDescripcion.Text = "";
                        TPrecio.Text = "";
                        TStock.Text = "";
                        TCantidad.Value = 1;
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
                            TDescripcion.Text = productoSeleccionado.Descripcion;
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
            DGDetalle.Rows[rowIndex].Cells["CDescripcion"].Value = TDescripcion.Text;
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
            TDescripcion.Clear();
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
