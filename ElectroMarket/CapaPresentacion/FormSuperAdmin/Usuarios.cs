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
        //SistemaEntidades bd = new SistemaEntidades();
        int filaSeleccionada;
        bool editar = false;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objUsuario = new Usuario()
            {
                Nombre = TNombre.Text.Trim(),
                Apellido = TApellido.Text.Trim(),
                Dni = Convert.ToInt32(TDni.Text),
                UsuarioLogin = TUsuario.Text.Trim(),
                Clave = TContra.Text.Trim(),
                FechaNacimiento = DTFecha.Value,
                Domicilio = TDomicilio.Text.Trim(),
                Telefono = TTelefono.Text.Trim(),
                oRol = new Rol() {IdRol = Convert.ToInt32(((OpcionCombo)CBRol.SelectedItem).Valor)},
                Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).Valor) == 1 ? true : false
            };

            int idUsuarioGenerado = new CN_Usuario().RegistrarUsuario(objUsuario, out mensaje);

            if (idUsuarioGenerado != 0)
            {
                DGUsuarios.Rows.Add(new object[] { TNombre.Text, TApellido.Text, TDni.Text, TUsuario.Text, TContra.Text,
                ((OpcionCombo)CBRol.SelectedItem).Valor.ToString(), ((OpcionCombo)CBRol.SelectedItem).Texto.ToString(),
                DTFecha.Text, TTelefono.Text, TDomicilio.Text,
                ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString(), ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString()

            });
                LimpiarCampos();
                VaciarTabla();
                ActualizarTabla();
            } else
            {
                MessageBox.Show(mensaje);
            }

            

            /*
            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || TTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que quieres guardar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Agregar nueva fila
                    DGUsuarios.Rows.Add(1, TUsuario.Text.Trim(), TNombre.Text.Trim(), TApellido.Text.Trim(), TDni.Text.Trim(), DTFecha.Text.Trim(), TDomicilio.Text.Trim(), TTelefono.Text.Trim());

                    //Usuario usuario = new Usuario();
                    //bd.Usuarios.Add(usuario);
                    //bd.SaveChanges();

                    foreach (DataGridViewRow row in DGUsuarios.Rows)
                    {
                        row.Cells["Ceditar"].Value = "Editar";
                    }
                    TUsuario.Text = "";
                    TNombre.Text = "";
                    TApellido.Text = "";
                    TDni.Text = "";
                    DTFecha.Text = "";
                    TDomicilio.Text = "";
                    TTelefono.Text = "";

                    editar = false;
                }
            }
            */
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
            CBRol.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
        }

        private void ActualizarTabla()
        {
            // Actualizar la tabla con todos los Usuarios desde la BD
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {

                DGUsuarios.Rows.Add(new object[] { item.Nombre, item.Apellido, item.Dni, item.UsuarioLogin, item.Clave,
                item.oRol.IdRol, item.oRol.Descripcion, item.FechaNacimiento, item.Telefono, item.Domicilio, item.Estado == true ? 1 : 0, item.Estado == true ? "Activo" : "No Activo", item.IdUsuario
            });

            }
        }

        private void VaciarTabla()
        {
            DGUsuarios.Rows.Clear();
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objUsuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(TId.Text),
                Nombre = TNombre.Text.Trim(),
                Apellido = TApellido.Text.Trim(),
                Dni = Convert.ToInt32(TDni.Text),
                UsuarioLogin = TUsuario.Text.Trim(),
                Clave = TContra.Text.Trim(),
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
                row.Cells["CContra"].Value = TContra.Text.Trim();
                row.Cells["CIdRol"].Value = ((OpcionCombo)CBRol.SelectedItem).Valor.ToString();
                row.Cells["CRol"].Value = ((OpcionCombo)CBRol.SelectedItem).Texto.ToString();
                row.Cells["CFechaNacim"].Value = DTFecha.Value;
                row.Cells["CTelefono"].Value = TTelefono.Text.Trim();
                row.Cells["CDomicilio"].Value = TDomicilio.Text.Trim();
                row.Cells["CEstadoValor"].Value = ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString();
                row.Cells["CEstado"].Value = ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString();
                row.Cells["CIdUsuario"].Value = TIndice.Text;

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

        private void DGUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Click al boton editar en un registro del datagridview
            if (DGUsuarios.Columns[e.ColumnIndex].Name == "Ceditar")
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
            CBEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                CBRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }

            CBRol.DisplayMember = "Texto";
            CBRol.ValueMember = "Valor";
            CBRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in DGUsuarios.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "Fecha de Nacimiento" && columna.HeaderText != "Contraseña" && columna.HeaderText != "Domicilio" && columna.HeaderText != "Estado" && columna.HeaderText != "Editar")
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
                item.oRol.IdRol, item.oRol.Descripcion, item.FechaNacimiento, item.Telefono, item.Domicilio, item.Estado == true ? 1 : 0, item.Estado == true ? "Activo" : "No Activo", item.IdUsuario
            });

            }

        }

        private void TUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }

        }

        private void TUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DGUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
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

        private void TContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TTelefono_TextChanged(object sender, EventArgs e)
        {

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

        }
    }
}
