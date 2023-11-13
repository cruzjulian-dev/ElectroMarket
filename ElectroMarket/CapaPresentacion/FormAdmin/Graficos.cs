using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaDatos;
using System.Collections;
using CapaEntidades;
using CapaNegocio;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.FormAdmin
{
    public partial class Graficos : Form
    {
        string fechaDesdeGlobal;
        string fechaHastaGlobal;

        public Graficos()
        {
            InitializeComponent();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {
            DTDesde.Value = DateTime.Now.AddDays(-31);

            fechaDesdeGlobal = DateTime.Now.AddDays(-31).ToString("dd-MM-yyyy");

            fechaHastaGlobal = DTHasta.Value.ToString("dd-MM-yyyy");

            // cargar graficos default
            VendedorConMasVentas();
            Top5Productos();
            

            GB1.Controls.Add(RBTopVendedores);
            GB1.Controls.Add(RBTop5Clientes);

            // asocio el método MostrarGraficoSeleccionado() al evento CheckedChanged
            RBTopVendedores.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();
            RBTop5Clientes.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();
            RBTopVendedores.Checked = true;



            GB2.Controls.Add(RBTop5Prod);
            GB2.Controls.Add(RBTopCategorias);
            GB2.Controls.Add(RBTopFormasPago);

            // asocio el método MostrarGraficoSeleccionado() al evento CheckedChanged
            RBTop5Prod.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();
            RBTopCategorias.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();
            RBTopFormasPago.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();
            RBTop5Prod.Checked = true;
        }


        private void VendedorConMasVentas()
        {
            string fechaDesde = fechaDesdeGlobal;
            string fechaHasta = fechaHastaGlobal;

            if (Convert.ToDateTime(fechaDesde) <= Convert.ToDateTime(fechaHasta))
            {
                CN_Graficos cnGraficos = new CN_Graficos();

                ArrayList VendedoresVentas = cnGraficos.VendedorConMasVentas(fechaDesde, fechaHasta);

                string VendedorMasVentas = "";
                int cantidadMaxima = 0;

                // Pregunto si hay ventas
                if (VendedoresVentas != null && VendedoresVentas.Count > 0)
                {
                    List<string> vendedores = new List<string>();
                    List<string> cantidadesVentas = new List<string>();

                    foreach (object[] datos in VendedoresVentas)
                    {
                        string vendedorActual = (string)datos[0];
                        int cantidadActual = (int)datos[1];


                        vendedores.Add(vendedorActual);
                        cantidadesVentas.Add(cantidadActual.ToString());

                        // obtengo el vendedor con mas ventas y su total vendido
                        if (cantidadActual > cantidadMaxima)
                        {
                            cantidadMaxima = cantidadActual;
                            VendedorMasVentas = vendedorActual;
                        }
                    }

                    chartProdPorCat.Series[0].Points.DataBindXY(vendedores, cantidadesVentas);

                }
                //muestro el vendedor con mas ventas o mensaje que no hay datos
                if (!string.IsNullOrEmpty(VendedorMasVentas))
                {
                    lblCliente1.Text = $"Vendedor con más ventas: {VendedorMasVentas} ({cantidadMaxima} productos)";
                }
                else
                {
                    lblCliente1.Text = "No hay datos disponibles";
                }
            }
            else
            {
                MessageBox.Show("La fecha 'Desde' debe ser menor o igual que la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Top5Clientes()
        {

            string fechaDesde = fechaDesdeGlobal;
            string fechaHasta = fechaHastaGlobal;

            if (Convert.ToDateTime(fechaDesde) <= Convert.ToDateTime(fechaHasta))
            {
                CN_Graficos cnGraficos = new CN_Graficos();

                ArrayList ClienteCantidad = cnGraficos.Top5Clientes(fechaDesde, fechaHasta);

                string ClienteMasCompras = "";
                int cantidadMaxima = 0;

                // Pregunto si hay ventas
                if (ClienteCantidad != null && ClienteCantidad.Count > 0)
                {
                    List<string> clientes = new List<string>();
                    List<string> cantidadesCompras = new List<string>();

                    foreach (object[] datos in ClienteCantidad)
                    {
                        string productoActual = (string)datos[0];
                        int cantidadActual = (int)datos[1];


                        clientes.Add(productoActual);
                        cantidadesCompras.Add(cantidadActual.ToString());

                        // obtengo el cliente con mas compras y su total comprado
                        if (cantidadActual > cantidadMaxima)
                        {
                            cantidadMaxima = cantidadActual;
                            ClienteMasCompras = productoActual;
                        }
                    }

                    chartProdPorCat.Series[0].Points.DataBindXY(clientes, cantidadesCompras);

                }
                //muestro el cliente con mas compras o mensaje de que no hay datos
                if (ClienteCantidad.Count > 0)
                {
                    lblCliente1.Text = $"Cliente con más compras: {ClienteMasCompras} ({cantidadMaxima} productos)";
                }
                else
                {
                    lblCliente1.Text = "No hay datos disponibles";
                }
            }
            else
            {
                MessageBox.Show("La fecha 'Desde' debe ser menor o igual que la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Top5Productos()
        {
            string fechaDesde = fechaDesdeGlobal;
            string fechaHasta = fechaHastaGlobal;

            if (Convert.ToDateTime(fechaDesde) <= Convert.ToDateTime(fechaHasta))
            {
                CN_Graficos cnGraficos = new CN_Graficos();

                ArrayList ProductosCantidad = cnGraficos.Top5Productos(fechaDesde, fechaHasta);

                string ProductoMasVendido = "";
                int cantidadMaxima = 0;

                // Pregunto si hay ventas
                if (ProductosCantidad != null && ProductosCantidad.Count > 0)
                {
                    List<string> productos = new List<string>();
                    List<string> cantidadesVentas = new List<string>();

                    foreach (object[] datos in ProductosCantidad)
                    {
                        string productoActual = (string)datos[0];
                        int cantidadActual = (int)datos[1];


                        productos.Add(productoActual);
                        cantidadesVentas.Add(cantidadActual.ToString());

                        // obtengo el producto con mas ventas y su total vendido
                        if (cantidadActual > cantidadMaxima)
                        {
                            cantidadMaxima = cantidadActual;
                            ProductoMasVendido = productoActual;
                        }
                    }

                    chartProdTop5.Series[0].Points.DataBindXY(productos, cantidadesVentas);

                }
                //muestro el producto con mas ventas o mensaje de que no hay datos
                if (ProductosCantidad.Count > 0)
                {
                    lblProductoMasVendido.Text = $"Producto con más ventas: {ProductoMasVendido} ({cantidadMaxima} productos)";
                }
                else
                {
                    lblProductoMasVendido.Text = "No hay datos disponibles";
                }
            }
            else
            {
                MessageBox.Show("La fecha 'Desde' debe ser menor o igual que la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormasPagoMasUtilizadas()
        {
            string fechaDesde = fechaDesdeGlobal;
            string fechaHasta = fechaHastaGlobal;

            if (Convert.ToDateTime(fechaDesde) <= Convert.ToDateTime(fechaHasta))
            {
                CN_Graficos cnGraficos = new CN_Graficos();

                ArrayList FormasCantidad = cnGraficos.FormasPagoMasUtilizadas(fechaDesde, fechaHasta);

                string FormaMasUtilizada = "";
                int cantidadMaxima = 0;

                // Pregunto si hay ventas
                if (FormasCantidad != null && FormasCantidad.Count > 0)
                {
                    List<string> formas = new List<string>();
                    List<string> cantidadesVentas = new List<string>();

                    foreach (object[] datos in FormasCantidad)
                    {
                        string formaActual = (string)datos[0];
                        int cantidadActual = (int)datos[1];


                        formas.Add(formaActual);
                        cantidadesVentas.Add(cantidadActual.ToString());

                        // obtengo la forma de pago mas utilizada y la cantidad
                        if (cantidadActual > cantidadMaxima)
                        {
                            cantidadMaxima = cantidadActual;
                            FormaMasUtilizada = formaActual;
                        }
                    }

                    chartProdTop5.Series[0].Points.DataBindXY(formas, cantidadesVentas);

                }
                //muestro la forma de pago mas utilizada o mensaje de que no hay datos
                if (FormasCantidad.Count > 0)
                {
                    lblProductoMasVendido.Text = $"Forma de pago preferida: {FormaMasUtilizada} ({cantidadMaxima} productos)";
                }
                else
                {
                    lblProductoMasVendido.Text = "No hay datos disponibles";
                }
            }
            else
            {
                MessageBox.Show("La fecha 'Desde' debe ser menor o igual que la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CategoriasMasVendidas()
        {
            string fechaDesde = fechaDesdeGlobal;
            string fechaHasta = fechaHastaGlobal;

            if (Convert.ToDateTime(fechaDesde) <= Convert.ToDateTime(fechaHasta))
            {
                CN_Graficos cnGraficos = new CN_Graficos();

                ArrayList CategoriaCantidad = cnGraficos.CategoriasMasVendidas(fechaDesde, fechaHasta);

                string CategoriaMasVendida = "";
                int cantidadMaxima = 0;

                // Pregunto si hay ventas
                if (CategoriaCantidad != null && CategoriaCantidad.Count > 0)
                {
                    List<string> categorias = new List<string>();
                    List<string> cantidadesVentas = new List<string>();

                    foreach (object[] datos in CategoriaCantidad)
                    {
                        string categoriaActual = (string)datos[0];
                        int cantidadActual = (int)datos[1];


                        categorias.Add(categoriaActual);
                        cantidadesVentas.Add(cantidadActual.ToString());

                        // obtengo la categoria mas vendida
                        if (cantidadActual > cantidadMaxima)
                        {
                            cantidadMaxima = cantidadActual;
                            CategoriaMasVendida = categoriaActual;
                        }
                    }

                    chartProdTop5.Series[0].Points.DataBindXY(categorias, cantidadesVentas);

                }
                //muestro la categoria mas vendida
                if (CategoriaCantidad.Count > 0)
                {
                    lblProductoMasVendido.Text = $"Categoria con más ventas: {CategoriaMasVendida} ({cantidadMaxima} productos)";
                }
                else
                {
                    lblProductoMasVendido.Text = "No hay datos disponibles";
                }
            }
            else
            {
                MessageBox.Show("La fecha 'Desde' debe ser menor o igual que la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarGraficoSeleccionado()
        {
            // Limpiar datos existentes en los Charts
            chartProdPorCat.Series[0].Points.Clear();
            chartProdTop5.Series[0].Points.Clear();

            if (RBTopVendedores.Checked)
            {
                VendedorConMasVentas(); 
            }
            else if (RBTop5Clientes.Checked)
            {
                Top5Clientes(); 
            }

            if (RBTop5Prod.Checked)
            {
                Top5Productos();
            }
            else if (RBTopFormasPago.Checked)
            {
                FormasPagoMasUtilizadas();
            }
            else
            {
                CategoriasMasVendidas();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string fechaDesde = DTDesde.Value.ToString("dd-MM-yyyy");
            string fechaHasta = DTHasta.Value.ToString("dd-MM-yyyy");

            if (Convert.ToDateTime(fechaDesde) <= Convert.ToDateTime(fechaHasta))
            {
                fechaDesdeGlobal = DTDesde.Value.ToString("dd-MM-yyyy");
                fechaHastaGlobal = DTHasta.Value.ToString("dd-MM-yyyy");

                MostrarGraficoSeleccionado();
            }
            else
            {
                MessageBox.Show("La fecha 'Desde' debe ser menor o igual que la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
