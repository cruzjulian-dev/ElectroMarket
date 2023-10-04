﻿using CapaPresentacion.Utilidades;
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

            if (TDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que quieres agregar esta categoria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    // Agregar nueva fila
                    DGCategoria.Rows.Add("", TDescripcion.Text.Trim(), ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString(), ((OpcionCombo)CBEstado.SelectedItem).Valor.ToString(), "Editar");

                    LimpiarCampos();
                }
            }
        }

        private void LimpiarCampos()
        {
            TDescripcion.Text = "";
            CBEstado.SelectedIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string descripcion = TDescripcion.Text;
            string Estado = ((OpcionCombo)CBEstado.SelectedItem).Texto;

            if (TDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Actualiza la fila seleccionada en el DataGridView
                DataGridViewRow selectedRow = DGCategoria.Rows[DGCategoria.CurrentCell.RowIndex];

                selectedRow.Cells["Cdescripcion"].Value = descripcion;
                selectedRow.Cells["Cestado"].Value = Estado;
                selectedRow.Cells["CEstadoValor"].Value = ((OpcionCombo)CBEstado.SelectedItem).Valor;

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

                LimpiarCampos();
                BEditar.Enabled = false;
                BGuardar.Enabled = true;

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
            // Por defecto, deshabilita el botón "Editar"
            BEditar.Enabled = false;

            CBEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

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
