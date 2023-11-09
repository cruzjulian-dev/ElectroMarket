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
            GrafCate();
            prodTop5ven();
        }
        ArrayList categoria = new ArrayList();
        ArrayList cantProd = new ArrayList();

        ArrayList Producto = new ArrayList();
        ArrayList Cant = new ArrayList();


        private void GrafCate()
        {
            cmd = new SqlCommand("prodPorCateg", oConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            oConexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categoria.Add(dr.GetString(0));
                cantProd.Add(dr.GetInt32(1).ToString());
            }
            chartProdPorCat.Series[0].Points.DataBindXY(categoria, cantProd);
            dr.Close();
            oConexion.Close();
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


    }
}
