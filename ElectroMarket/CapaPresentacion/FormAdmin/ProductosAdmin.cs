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
using System.Runtime.InteropServices;
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
            CBCategoria.SelectedIndex = -1;

            // combobox estado
            CBEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = -1;

            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                CBCategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }

            CBCategoria.DisplayMember = "Texto";
            CBCategoria.ValueMember = "Valor";
            CBCategoria.SelectedIndex = -1;

            foreach (DataGridViewColumn columna in DGProductos.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "Fecha de Nacimiento" && columna.HeaderText != "Contraseña" && columna.HeaderText != "Estado" && columna.HeaderText != "Editar")
                {
                    CBBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CBBusqueda.DisplayMember = "Texto";
            CBBusqueda.ValueMember = "Valor";
            CBBusqueda.SelectedIndex = 0;


            // Mostrar todos los Usuarios desde la BD
            List<Producto> lista = new CN_Producto().Listar();

            foreach (Producto item in lista)
            {

                DGProductos.Rows.Add(new object[] { 
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.Precio,
                    item.Stock,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Estado == true ? "Activo" : "No Activo",
                    item.Estado == true ? 1 : 0,
                    "Editar",
                    item.IdProducto
            });

            }

          


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
            if (TIndice.Text.Trim() == "" || TCodigo.Text.Trim() == "" || TNombre.Text.Trim() == "" || TDescripcion.Text.Trim() == "" || TPrecio.Text.Trim() == "" || TStock.Text.Trim() == "" || CBEstado.SelectedIndex == -1 || CBCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que quieres guardar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Producto objProducto = new Producto()
                    {
                        Codigo = TCodigo.Text.Trim(),
                        Nombre = TNombre.Text.Trim(),
                        Descripcion = TDescripcion.Text.Trim(),
                        Precio = Convert.ToDecimal(TPrecio.Text.Trim()),
                        Stock = Convert.ToInt32(TStock.Text.Trim()),
                        oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)CBCategoria.SelectedItem).Valor) },
                        Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).Valor) == 1 ? true : false
                    };

                    int idProductoGenerado = new CN_Producto().RegistrarProducto(objProducto, out mensaje);

                    if (idProductoGenerado != 0)
                    {
                        DGProductos.Rows.Add(new object[] { TCodigo.Text.Trim(), TNombre.Text.Trim(), TDescripcion.Text.Trim(), TPrecio.Text.Trim(), TStock.Text.Trim(),
                                ((OpcionCombo)CBCategoria.SelectedItem).Valor.ToString(), ((OpcionCombo)CBCategoria.SelectedItem).Texto.ToString(),
                                ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString(), ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString(),
                                "Editar", idProductoGenerado
                                });



                        LimpiarCampos();
                        VaciarTabla();
                        ActualizarTabla();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        void LimpiarCampos()
        {
            TCodigo.Clear();
            TNombre.Clear();
            TDescripcion.Clear();
            TStock.Clear();
            TPrecio.Clear();
            CBCategoria.SelectedIndex = -1;
            CBEstado.SelectedIndex = -1;
        }

        private void ActualizarTabla()
        {
            // Actualizar la tabla con todos los Usuarios desde la BD
            List<Producto> listaProducto = new CN_Producto().Listar();

            foreach (Producto item in listaProducto)
            {

                DGProductos.Rows.Add(new object[] { item.Codigo, item.Nombre, item.Descripcion, item.Precio, item.Stock,
                item.oCategoria.IdCategoria, item.oCategoria.Descripcion, item.Estado == true ? "Activo" : "No Activo", item.Estado == true ? 1 : 0, "Editar", item.IdProducto
            });

            }
        }

        private void VaciarTabla()
        {
            DGProductos.Rows.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TCodigo.Text.Trim() == "" || TNombre.Text.Trim() == "" || TDescripcion.Text.Trim() == "" || TStock.Text.Trim() == "" || TPrecio.Text.Trim() == "" || CBEstado.SelectedIndex == -1 || CBCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Deseas guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Producto objProducto = new Producto()
                    {
                        Codigo = TCodigo.Text.Trim(),
                        Nombre = TNombre.Text.Trim(),
                        Descripcion = TDescripcion.Text.Trim(),
                        Precio = Convert.ToDecimal(TPrecio.Text.Trim()),
                        Stock = Convert.ToInt32(TStock.Text.Trim()),
                        oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)CBCategoria.SelectedItem).Valor) },
                        Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).Valor) == 1 ? true : false,
                        IdProducto = Convert.ToInt32(TId.Text.Trim())
                    };

                    bool resultado = new CN_Producto().EditarProducto(objProducto, out mensaje);

                    if (resultado == true)
                    {
                        DataGridViewRow row = DGProductos.Rows[Convert.ToInt32(TIndice.Text)];

                        row.Cells["Ccodigo"].Value = TCodigo.Text.Trim();
                        row.Cells["Cnombre"].Value = TNombre.Text.Trim();
                        row.Cells["CStock"].Value = Convert.ToInt32(TStock.Text.Trim());
                        row.Cells["Cdescripcion"].Value = TDescripcion.Text.Trim();
                        row.Cells["Cprecio"].Value = Convert.ToDecimal(TPrecio.Text.Trim());
                        row.Cells["idCat"].Value = ((OpcionCombo)CBCategoria.SelectedItem).Valor.ToString();
                        row.Cells["Ccategoria"].Value = ((OpcionCombo)CBCategoria.SelectedItem).Texto.ToString();
                        row.Cells["Cestado"].Value = ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString();
                        row.Cells["CestadoVAlor"].Value = ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString();
                        row.Cells["Ceditar"].Value = "Editar";
                        row.Cells["CIdProducto"].Value = Convert.ToInt32(TId.Text.Trim());

                        LimpiarCampos();
                        VaciarTabla();
                        ActualizarTabla();

                        BEditar.Enabled = false;
                        BGuardar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            
            }
           
        }

        private void textBoxCodprod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número, un punto decimal o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
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
                    TIndice.Text = e.RowIndex.ToString();
                    TId.Text = DGProductos.Rows[Convert.ToInt32(TIndice.Text)].Cells["CIdProducto"].Value.ToString(); 

                    // Habilita el botón "Editar"
                    BEditar.Enabled = true;

                    // Deshabilita el botón "Guardar"
                    BGuardar.Enabled = false;

                    if (Convert.ToInt32(TIndice.Text) >= 0)
                    {
                        TCodigo.Text = DGProductos.Rows[Convert.ToInt32(TIndice.Text)].Cells["Ccodigo"].Value.ToString();
                        TNombre.Text = DGProductos.Rows[Convert.ToInt32(TIndice.Text)].Cells["Cnombre"].Value.ToString();
                        TDescripcion.Text = DGProductos.Rows[Convert.ToInt32(TIndice.Text)].Cells["Cdescripcion"].Value.ToString();
                        TPrecio.Text = DGProductos.Rows[Convert.ToInt32(TIndice.Text)].Cells["cprecio"].Value.ToString();
                        TStock.Text = DGProductos.Rows[Convert.ToInt32(TIndice.Text)].Cells["CStock"].Value.ToString();

                        foreach (OpcionCombo oc in CBCategoria.Items)
                        {
                            if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGProductos.Rows[Convert.ToInt32(TIndice.Text)].Cells["idCat"].Value))
                            {
                                int indice_combo = CBCategoria.Items.IndexOf(oc);
                                CBCategoria.SelectedIndex = indice_combo;
                                break;
                            }
                        }

                        foreach (OpcionCombo oc in CBEstado.Items)
                        {
                            if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGProductos.Rows[Convert.ToInt32(TIndice.Text)].Cells["CestadoVAlor"].Value))
                            {
                                int indice_combo = CBEstado.Items.IndexOf(oc);
                                CBEstado.SelectedIndex = indice_combo;
                                break;
                            }
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

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BGuardar.Enabled = true;
            BEditar.Enabled = false;
        }
    }
}
