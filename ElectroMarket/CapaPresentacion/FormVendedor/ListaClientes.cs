using CapaEntidades;
using CapaNegocio;
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

namespace CapaPresentacion.Modales
{
    public partial class ListaClientes : Form
    {
        private List<Cliente> listaClientes = new List<Cliente>();
        public Cliente ClienteSeleccionado { get; private set; }
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DGClientes.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "Fecha de Nacimiento" && columna.HeaderText != "Seleccionar")
                {
                    CBBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CBBusqueda.DisplayMember = "Texto";
            CBBusqueda.ValueMember = "Valor";
            CBBusqueda.SelectedIndex = 0;



            // Mostrar todos los Clientes desde la BD
            List<Cliente> listaCliente = new CN_Cliente().Listar();

            foreach (Cliente item in listaCliente)
            {
                if (item.Estado != false) //trae los clientes activos
                {
                    DGClientes.Rows.Add(new object[] { item.IdCliente, item.Nombre, item.Apellido, item.Dni, Convert.ToDateTime(item.FechaNacimiento).ToString("dd-MM-yyyy"), item.Telefono, item.Domicilio, "Seleccionar"
                    });
                }
            }
        }

        private void DGClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGClientes.Columns[e.ColumnIndex].Name == "CSeleccionar" && e.RowIndex >= 0)
            {
                int indiceSeleccionado = e.RowIndex;
                if (indiceSeleccionado >= 0)
                {
                    Cliente cliente = ObtenerClienteSeleccionado(indiceSeleccionado);
                    ClienteSeleccionado = cliente;
                    this.Close();
                }
            }
        }

        private Cliente ObtenerClienteSeleccionado(int indiceSeleccionado)
        {
            DataGridViewRow filaSeleccionada = DGClientes.Rows[indiceSeleccionado];

            int idCliente = Convert.ToInt32(filaSeleccionada.Cells["CIdCliente"].Value);
            string nombre = filaSeleccionada.Cells["CNombre"].Value.ToString();
            string apellido = filaSeleccionada.Cells["CApellido"].Value.ToString();
            int dni = Convert.ToInt32(filaSeleccionada.Cells["CDni"].Value);
            DateTime fechaNacimiento = Convert.ToDateTime(filaSeleccionada.Cells["CFechaNacim"].Value);
            string telefono = filaSeleccionada.Cells["CTelefono"].Value.ToString();
            string domicilio = filaSeleccionada.Cells["CDomicilio"].Value.ToString();
            bool estado = true;
            string fechaRegistro = "17/02/1998";


            Cliente cliente = new Cliente
            {
                IdCliente = idCliente,
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                FechaNacimiento = fechaNacimiento,
                Telefono = telefono,
                Domicilio = domicilio,
                Estado = estado,
                FechaRegistro = fechaRegistro
            };

            return cliente;
        }

        private void icoBtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CBBusqueda.SelectedItem).Valor.ToString();

            if (DGClientes.Rows.Count > 0)  // pregunta si hay filas
            {
                foreach (DataGridViewRow row in DGClientes.Rows) // recorro cada fila del datagrid
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TBusqueda.Text.Trim().ToUpper())) //obtengo el valor de la fila que estoy recorriendo
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }

                }
            }
        }

        private void icoBtnLimpiar_Click(object sender, EventArgs e)
        {
            TBusqueda.Text = "";
            VaciarTabla();
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {

            // Mostrar todos los Clientes desde la BD
            List<Cliente> listaCliente = new CN_Cliente().Listar();

            foreach (Cliente item in listaCliente)
            {
                if (item.Estado != false) //trae los clientes activos
                {
                    DGClientes.Rows.Add(new object[] { item.IdCliente, item.Nombre, item.Apellido, item.Dni, Convert.ToDateTime(item.FechaNacimiento).ToString("dd-MM-yyyy"), item.Telefono, item.Domicilio, "Seleccionar"
                    });
                }
            }

        }

        private void VaciarTabla()
        {
            DGClientes.Rows.Clear();
        }
    }
}
