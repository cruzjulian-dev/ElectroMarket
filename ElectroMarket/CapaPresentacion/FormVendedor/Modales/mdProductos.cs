using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdProductos : Form
    {
        public Producto _Producto { get; set; }

        public mdProductos()
        {
            InitializeComponent();
        }

        private void mdProductos_Load(object sender, EventArgs e)
        {

        }

        private void datagridProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            if (iRow >= 0 && iCol > 0)
            {
                /* _Producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(datagridProd.Rows[iRow].Cells["id"].Value.ToString()),
                }   */

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void icoBtnBuscar_Click(object sender, EventArgs e)
        {
          /*  string columnafiltro = ((OpcionCombo).cbobusqueda.SelectedItem).Valor.ToString();

             if(datagridProd.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in datagridProd.Rows)
                {
                    if (row.Cells[columnafiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;

                    }
                    else
                    {
                        row.Visible = false;

                    }
                }
            }  */
        }

        private void icoBtnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach(DataGridViewRow row in datagridProd.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
