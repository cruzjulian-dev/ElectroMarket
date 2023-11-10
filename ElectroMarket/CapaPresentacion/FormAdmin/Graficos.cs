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

        private void chartProdPorCat_Click(object sender, EventArgs e)
        {

        }

        private void Graficos_Load(object sender, EventArgs e)
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


        ArrayList Producto = new ArrayList();
        ArrayList Cant = new ArrayList();


        private void cantProdPorCat()
        {
            // Declara e inicializa las listas dentro de la función
            ArrayList categoria = new ArrayList();
            ArrayList cantProd = new ArrayList();

            cmd = new SqlCommand("prodPorCateg", oConexion);
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
            cmd = new SqlCommand("ProdMasVendidos", oConexion);
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

        private void clientesMasCompras()
        {
            // Declara e inicializa las listas dentro de la función
            ArrayList cliente = new ArrayList();
            ArrayList cantCompras = new ArrayList();

            cmd = new SqlCommand("SP_Top3ClientesMasCompras", oConexion);
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

            if (radioButtonCantProd.Checked)
            {
                cantProdPorCat(); // Muestra el gráfico de cantidad de productos por categoría
            }
            else if (radioButtonClientes.Checked)
            {
                clientesMasCompras(); // Muestra el gráfico de clientes con más compras
            }
        }
    }
}
