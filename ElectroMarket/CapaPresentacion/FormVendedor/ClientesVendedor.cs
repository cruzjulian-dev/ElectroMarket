using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ClientesVendedor : Form
    {
        int filaSeleccionada;
        bool editar = false;
        public ClientesVendedor()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void LDni_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || TCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (MessageBox.Show("Seguro que quieres guardar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Agregar nueva fila
                    DGClientes.Rows.Add(TNombre.Text.Trim(), TApellido.Text.Trim(), TDni.Text.Trim(), DTFecha.Text.Trim(), TDomicilio.Text.Trim(), TCorreo.Text.Trim());

                    foreach (DataGridViewRow row in DGClientes.Rows)
                    {
                        row.Cells["Ceditar"].Value = "Editar";
                    }
                    TNombre.Text = "";
                    TApellido.Text = "";
                    TDni.Text = "";
                    DTFecha.Text = "";
                    TDomicilio.Text = "";
                    TCorreo.Text = "";

                    editar = false;
                }
            }
        }

        private void DGCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGClientes.Columns[e.ColumnIndex].Name == "Ceditar")
            {
                if (MessageBox.Show("Seguro que quieres editar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    filaSeleccionada = DGClientes.CurrentRow.Index;
                    editar = true;

                    TNombre.Text = DGClientes.Rows[filaSeleccionada].Cells[1].Value.ToString();
                    TApellido.Text = DGClientes.Rows[filaSeleccionada].Cells[2].Value.ToString();
                    TDni.Text = DGClientes.Rows[filaSeleccionada].Cells[3].Value.ToString();
                    DTFecha.Text = DGClientes.Rows[filaSeleccionada].Cells[4].Value.ToString();
                    TDomicilio.Text = DGClientes.Rows[filaSeleccionada].Cells[5].Value.ToString();
                    TCorreo.Text = DGClientes.Rows[filaSeleccionada].Cells[6].Value.ToString();

                }

            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TDni.Text.Trim() == "" || TDomicilio.Text.Trim() == "" || TCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (editar == false)
                {
                    MessageBox.Show("No seleccionaste ningun registro para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    DGClientes.Rows[filaSeleccionada].Cells[1].Value = TNombre.Text.Trim();
                    DGClientes.Rows[filaSeleccionada].Cells[2].Value = TApellido.Text.Trim();
                    DGClientes.Rows[filaSeleccionada].Cells[3].Value = TDni.Text.Trim();
                    DGClientes.Rows[filaSeleccionada].Cells[4].Value = DTFecha.Text.Trim();
                    DGClientes.Rows[filaSeleccionada].Cells[5].Value = TDomicilio.Text.Trim();
                    DGClientes.Rows[filaSeleccionada].Cells[6].Value = TCorreo.Text.Trim();


                    editar = false;
                }
                
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DTFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void LCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
