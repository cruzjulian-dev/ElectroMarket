﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class VistaVendedor : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public VistaVendedor()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.White;
            PContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        private void SMCategoria_Click(object sender, EventArgs e)
        {

        }

        private void SMProductos_Click(object sender, EventArgs e)
        {

        }

        private void MenuReportes_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MenuUser_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Clientes());
        }
    }
}
