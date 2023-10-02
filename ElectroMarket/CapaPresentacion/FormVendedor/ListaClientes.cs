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
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {

        }

        private void datagridProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol > 0)
            {
               /*  _Proveedor = new Proveedor()
                {
                    
                }   */
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
