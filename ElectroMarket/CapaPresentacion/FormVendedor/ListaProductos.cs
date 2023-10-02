using CapaEntidades;
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
            decimal precio = Convert.ToDecimal(filaSeleccionada.Cells["CPrecio"].Value);


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

        private void ListaProductos_Load(object sender, EventArgs e)
        {

            // CATEGORIAS
            Categoria categoria = new Categoria
            {
                IdCategoria = 1,
                Descripcion = "Heladeras",
                Estado = true,
                FechaRegistro = "02/10/2023"
            };

            Categoria categoria2 = new Categoria
            {
                IdCategoria = 1,
                Descripcion = "Aires Acondicionados",
                Estado = true,
                FechaRegistro = "02/10/2023"
            };

            Categoria categoria3 = new Categoria
            {
                IdCategoria = 1,
                Descripcion = "Televisores",
                Estado = true,
                FechaRegistro = "02/10/2023"
            };

            Categoria categoria4 = new Categoria
            {
                IdCategoria = 1,
                Descripcion = "Lavarropas",
                Estado = true,
                FechaRegistro = "02/10/2023"
            };

            // PRODUCTOS
            Producto producto1 = new Producto
            {
                Codigo = "1",
                Nombre = "Heladera Whirpool",
                Descripcion = "No Frost - Capacidad de 443 litros - Con freezer inferior",
                oCategoria = categoria,
                Stock = 321,
                Precio = 856200,
            };

            Producto producto2 = new Producto
            {
                Codigo = "2",
                Nombre = "Aire LG L50042",
                Descripcion = "Split Inverter - Capacidad de enfriamiento de 12,000 BTU",
                oCategoria = categoria2,
                Stock = 200,
                Precio = 689999,
            };

            Producto producto3 = new Producto
            {
                Codigo = "3",
                Nombre = "Smart TV Samsung SM29934",
                Descripcion = "Smart TV LED de 55 pulgadas - Resolución 4K Ultra HD",
                oCategoria = categoria3,
                Stock = 177,
                Precio = 849500,
            };

            Producto producto4 = new Producto
            {
                Codigo = "4",
                Nombre = "Lavarropas Automatico Drean",
                Descripcion = "Carga frontal - Capacidad de 8 kg - 1400 RPM",
                oCategoria = categoria4,
                Stock = 432,
                Precio = 586000, 
            };

            listaProductos.Add(producto1);
            listaProductos.Add(producto2);
            listaProductos.Add(producto3);
            listaProductos.Add(producto4);

            if (FuenteFormulario == "RegistrarVenta")
            {
                foreach (Producto prod in listaProductos)
                {
                    DGProductos.Rows.Add("", prod.Codigo, prod.Nombre, prod.Descripcion, prod.oCategoria.Descripcion, prod.Stock, prod.Precio, "Seleccionar");
                }
            }
            else if (FuenteFormulario == "VistaVendedor")
            {
                foreach (Producto prod in listaProductos)
                {

                    DGProductos.Rows.Add("", prod.Codigo, prod.Nombre, prod.Descripcion, prod.oCategoria.Descripcion, prod.Stock, prod.Precio, "Seleccionar");

                    DGProductos.Columns["CSeleccionar"].Visible = false;

                }
            }
            
        }
    }
}
