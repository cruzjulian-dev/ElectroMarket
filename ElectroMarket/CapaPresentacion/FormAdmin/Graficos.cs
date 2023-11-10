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

namespace CapaPresentacion.FormAdmin
{
    public partial class Graficos : Form
    {
        SqlConnection oConexion = new SqlConnection(Conexion.cadena);

        SqlCommand cmd;
        SqlDataReader dr;

        public Graficos()
        {
            InitializeComponent();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {
            //  cantProdPorCat();
            // prodTop5ven();
            //clientesMasCompras();
            //categoriasMasVendidas();
            formasPagoPreferidas();

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


        private void cantProdPorCat()
        {
            // Declara e inicializa las listas dentro de la función
            ArrayList categoria = new ArrayList();
            ArrayList cantProd = new ArrayList();

            cmd = new SqlCommand("SP_ProdPorCateg", oConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            oConexion.Open();
            dr = cmd.ExecuteReader();

            string categoriaConMasProductos = "";
            int cantidadMaxima = 0;

            while (dr.Read())
            {
                string categoriaActual = dr.GetString(0);
                int cantidadActual = dr.GetInt32(1);

                // Agregar datos al gráfico
                categoria.Add(categoriaActual);
                cantProd.Add(cantidadActual.ToString());

                // Verificar si la cantidad actual es mayor que la máxima
                if (cantidadActual > cantidadMaxima)
                {
                    cantidadMaxima = cantidadActual;
                    categoriaConMasProductos = categoriaActual;
                }
            }

            chartProdPorCat.Series[0].Points.DataBindXY(categoria, cantProd);
            dr.Close();
            oConexion.Close();

            // Mostrar la categoría con más productos en el Label
            MostrarCategoriaConMasProductos(categoriaConMasProductos, cantidadMaxima);
        }

        private void MostrarCategoriaConMasProductos(string categoriaConMasProductos, int cantidadMaxima)
        {
            if (!string.IsNullOrEmpty(categoriaConMasProductos))
            {
                lblCliente1.Text = $"Categoría con Más Productos: {categoriaConMasProductos} ({cantidadMaxima} productos)";
            }
            else
            {
                lblCliente1.Text = "No hay datos disponibles";
            }
        }

        private void prodTop5ven()
        {
            ArrayList Producto = new ArrayList();
            ArrayList Cant = new ArrayList();
            cmd = new SqlCommand("SP_ProdMasVendidos", oConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            oConexion.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Producto.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1).ToString());
            }

            chartProdTop5.Series[0].Points.DataBindXY(Producto, Cant);
            dr.Close();
            oConexion.Close();

            // Después de obtener los datos y mostrarlos en el gráfico, obten el producto más vendido y muéstralo en el Label
            if (Producto.Count > 0)
            {
                string productoMasVendido = Producto[0].ToString(); // El producto más vendido está en la primera posición
                lblProductoMasVendido.Text = "Producto más vendido: " + productoMasVendido;
            }
            else
            {
                lblProductoMasVendido.Text = "No hay datos disponibles";
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

        private void clientesMasCompras()
        {
            // Declara e inicializa las listas dentro de la función
            ArrayList cliente = new ArrayList();
            ArrayList cantCompras = new ArrayList();

            cmd = new SqlCommand("SP_Top5ClientesMasCompras", oConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            oConexion.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cliente.Add(dr.GetString(0));
                cantCompras.Add(dr.GetInt32(1).ToString());
            }

            chartProdPorCat.Series[0].Points.DataBindXY(cliente, cantCompras);
            dr.Close();
            oConexion.Close();

            // Después de obtener los datos y mostrarlos en el gráfico, obtener el cliente con más compras y mostrarlo en el Label
            MostrarClienteConMasCompras(cliente, cantCompras);
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
                cantProdPorCat(); // Muestra el gráfico de cantidad de productos por categoría
            }
            else if (radioButtonClientes.Checked)
            {
                clientesMasCompras(); // Muestra el gráfico de clientes con más compras
            }


            if (RBTop5Prod.Checked)
            {
                prodTop5ven();
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
            //  cantProdPorCat();
            prodTop5ven();
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
    }
}
