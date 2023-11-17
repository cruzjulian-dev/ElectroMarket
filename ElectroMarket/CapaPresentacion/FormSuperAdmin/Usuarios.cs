using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {

            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TUsuario.Text.Trim() == "" || TContra.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || TTelefono.Text.Trim() == "" || CBEstado.SelectedIndex == -1 || CBRol.SelectedIndex == -1)
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
                        MessageBox.Show("El usuario debe ser mayor de 18 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("Seguro que quieres guardar el usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string mensaje = string.Empty;
                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(TContra.Text.Trim());

                            Usuario objUsuario = new Usuario()
                            {
                                Nombre = TNombre.Text.Trim(),
                                Apellido = TApellido.Text.Trim(),
                                Dni = Convert.ToInt32(TDni.Text),
                                UsuarioLogin = TUsuario.Text.Trim(),
                                Clave = hashedPassword,
                                FechaNacimiento = DTFecha.Value,
                                Domicilio = TDomicilio.Text.Trim(),
                                Telefono = TTelefono.Text.Trim(),
                                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)CBRol.SelectedItem).Valor) },
                                Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).Valor) == 1 ? true : false
                            };

                            int idUsuarioGenerado = new CN_Usuario().RegistrarUsuario(objUsuario, out mensaje);

                            if (idUsuarioGenerado != 0)
                            {
                                DGUsuarios.Rows.Add(new object[] { TNombre.Text, TApellido.Text, TDni.Text, TUsuario.Text, hashedPassword,
                                ((OpcionCombo)CBRol.SelectedItem).Valor.ToString(), ((OpcionCombo)CBRol.SelectedItem).Texto.ToString(),
                                DTFecha.Text, TTelefono.Text, TDomicilio.Text,
                                ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString(), ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString(),
                                idUsuarioGenerado, "Editar"

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
            TUsuario.Text = "";
            TContra.Text = "";
            DTFecha.Text = "";
            TDomicilio.Text = "";
            TTelefono.Text = "";
            CBRol.SelectedIndex = -1;
            CBEstado.SelectedIndex = -1;
        }

        private void ActualizarTabla()
        {
            // Actualizar la tabla con todos los Usuarios desde la BD
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {

                DGUsuarios.Rows.Add(new object[] { item.Nombre, item.Apellido, item.Dni, item.UsuarioLogin, item.Clave,
                item.oRol.IdRol, item.oRol.Descripcion, item.FechaNacimiento, item.Telefono, item.Domicilio, item.Estado == true ? 1 : 0, item.Estado == true ? "Activo" : "No Activo", item.IdUsuario, "Editar"
            });

            }
        }

        private void VaciarTabla()
        {
            DGUsuarios.Rows.Clear();
        }

        private void BEditar_Click(object sender, EventArgs e)
        {

            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TUsuario.Text.Trim() == "" || TContra.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || TTelefono.Text.Trim() == "" || CBEstado.SelectedIndex == -1 || CBRol.SelectedIndex == -1)
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
                        MessageBox.Show("El usuario debe ser mayor de 18 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("Deseas guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string mensaje = string.Empty;

                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(TContra.Text);

                            Usuario objUsuario = new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(TId.Text),
                                Nombre = TNombre.Text.Trim(),
                                Apellido = TApellido.Text.Trim(),
                                Dni = Convert.ToInt32(TDni.Text),
                                UsuarioLogin = TUsuario.Text.Trim(),
                                Clave = hashedPassword,
                                FechaNacimiento = DTFecha.Value,
                                Domicilio = TDomicilio.Text.Trim(),
                                Telefono = TTelefono.Text.Trim(),
                                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)CBRol.SelectedItem).Valor) },
                                Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).Valor) == 1 ? true : false
                            };

                            bool resultado = new CN_Usuario().EditarUsuario(objUsuario, out mensaje);

                            if (resultado == true)
                            {
                                DataGridViewRow row = DGUsuarios.Rows[Convert.ToInt32(TIndice.Text)];

                                row.Cells["CNombre"].Value = TNombre.Text.Trim();
                                row.Cells["CApellido"].Value = TApellido.Text.Trim();
                                row.Cells["CDni"].Value = Convert.ToInt32(TDni.Text);
                                row.Cells["CUsuario"].Value = TUsuario.Text.Trim();
                                row.Cells["CContra"].Value = hashedPassword;
                                row.Cells["CIdRol"].Value = ((OpcionCombo)CBRol.SelectedItem).Valor.ToString();
                                row.Cells["CRol"].Value = ((OpcionCombo)CBRol.SelectedItem).Texto.ToString();
                                row.Cells["CFechaNacim"].Value = DTFecha.Value;
                                row.Cells["CTelefono"].Value = TTelefono.Text.Trim();
                                row.Cells["CDomicilio"].Value = TDomicilio.Text.Trim();
                                row.Cells["CEstadoValor"].Value = ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString();
                                row.Cells["CEstado"].Value = ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString();
                                row.Cells["CIdUsuario"].Value = TIndice.Text;
                                row.Cells["Ceditar"].Value = "Editar";

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

        private void DGUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Click al boton editar en un registro del datagridview
            if (DGUsuarios.Columns[e.ColumnIndex].Name == "Ceditar" && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Seguro que quieres editar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TIndice.Text = e.RowIndex.ToString();
                    int indice = e.RowIndex;
                    TId.Text = DGUsuarios.Rows[indice].Cells["CIdUsuario"].Value.ToString(); //guardo en el textbox invisible el id del usuario al que quiero editar

                    // Habilita el botón "Editar"
                    BEditar.Enabled = true;

                    // Deshabilita el botón "Guardar"
                    BGuardar.Enabled = false;

                    if (indice >= 0)
                    {
                        TNombre.Text = DGUsuarios.Rows[indice].Cells["CNombre"].Value.ToString();
                        TApellido.Text = DGUsuarios.Rows[indice].Cells["CApellido"].Value.ToString();
                        TDni.Text = DGUsuarios.Rows[indice].Cells["CDni"].Value.ToString();
                        TUsuario.Text = DGUsuarios.Rows[indice].Cells["CUsuario"].Value.ToString();
                        TContra.Text = DGUsuarios.Rows[indice].Cells["CContra"].Value.ToString();
                        DTFecha.Text = DGUsuarios.Rows[indice].Cells["CFechaNacim"].Value.ToString();
                        TTelefono.Text = DGUsuarios.Rows[indice].Cells["CTelefono"].Value.ToString();
                        TDomicilio.Text = DGUsuarios.Rows[indice].Cells["CDomicilio"].Value.ToString();


                        foreach (OpcionCombo oc in CBRol.Items)
                        {
                            if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGUsuarios.Rows[indice].Cells["CIdRol"].Value))
                            {
                                int indice_combo = CBRol.Items.IndexOf(oc);
                                CBRol.SelectedIndex = indice_combo;
                                break;
                            }
                        }

                        foreach (OpcionCombo oc in CBEstado.Items)
                        {
                            if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGUsuarios.Rows[indice].Cells["CEstadoValor"].Value))
                            {
                                int indice_combo = CBEstado.Items.IndexOf(oc);
                                CBEstado.SelectedIndex = indice_combo;
                                break;
                            }
                        }


                    }
                    
                }

            }
        }



        private void Usuarios_Load(object sender, EventArgs e)
        {
            BEditar.Enabled = false;

            CBEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = -1;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                CBRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }

            CBRol.DisplayMember = "Texto";
            CBRol.ValueMember = "Valor";
            CBRol.SelectedIndex = -1;

            foreach (DataGridViewColumn columna in DGUsuarios.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "Fecha de Nacimiento" && columna.HeaderText != "Contraseña" && columna.HeaderText != "Estado" && columna.HeaderText != "Editar")
                {
                    CBBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText});
                }
            }
            CBBusqueda.DisplayMember = "Texto";
            CBBusqueda.ValueMember = "Valor";
            CBBusqueda.SelectedIndex = 0;


            // Mostrar todos los Usuarios desde la BD
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                
                DGUsuarios.Rows.Add(new object[] { item.Nombre, item.Apellido, item.Dni, item.UsuarioLogin, item.Clave,
                item.oRol.IdRol, item.oRol.Descripcion, item.FechaNacimiento, item.Telefono, item.Domicilio, item.Estado == true ? 1 : 0, item.Estado == true ? "Activo" : "No Activo", item.IdUsuario, "Editar"
            });

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

        private void DGUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in DGUsuarios.Rows)
            {
                // Obtén el valor de la columna "Estado" para la fila actual
                string estado = row.Cells["CEstado"].Value.ToString();
                
                // Compara el valor de la columna "Estado" con "No activo"
                if (estado.Equals("No Activo", StringComparison.OrdinalIgnoreCase))
                {
                    // Cambia el color de fondo de la fila a rojo
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }

            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BGuardar.Enabled = true;
            BEditar.Enabled = false;
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

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
            // Verifica si el carácter ingresado no es una letra, número, espacio en blanco, coma o cualquier otro carácter permitido,
            // o si es el carácter de borrado (Retroceso o Suprimir)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ';' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
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
                string.IsNullOrWhiteSpace(TUsuario.Text) ||
                string.IsNullOrWhiteSpace(TTelefono.Text) ||
                string.IsNullOrWhiteSpace(TDomicilio.Text) ||
                string.IsNullOrWhiteSpace(TContra.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar si se ha seleccionado una opción en los ComboBox
            if (CBRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CBEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CBBusqueda.SelectedItem).Valor.ToString();

            if (DGUsuarios.Rows.Count > 0)  // pregunta si hay filas
            {
                foreach (DataGridViewRow row in DGUsuarios.Rows) // recorro cada fila del datagrid
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TBusqueda.Text.Trim().ToUpper())) //obtengo el valor de la fila que estoy recorriendo
                    {
                        row.Visible = true;
                    } else
                    {
                        row.Visible = false;
                    }

                }
            }

        }

        private void BMostrarTodo_MouseHover(object sender, EventArgs e)
        {
            // Crear una instancia de ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el texto a mostrar cuando el mouse esté sobre el botón
            toolTip.SetToolTip(BMostrarTodo, "Mostrar todo");
        }

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            // Crear una instancia de ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer el texto a mostrar cuando el mouse esté sobre el botón
            toolTip.SetToolTip(iconButton1, "Limpiar campos");
        }

        private void BMostrarTodo_Click(object sender, EventArgs e)
        {
            TBusqueda.Text = "";
            VaciarTabla();
            ActualizarTabla();
        }

        private void TBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BBusqueda_Click(sender, e);
            }
        }
    }
}
