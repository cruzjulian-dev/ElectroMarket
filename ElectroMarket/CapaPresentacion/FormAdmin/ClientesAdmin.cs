using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CapaPresentacion
{
    public partial class ClientesAdmin : Form
    {

        public ClientesAdmin()
        {
            InitializeComponent();
        }

        private void ClientesAdmin_Load(object sender, EventArgs e)
        {
            BEditar.Enabled = false;

            CBEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = -1;


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

                DGClientes.Rows.Add(new object[] { item.Nombre, item.Apellido, item.Dni, item.FechaNacimiento, item.Telefono, item.Domicilio, item.Estado == true ? 1 : 0, item.Estado == true ? "Activo" : "No Activo", "Editar", item.IdCliente 
            });

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || TTelefono.Text.Trim() == "" || CBEstado.SelectedIndex == -1)
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
                    }
                    else
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
                                Telefono = TTelefono.Text.Trim(),
                                Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).Valor) == 1 ? true : false
                            };

                            int idClienteGenerado = new CN_Cliente().RegistrarCliente(objCliente, out mensaje);

                            if (idClienteGenerado != 0)
                            {
                                DGClientes.Rows.Add(new object[] { TNombre.Text, TApellido.Text, TDni.Text, DTFecha.Text, TTelefono.Text, TDomicilio.Text,
                                ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString(), ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString(),
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

        private void LimpiarCampos()
        {
            // Limpia los campos
            TNombre.Text = "";
            TApellido.Text = "";
            TDni.Text = "";
            DTFecha.Text = "";
            TDomicilio.Text = "";
            TTelefono.Text = "";
            CBEstado.SelectedIndex = -1;
        }

        private void ActualizarTabla()
        {

            // Mostrar todos los Clientes desde la BD
            List<Cliente> listaCliente = new CN_Cliente().Listar();

            foreach (Cliente item in listaCliente)
            {

                DGClientes.Rows.Add(new object[] { item.Nombre, item.Apellido, item.Dni, item.FechaNacimiento, item.Telefono, item.Domicilio, item.Estado == true ? 1 : 0, item.Estado == true ? "Activo" : "No Activo", "Editar", item.IdCliente
            });

            }

        }

        private void VaciarTabla()
        {
            DGClientes.Rows.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            string domicilio = TDomicilio.Text;
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;
            string telefono = TTelefono.Text;
            string dni = TDni.Text;
            string Estado = ((OpcionCombo)CBEstado.SelectedItem).Texto;

            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || TTelefono.Text.Trim() == "" || CBEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
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
                                IdCliente = Convert.ToInt32(TId.Text),
                                Nombre = TNombre.Text.Trim(),
                                Apellido = TApellido.Text.Trim(),
                                Dni = Convert.ToInt32(TDni.Text),
                                FechaNacimiento = DTFecha.Value,
                                Domicilio = TDomicilio.Text.Trim(),
                                Telefono = TTelefono.Text.Trim(),
                                Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).Valor) == 1 ? true : false
                            };

                            bool resultado = new CN_Cliente().EditarCliente(objCliente, out mensaje);

                            if (resultado == true)
                            {
                                DataGridViewRow row = DGClientes.Rows[Convert.ToInt32(TIndice.Text)];

                                row.Cells["CNombre"].Value = TNombre.Text.Trim();
                                row.Cells["CApellido"].Value = TApellido.Text.Trim();
                                row.Cells["Cdni"].Value = Convert.ToInt32(TDni.Text);
                                row.Cells["CFechaNacim"].Value = DTFecha.Value;
                                row.Cells["CTelefono"].Value = TTelefono.Text.Trim();
                                row.Cells["CDomicilio"].Value = TDomicilio.Text.Trim();
                                row.Cells["CEstadoValor"].Value = ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString();
                                row.Cells["Cestado"].Value = ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString();
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
                                MessageBox.Show(mensaje);
                            }
                        }

                    }
                }
                
            }
            

            
        }

        private void DGClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGClientes.Columns[e.ColumnIndex].Name == "Ceditar" && e.RowIndex >= 0)
            {

                if (MessageBox.Show("Seguro que quieres editar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Habilita el botón "Editar"
                    BEditar.Enabled = true;
                    BGuardar.Enabled = false;

                    int indice = e.RowIndex;
                    TId.Text = DGClientes.Rows[indice].Cells["CIdCliente"].Value.ToString(); ;
                    TIndice.Text = e.RowIndex.ToString();
                    

                    // Obtengo los valores de las celdas de la fila seleccionada
                    DataGridViewRow selectedRow = DGClientes.Rows[e.RowIndex];

                    CBEstado.SelectedItem = selectedRow.Cells["Cestado"].Value.ToString();
                    TNombre.Text = selectedRow.Cells["CNombre"].Value.ToString();
                    TApellido.Text = selectedRow.Cells["CApellido"].Value.ToString();
                    TDni.Text = selectedRow.Cells["Cdni"].Value.ToString();
                    DTFecha.Text = selectedRow.Cells["CFechaNacim"].Value.ToString();
                    TTelefono.Text = selectedRow.Cells["CTelefono"].Value.ToString();
                    TDomicilio.Text = selectedRow.Cells["CDomicilio"].Value.ToString();

                    foreach (OpcionCombo oc in CBEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGClientes.Rows[indice].Cells["CEstadoValor"].Value))
                        {
                            int indice_combo = CBEstado.Items.IndexOf(oc);
                            CBEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
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

        private void TFecha_Validating(object sender, CancelEventArgs e)
        { }


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

        private void Ttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni una tecla de borrar, cancela la entrada.
                e.Handled = true;
            }
        }

        private void DGClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in DGClientes.Rows)
            {
                // Obtener el valor de la celda en la columna "CEstado"
                string estado = row.Cells["CEstado"].Value as string;

                // Verificar si el estado es "No Activo"
                if (estado == "No Activo")
                {

                    row.DefaultCellStyle.BackColor = Color.Red;
                } else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            TBusqueda.Text = "";
            VaciarTabla();
            ActualizarTabla();
        }

        private void TBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                iconButton2_Click(sender, e);
            }
         
        }
    }
}
