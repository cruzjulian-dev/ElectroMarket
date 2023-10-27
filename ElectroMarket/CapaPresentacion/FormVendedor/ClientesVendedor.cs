using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ClientesVendedor : Form
    {
        public ClientesVendedor()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            BEditar.Enabled = false;

            foreach (DataGridViewColumn columna in DGClientes.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "Fecha de Nacimiento" && columna.HeaderText != "Estado" && columna.HeaderText != "Editar")
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
                    DGClientes.Rows.Add(new object[] { item.IdCliente, item.Nombre, item.Apellido, item.Dni, item.FechaNacimiento, item.Telefono, item.Domicilio, "Editar"
                    });
                }
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || Ttel.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TDni.Text.Trim().Length != 8)
                {
                    MessageBox.Show("El DNI debe tener exactamente 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Obtener la fecha de nacimiento del DateTimePicker
                    DateTime fechaNacimiento = DTFecha.Value;

                    // Calcular la edad actual
                    int edad = DateTime.Now.Year - fechaNacimiento.Year;

                    if (edad < 18)
                    {
                        MessageBox.Show("El cliente debe ser mayor de 18 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        if (MessageBox.Show("Seguro que quieres guardar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            string mensaje = string.Empty;

                            Cliente objCliente = new Cliente()
                            {
                                Nombre = TNombre.Text.Trim(),
                                Apellido = TApellido.Text.Trim(),
                                Dni = Convert.ToInt32(TDni.Text),
                                FechaNacimiento = DTFecha.Value,
                                Domicilio = TDomicilio.Text.Trim(),
                                Telefono = Ttel.Text.Trim(),
                                Estado = true
                            };

                            int idClienteGenerado = new CN_Cliente().RegistrarCliente(objCliente, out mensaje);

                            if (idClienteGenerado != 0)
                            {
                                DGClientes.Rows.Add(new object[] { TNombre.Text, TApellido.Text, TDni.Text, DTFecha.Text, Ttel.Text, TDomicilio.Text,
                                "Editar", idClienteGenerado
                                });



                                LimpiarCampos();
                                VaciarTabla();
                                ActualizarTabla();
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

            }
           
        }

        private void DGCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGClientes.Columns[e.ColumnIndex].Name == "Ceditar" && e.RowIndex >= 0)
            {

                if (MessageBox.Show("Seguro que quieres editar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Habilita el botón "Editar"
                    BEditar.Enabled = true;
                    BGuardar.Enabled = false;

                    int indice = e.RowIndex;
                    TIdCliente.Text = DGClientes.Rows[indice].Cells["CIdCliente"].Value.ToString(); ;
                    TIndice.Text = e.RowIndex.ToString();


                    // Obtengo los valores de las celdas de la fila seleccionada
                    DataGridViewRow selectedRow = DGClientes.Rows[e.RowIndex];

                    TNombre.Text = selectedRow.Cells["CNombre"].Value.ToString();
                    TApellido.Text = selectedRow.Cells["CApellido"].Value.ToString();
                    TDni.Text = selectedRow.Cells["Cdni"].Value.ToString();
                    DTFecha.Text = selectedRow.Cells["CFechaNacim"].Value.ToString();
                    Ttel.Text = selectedRow.Cells["CTelefono"].Value.ToString();
                    TDomicilio.Text = selectedRow.Cells["CDomicilio"].Value.ToString();
                }
            }


        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            string domicilio = TDomicilio.Text;
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;
            string telefono = Ttel.Text;
            string dni = TDni.Text;

            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || Ttel.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TDni.Text.Trim().Length != 8)
                {
                    MessageBox.Show("El DNI debe tener 8 exactamente 8 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    // Obtener la fecha de nacimiento del DateTimePicker
                    DateTime fechaNacimiento = DTFecha.Value;

                    // Calcular la edad actual
                    int edad = DateTime.Now.Year - fechaNacimiento.Year;

                    if (edad < 18)
                    {
                        MessageBox.Show("El cliente debe ser mayor de 18 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        if (MessageBox.Show("Deseas guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string mensaje = string.Empty;

                            Cliente objCliente = new Cliente()
                            {
                                IdCliente = Convert.ToInt32(TIdCliente.Text),
                                Nombre = TNombre.Text.Trim(),
                                Apellido = TApellido.Text.Trim(),
                                Dni = Convert.ToInt32(TDni.Text),
                                FechaNacimiento = DTFecha.Value,
                                Domicilio = TDomicilio.Text.Trim(),
                                Telefono = Ttel.Text.Trim(),
                                Estado = true
                            };

                            bool resultado = new CN_Cliente().EditarCliente(objCliente, out mensaje);

                            if (resultado == true)
                            {
                                DataGridViewRow row = DGClientes.Rows[Convert.ToInt32(TIndice.Text)];

                                row.Cells["CNombre"].Value = TNombre.Text.Trim();
                                row.Cells["CApellido"].Value = TApellido.Text.Trim();
                                row.Cells["Cdni"].Value = Convert.ToInt32(TDni.Text);
                                row.Cells["CFechaNacim"].Value = DTFecha.Value;
                                row.Cells["CTelefono"].Value = Ttel.Text.Trim();
                                row.Cells["CDomicilio"].Value = TDomicilio.Text.Trim();
                                row.Cells["Ceditar"].Value = "Editar";
                                row.Cells["CIdCliente"].Value = TIndice.Text;

                                LimpiarCampos();
                                VaciarTabla();
                                ActualizarTabla();

                                BEditar.Enabled = false;
                                BGuardar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }

            }


        }

        private void LimpiarCampos()
        {
            // Limpia los campos
            TNombre.Text = "";
            TApellido.Text = "";
            TDni.Text = "";
            DTFecha.Text = "";
            TDomicilio.Text = "";
            Ttel.Text = "";
        }

        private void ActualizarTabla()
        {
            // Mostrar todos los Clientes desde la BD
            List<Cliente> listaCliente = new CN_Cliente().Listar();

            foreach (Cliente item in listaCliente)
            {
                if (item.Estado != false) //trae los clientes activos
                {
                    DGClientes.Rows.Add(new object[] { item.IdCliente, item.Nombre, item.Apellido, item.Dni, item.FechaNacimiento, item.Telefono, item.Domicilio, "Editar"
                    });
                }
            }
        }

        private void VaciarTabla()
        {
            DGClientes.Rows.Clear();
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni una tecla de borrar, cancela la entrada.
                e.Handled = true;
            }
        }

        private void Ttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni una tecla de borrar, cancela la entrada.
                e.Handled = true;
            }
        }

        private void TDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es una letra, número o espacio en blanco,
            // o si es el carácter de borrado (Retroceso o Suprimir)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                // Si no es válido, marca el evento como manejado para evitar que se ingrese
                e.Handled = true;
            }
        }


        private bool ValidarCampos()
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TDomicilio.Text) ||
                string.IsNullOrWhiteSpace(Ttel.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            // Verificar si se ha seleccionado una fecha en el DateTimePicker
            if (DTFecha.Value == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, seleccione una fecha de nacimiento válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Si todos los campos están completos y se ha seleccionado una opción en los ComboBox, y una fecha en el DateTimePicker, devuelve true
            return true;
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BGuardar.Enabled = true;
            BEditar.Enabled = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CBBusqueda.SelectedItem).Valor.ToString();

            if (DGClientes.Rows.Count > 0)  // pregunta si hay filas
            {
                foreach (DataGridViewRow row in DGClientes.Rows) // recorro cada fila del datagrid
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(BBusqueda.Text.Trim().ToUpper())) //obtengo el valor de la fila que estoy recorriendo
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
    }
}
