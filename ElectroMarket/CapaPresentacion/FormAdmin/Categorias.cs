using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CapaPresentacion
{

    public partial class CategoriasAdmin : Form
    {

        public CategoriasAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DGCategoria.Columns[e.ColumnIndex].Name == "Ceditar" && e.RowIndex >= 0)
            {

                if (MessageBox.Show("Seguro que quieres editar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Habilita el botón "Editar"
                    BEditar.Enabled = true;
                    BGuardar.Enabled = false;

                    //TId.Text = DGClientes.Rows[e.RowIndex];
                    //TIndice.Text = e.RowIndex.ToString();
                    int indice = e.RowIndex;

                    // Obtengo los valores de las celdas de la fila seleccionada
                    DataGridViewRow selectedRow = DGCategoria.Rows[e.RowIndex];

                    CBEstado.SelectedItem = selectedRow.Cells["Cestado"].Value.ToString();
                    TDescripcion.Text = selectedRow.Cells["Cdescripcion"].Value.ToString();

                    foreach (OpcionCombo oc in CBEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGCategoria.Rows[indice].Cells["CestadoVAlor"].Value))
                        {
                            int indice_combo = CBEstado.Items.IndexOf(oc);
                            CBEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (TDescripcion.Text.Trim() == "" || CBEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("Seguro que quieres agregar esta categoria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Categoria objCategoria = new Categoria()
                    {
                        Descripcion = TDescripcion.Text.Trim(),
                        Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).Valor) == 1 ? true : false
                    };

                    int idCategoriaGenerado = new CN_Categoria().RegistrarCategoria(objCategoria, out mensaje);

                    if (idCategoriaGenerado != 0)
                    {
                        DGCategoria.Rows.Add(new object[] { TDescripcion.Text, ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString(), 
                        ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString(), "Editar", idCategoriaGenerado
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

        private void LimpiarCampos()
        {
            TDescripcion.Text = "";
            CBEstado.SelectedIndex = -1;
        }

        private void ActualizarTabla()
        {

            // Mostrar todos las categorias desde la BD
            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listaCategoria)
            {

                DGCategoria.Rows.Add(new object[] { item.IdCategoria, item.Descripcion, item.Estado == true ? 1 : 0, item.Estado == true ? "Activo" : "No Activo", "Editar"
            });

            }

        }

        private void VaciarTabla()
        {
            DGCategoria.Rows.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string descripcion = TDescripcion.Text;
            string Estado = ((OpcionCombo)CBEstado.SelectedItem).Texto;

            if (TDescripcion.Text.Trim() == "" || CBEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Deseas guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Categoria objCategoria = new Categoria()
                    {
                        IdCategoria = Convert.ToInt32(TId.Text),
                        Descripcion = TDescripcion.Text.Trim(),
                        Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).Valor) == 1 ? true : false
                    };

                    bool resultado = new CN_Categoria().EditarCategoria(objCategoria, out mensaje);

                    if (resultado == true)
                    {
                        DataGridViewRow row = DGCategoria.Rows[Convert.ToInt32(TIndice.Text)];

                        row.Cells["CIdCategoria"].Value = TId.Text.Trim();
                        row.Cells["Cdescripcion"].Value = TDescripcion.Text.Trim();
                        row.Cells["CestadoVAlor"].Value = ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString();
                        row.Cells["Cestado"].Value = ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString();
                        row.Cells["Ceditar"].Value = "Editar";

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



        void limpiar()
        {
            //limpiar todo
           
            TDescripcion.Clear();
            
            // Limpia la selección en el ComboBox para que aparezca vacío
            
            CBEstado.SelectedIndex = -1;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es una letra, número, espacio en blanco, coma o cualquier otro carácter permitido,
            // o si es el carácter de borrado (Retroceso o Suprimir)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ';' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                // Si no es válido, marca el evento como manejado para evitar que se ingrese
                e.Handled = true;
            }
        }


        private void CategoriasAdmin_Load(object sender, EventArgs e)
        {
            BEditar.Enabled = false;

            CBEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = -1;


            foreach (DataGridViewColumn columna in DGCategoria.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "Fecha de Nacimiento" && columna.HeaderText != "Contraseña" && columna.HeaderText != "Estado" && columna.HeaderText != "Editar")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;


            // Mostrar todos los Usuarios desde la BD
            List<Categoria> lista = new CN_Categoria().Listar();

            foreach (Categoria item in lista)
            {

                DGCategoria.Rows.Add(new object[] { item.IdCategoria,
                    item.Descripcion,
                    item.Estado == true ? "Activo" : "No Activo",
                    item.IdCategoria, "Editar"
            });

            }



        }

        private void DGCategoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in DGCategoria.Rows)
            {
                // Obtener el valor de la celda en la columna "CEstado"
                string estado = row.Cells["Cestado"].Value as string;

                // Verificar si el estado es "No Activo"
                if (estado == "No Activo")
                {

                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BGuardar.Enabled = true;
            BEditar.Enabled = false;
        }
    }
}
