using CapaEntidades;
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
            // CLIENTES
            Cliente cliente1 = new Cliente
            {
                IdCliente = 1,
                Nombre = "Juan",
                Apellido = "Pérez",
                Dni = 12345678,
                FechaNacimiento = new DateTime(1990, 5, 15),
                Telefono = "555-123456",
                Domicilio = "Calle 123, Ciudad",
                Estado = true,
                FechaRegistro = DateTime.Now.ToShortDateString()
            };

            Cliente cliente2 = new Cliente
            {
                IdCliente = 2,
                Nombre = "María",
                Apellido = "González",
                Dni = 98765432,
                FechaNacimiento = new DateTime(1985, 8, 25),
                Telefono = "555-987654",
                Domicilio = "Avenida 456, Ciudad",
                Estado = true,
                FechaRegistro = DateTime.Now.ToShortDateString()
            };

            Cliente cliente3 = new Cliente
            {
                IdCliente = 3,
                Nombre = "Carlos",
                Apellido = "López",
                Dni = 45678901,
                FechaNacimiento = new DateTime(1995, 3, 10),
                Telefono = "555-456789",
                Domicilio = "Plaza 789, Ciudad",
                Estado = true,
                FechaRegistro = DateTime.Now.ToShortDateString()
            };

            Cliente cliente4 = new Cliente
            {
                IdCliente = 4,
                Nombre = "Luisa",
                Apellido = "Martínez",
                Dni = 78901234,
                FechaNacimiento = new DateTime(1980, 7, 8),
                Telefono = "555-789012",
                Domicilio = "Calle Principal, Ciudad",
                Estado = true,
                FechaRegistro = DateTime.Now.ToShortDateString()
            };

            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);
            listaClientes.Add(cliente4);


            foreach (Cliente cliente in listaClientes)
            {
                DGClientes.Rows.Add(cliente.IdCliente, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.FechaNacimiento.ToString("d"), cliente.Telefono, cliente.Domicilio, "Seleccionar");
            }
        }

        private void datagridProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
