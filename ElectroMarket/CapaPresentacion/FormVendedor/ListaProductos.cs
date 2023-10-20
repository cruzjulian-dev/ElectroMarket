using CapaEntidades;
using CapaNegocio;
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

            string codigo = filaSeleccionada.Cells["ccodigo"].Value.ToString();
            string nombre = filaSeleccionada.Cells["cnombre"].Value.ToString();
            int stock = Convert.ToInt32(filaSeleccionada.Cells["cstock"].Value);
            string categoriaDescripcion = filaSeleccionada.Cells["ccategoria"].Value.ToString();
            string descripcion = filaSeleccionada.Cells["CDescripcion"].Value.ToString();

            object valorCelda = filaSeleccionada.Cells["CPrecio"].Value;
            if (valorCelda != null && decimal.TryParse(valorCelda.ToString(), out decimal precio))
            {
                Categoria categoria = new Categoria
                {
                    IdCategoria = 1,
                    Descripcion = categoriaDescripcion,
                    Estado = true,
                    FechaRegistro = "02/10/2023"
                };


                Producto producto = new Producto
                {
                    Codigo = codigo,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    oCategoria = categoria,
                    Stock = stock,
                    Precio = precio
                };

                return producto;
            }
            else
            {
                // El valor en la celda no es un número decimal válido.
                MessageBox.Show("El valor en precio no es un decimal válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {

            // Mostrar todos los Productos desde la BD
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
        }

        private void icoBtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
