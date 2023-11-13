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
        SqlConnection oConexion = new SqlConnection(Conexion.cadena);

        SqlCommand cmd;
        SqlDataReader dr;

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


            VendedorConMasVentas();
            Top5Productos();
            
            GB1.Controls.Add(radioButtonCantProd);
            GB1.Controls.Add(radioButtonClientes);
            // Configurar el evento CheckedChanged para los RadioButtons
            radioButtonCantProd.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();
            radioButtonClientes.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();

            // Seleccionar uno de los RadioButtons por defecto
            radioButtonCantProd.Checked = true;


            GB2.Controls.Add(RBTop5Prod);
            GB2.Controls.Add(RBTopCategorias);
            GB2.Controls.Add(RBTopFormasPago);
            // Configurar el evento CheckedChanged para los RadioButtons
            RBTop5Prod.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();
            RBTopCategorias.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();
            RBTopFormasPago.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();

            // Seleccionar uno de los RadioButtons por defecto
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
                    chartProdPorCat.Series.Clear();
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

                        // obtengo el vendedor con mas ventas y su total vendido
                        if (cantidadActual > cantidadMaxima)
                        {
                            cantidadMaxima = cantidadActual;
                            ClienteMasCompras = productoActual;
                        }
                    }

                    chartProdPorCat.Series[0].Points.DataBindXY(clientes, cantidadesCompras);

                }
                //muestro el producto con mas ventas o mensaje de que no hay datos
                if (ClienteCantidad.Count > 0)
                {
                    lblCliente1.Text = $"Cliente con más compras: {ClienteMasCompras} ({cantidadMaxima} productos)";
                }
                else
                {
                    chartProdPorCat.Series.Clear();
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

                        // obtengo el vendedor con mas ventas y su total vendido
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
                    chartProdTop5.Series.Clear();
                    lblProductoMasVendido.Text = "No hay datos disponibles";
                }
            }
            else
            {
                MessageBox.Show("La fecha 'Desde' debe ser menor o igual que la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void categoriasMasVendidas()
        {
            ArrayList categorias = new ArrayList();
            ArrayList cantidades = new ArrayList();

            cmd = new SqlCommand("SP_CategoriasMasVentas", oConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            oConexion.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                categorias.Add(dr.GetString(0));

                // Verificar si el valor es NULL antes de intentar convertirlo
                if (!dr.IsDBNull(1))
                {
                    cantidades.Add(dr.GetInt32(1).ToString());
                }
                else
                {
                    // Si es NULL, puedes agregar un valor predeterminado o manejarlo según tu lógica
                    cantidades.Add("0");
                }
            }

            chartProdTop5.Series[0].Points.DataBindXY(categorias, cantidades);
            dr.Close();
            oConexion.Close();

            // Después de obtener los datos y mostrarlos en el gráfico, obtener la categoría más vendida y mostrarla en el Label
            MostrarCategoriaMasVendida(categorias, cantidades);
        }


        private void MostrarCategoriaMasVendida(ArrayList categorias, ArrayList cantidades)
        {
            // Verificar si hay datos en las listas
            if (categorias.Count > 0 && cantidades.Count > 0)
            {
                // Encontrar la categoría más vendida
                int indexCategoriaMasVendida = 0;
                for (int i = 1; i < cantidades.Count; i++)
                {
                    int cantidadActual = Convert.ToInt32(cantidades[i]);
                    int cantidadMaxima = Convert.ToInt32(cantidades[indexCategoriaMasVendida]);

                    if (cantidadActual > cantidadMaxima)
                    {
                        indexCategoriaMasVendida = i;
                    }
                }

                // Obtener la categoría más vendida y la cantidad
                string categoriaMasVendida = categorias[indexCategoriaMasVendida].ToString();
                int cantidadVendida = Convert.ToInt32(cantidades[indexCategoriaMasVendida]);

                // Mostrar la información en el Label
                lblProductoMasVendido.Text = $"Categoría Más Vendida: {categoriaMasVendida} ({cantidadVendida} unidades)";
            }
            else
            {
                // Si no hay datos, mostrar un mensaje en el Label
                lblProductoMasVendido.Text = "No hay datos disponibles";
            }
        }

        private void formasPagoPreferidas()
        {
            ArrayList formasPago = new ArrayList();
            ArrayList cantidades = new ArrayList();

            cmd = new SqlCommand("SP_FormasPagoMasUtilizadas", oConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            oConexion.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                formasPago.Add(dr.GetString(0));
                cantidades.Add(dr.GetInt32(1).ToString());
            }

            chartProdTop5.Series[0].Points.DataBindXY(formasPago, cantidades);
            dr.Close();
            oConexion.Close();

            // Después de obtener los datos y mostrarlos en el gráfico, obtener la forma de pago más utilizada y mostrarla en el Label
            MostrarFormaPagoMasUtilizada(formasPago, cantidades);
        }

        private void MostrarFormaPagoMasUtilizada(ArrayList formasPago, ArrayList cantidades)
        {
            // Verificar si hay datos en las listas
            if (formasPago.Count > 0 && cantidades.Count > 0)
            {
                // Encontrar la forma de pago más utilizada
                int indexFormaPagoMasUtilizada = 0;
                for (int i = 1; i < cantidades.Count; i++)
                {
                    int cantidadActual = Convert.ToInt32(cantidades[i]);
                    int cantidadMaxima = Convert.ToInt32(cantidades[indexFormaPagoMasUtilizada]);

                    if (cantidadActual > cantidadMaxima)
                    {
                        indexFormaPagoMasUtilizada = i;
                    }
                }

                // Obtener la forma de pago más utilizada y la cantidad
                string formaPagoMasUtilizada = formasPago[indexFormaPagoMasUtilizada].ToString();
                int cantidadUtilizada = Convert.ToInt32(cantidades[indexFormaPagoMasUtilizada]);

                // Mostrar la información en el Label
                lblProductoMasVendido.Text = $"Forma de Pago Más Utilizada: {formaPagoMasUtilizada} ({cantidadUtilizada} transacciones)";
            }
            else
            {
                // Si no hay datos, mostrar un mensaje en el Label
                lblProductoMasVendido.Text = "No hay datos disponibles";
            }
        }

        


        private void MostrarClienteConMasCompras(ArrayList clientes, ArrayList cantidades)
        {
            // Verificar si hay datos en las listas
            if (clientes.Count > 0 && cantidades.Count > 0)
            {
                // Encontrar el cliente con más compras
                int indexClienteMasCompras = 0;
                for (int i = 1; i < cantidades.Count; i++)
                {
                    int cantidadActual = Convert.ToInt32(cantidades[i]);
                    int cantidadMaxima = Convert.ToInt32(cantidades[indexClienteMasCompras]);

                    if (cantidadActual > cantidadMaxima)
                    {
                        indexClienteMasCompras = i;
                    }
                }

                // Obtener el nombre del cliente con más compras y la cantidad
                string clienteMasCompras = clientes[indexClienteMasCompras].ToString();
                int cantidadCompras = Convert.ToInt32(cantidades[indexClienteMasCompras]);

                // Mostrar la información en el Label
                lblCliente1.Text = $"Cliente con Más Compras: {clienteMasCompras} ({cantidadCompras} compras)";
            }
            else
            {
                // Si no hay datos, mostrar un mensaje en el Label
                lblCliente1.Text = "No hay datos disponibles";
            }
        }


        private void MostrarGraficoSeleccionado()
        {
            // Limpiar datos existentes en los Charts
            chartProdPorCat.Series[0].Points.Clear();
            chartProdTop5.Series[0].Points.Clear();

            if (radioButtonCantProd.Checked)
            {
                VendedorConMasVentas(); // Muestra el gráfico de cantidad de productos por categoría
            }
            else if (radioButtonClientes.Checked)
            {
                Top5Clientes(); // Muestra el gráfico de clientes con más compras
            }


            if (RBTop5Prod.Checked)
            {
                Top5Productos();
            }
            else if (RBTopFormasPago.Checked)
            {
                formasPagoPreferidas();
            }
            else
            {
                categoriasMasVendidas();
            }
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            //  VendedorConMasVentas();
            Top5Productos();
            //clientesMasCompras();

            // Configurar el evento CheckedChanged para los RadioButtons
            radioButtonCantProd.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();
            radioButtonClientes.CheckedChanged += (s, ev) => MostrarGraficoSeleccionado();

            // Seleccionar uno de los RadioButtons por defecto
            radioButtonCantProd.Checked = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RBTopCategorias_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            fechaDesdeGlobal = DTDesde.Value.ToString("dd-MM-yyyy");
            fechaHastaGlobal = DTHasta.Value.ToString("dd-MM-yyyy");

            VendedorConMasVentas();
            Top5Productos();
        }

        private void RBTop5Prod_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
