using CapaEntidades;
using CapaNegocio;
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
    public partial class ListaProductos : Form
    {
        private List<Producto> listaProductos = new List<Producto>();
        public string FuenteFormulario { get; set; }
        public Producto ProductoSeleccionado { get; private set; }
        public ListaProductos()
        {
            InitializeComponent();
        }

        private void datagridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de la fila (e.RowIndex) y la columna (e.ColumnIndex) sean válidos
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < DGProductos.Columns.Count)
            {
                DataGridViewCell celda = DGProductos.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (DGProductos.Columns[e.ColumnIndex].Name == "CSeleccionar" && celda.Value != null && celda.Value.ToString() == "Seleccionar")
                {
                    int indiceSeleccionado = e.RowIndex;
                    if (indiceSeleccionado >= 0)
                    {
                        Producto producto = ObtenerProductoSeleccionado(indiceSeleccionado);
                        ProductoSeleccionado = producto;
                        this.Close();
                    }
                }
            }

        }

        private Producto ObtenerProductoSeleccionado(int indiceSeleccionado)
        {
            DataGridViewRow filaSeleccionada = DGProductos.Rows[indiceSeleccionado];

            Producto prod = new Producto()
            {
                IdProducto = Convert.ToInt32(filaSeleccionada.Cells["CId"].Value.ToString()),
                Codigo = filaSeleccionada.Cells["ccodigo"].Value.ToString(),
                Nombre = filaSeleccionada.Cells["cnombre"].Value.ToString(),
                Descripcion = filaSeleccionada.Cells["CDescripcion"].Value.ToString(),
                Precio = Convert.ToDecimal(filaSeleccionada.Cells["CPrecio"].Value),
                Stock = Convert.ToInt32(filaSeleccionada.Cells["cstock"].Value),
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(filaSeleccionada.Cells["CIdCategoria"].Value), Descripcion = filaSeleccionada.Cells["ccategoria"].Value.ToString() },
                Estado = Convert.ToBoolean(filaSeleccionada.Cells["CEstadoValor"].Value)
            };
            

            return prod;
            
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            // Mostrar todos los Productos activos desde la BD
            List<Producto> lista = new CN_Producto().ListarProductosActivos();

            foreach (Producto item in lista)
            {
                bool botonHabilitado = item.Stock >= 1;
                string botonTexto = botonHabilitado ? "Seleccionar" : "Agotado";

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
                    botonTexto,
                    item.IdProducto
                    });

            }

            if (FuenteFormulario == "VistaVendedor")
            {
                DGProductos.Columns["CSeleccionar"].Visible = false;
            } 

        }

        private void icoBtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void DGProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in DGProductos.Rows)
            {
                if (row.Cells["CSeleccionar"].Value != null && row.Cells["CSeleccionar"].Value.ToString() == "Agotado")
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
            }

        }

        private void DGProductos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }

        private void DGProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
