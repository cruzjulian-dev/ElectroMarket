using CapaEntidades;
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
    public partial class MisVentas : Form
    {
        private List<Venta> ventasFicticias = new List<Venta>();
        public MisVentas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MisVentas_Load(object sender, EventArgs e)
        {
            decimal total = 0.0m;
            int totalVentas = 0;
            string nombre = VistaVendedor.usuarioActual.Nombre;
            string apellido = VistaVendedor.usuarioActual.Apellido;

            // CATEGORIAS DE EJEMPLO
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

            // PRODUCTOS DE EJEMPLO
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



            for (int i = 1; i <= 5; i++)
            {
                Venta venta = new Venta
                {
                    IdVenta = i,
                    oUsuario = new Usuario { Nombre = nombre, Apellido = apellido },
                    DniCliente = 23765432 + i,
                    NombreCliente = "Cliente " + i,
                    ApellidoCliente = "Apellido " + i,
                    MontoPago = 0,
                    MontoCambio = 0,
                    MontoTotal = 0,
                    FechaRegistro = DateTime.Now.ToString("d"),
                    Detalle_Venta = new List<DetalleVenta>()
                };

                Random random = new Random();

                // Agregar detalles de venta (3 por cada venta)
                for (int j = 1; j <= 3; j++)
                {
                    Producto producto;

                    // Asignar un producto diferente a cada detalle de venta
                    switch (j)
                    {
                        case 1:
                            producto = producto1;
                            break;
                        case 2:
                            producto = producto2;
                            break;
                        case 3:
                            producto = producto3;
                            break;
                        default:
                            producto = producto1; 
                            break;
                    }

                    // Generar una cantidad aleatoria entre 1 y 10 para cada producto
                    int cantidad = random.Next(1, 11); // Esto generará un número entre 1 y 10 (puedes ajustar el rango según tus necesidades)


                    DetalleVenta detalle = new DetalleVenta
                    {
                        IdDetalleVenta = j,
                        oProducto = producto,
                        PrecioVenta = producto.Precio,
                        Cantidad = cantidad, // Asignar la cantidad aleatoria
                        SubTotal = producto.Precio * cantidad,
                        FechaRegistro = DateTime.Now.AddDays(-i).ToShortDateString()
                    };

                    venta.Detalle_Venta.Add(detalle);
                }
                // Calcular los montos totales, de pago y cambio basados en los detalles de venta
                decimal montoTotal = 0;
                decimal montoPago = 0;
                decimal montoCambio = 0;

                foreach (DetalleVenta detalle in venta.Detalle_Venta)
                {
                    montoTotal += detalle.SubTotal;
                }

                montoPago = montoTotal + 3800; // Supongamos que el pago es el monto total más 100 (esto puede variar según tus necesidades)
                montoCambio = montoPago - montoTotal;

                // Asignar los montos calculados a la venta
                venta.MontoTotal = montoTotal;
                venta.MontoPago = montoPago;
                venta.MontoCambio = montoCambio;

                ventasFicticias.Add(venta);
            }

            foreach (Venta venta in ventasFicticias)
            {
                DGMisVentas.Rows.Add(venta.IdVenta, venta.oUsuario.Nombre + " " + venta.oUsuario.Apellido, venta.DniCliente, venta.NombreCliente, venta.ApellidoCliente, venta.MontoTotal, venta.FechaRegistro, "Ver detalle");


                total += venta.MontoTotal;
                totalVentas += 1;
            }


            LTotal.Text = total.ToString();
            LVentas.Text = totalVentas.ToString();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGMisVentas.Columns[e.ColumnIndex].Name == "CDetalle")
            {
                // Verifica que el índice de fila sea válido y que se hizo clic en la columna "CDetalle"

                // Obtén la venta seleccionada en función del índice de fila
                if (e.RowIndex < ventasFicticias.Count)
                {
                    Venta ventaSeleccionada = ventasFicticias[e.RowIndex];

                    // Ahora puedes utilizar la ventaSeleccionada como desees
                    // Por ejemplo, puedes abrir un formulario de detalle y pasarle la venta
                    FormDetalleVenta detalleForm = new FormDetalleVenta(ventaSeleccionada);
                    detalleForm.ShowDialog();
                }
            }
        }
    }
}
