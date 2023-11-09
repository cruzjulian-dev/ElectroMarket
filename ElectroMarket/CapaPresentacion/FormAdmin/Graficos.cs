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
        }
        ArrayList categoria = new ArrayList();
        ArrayList cantProd = new ArrayList();


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

    }
}
