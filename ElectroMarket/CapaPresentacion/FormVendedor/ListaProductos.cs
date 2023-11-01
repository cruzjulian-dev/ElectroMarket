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
            if (DGProductos.Columns[e.ColumnIndex].Name == "CSeleccionar" && e.RowIndex >= 0)
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
                if (item.Stock > 0)
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
                    "Seleccionar",
                    item.IdProducto
                });
                }
                
            }

            if (FuenteFormulario == "VistaVendedor")
            {
                DGProductos.Columns["CSeleccionar"].Visible = false;
            }

        }

        private void icoBtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
