using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseas cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {

            List<Usuario> TEST = new CN_Usuario().Listar();

            Usuario oUsuario = new CN_Usuario().Listar().Where(x => x.UsuarioLogin == TUser.Text && x.Clave == TContra.Text).FirstOrDefault();

            if ((TUser.Text.Trim() == "" && TContra.Text.Trim() == "") || (TUser.Text.Trim() != "" && TContra.Text.Trim() == "") || (TUser.Text.Trim() == "" && TContra.Text.Trim() != ""))
            {
                MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TUser.Text = "";
                TContra.Text = "";
            } else
            {
                if (oUsuario != null)
                {
                    if (oUsuario.Estado != false)
                    {
                        switch (oUsuario.oRol.IdRol)
                        {
                            case 1:
                                VistaVendedor vistaVendedor = new VistaVendedor(oUsuario);
                                vistaVendedor.Show();
                                break;

                            case 2:
                                VistaAdmin vistaAdmin = new VistaAdmin(oUsuario);
                                vistaAdmin.Show();
                                break;
                            case 3:
                                VistaSuper vistaSuper = new VistaSuper(oUsuario);
                                vistaSuper.Show();
                                break;

                        }
                        this.Close();

                    } else
                    {
                        MessageBox.Show("Usuario deshabilitado, porfavor contacta al Administrador del sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TUser.Text = "";
                        TContra.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TUser.Text = "";
                    TContra.Text = "";
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BIngresar_Click(sender, e);
            }

        }

        private void TContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void TUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BIngresar_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

            timer1.Start();
            // Obtener la fecha actual del sistema
            DateTime fechaActual = DateTime.Now;

            // Actualizar el texto del Label con la fecha actual en el formato deseado
            Lfechahoy.Text = fechaActual.ToString("dd/MM/yyyy");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Obtener la hora, los minutos y los segundos actuales
            DateTime horaActual = DateTime.Now;
            int horas = horaActual.Hour;
            int minutos = horaActual.Minute;
            int segundos = horaActual.Second;

            // Formatear la hora, minutos y segundos en un formato legible
            string horaMinutosSegundos = $"{horas:D2}:{minutos:D2}:{segundos:D2}";

            Lhora.Text = horaMinutosSegundos;
        }
    }
}
