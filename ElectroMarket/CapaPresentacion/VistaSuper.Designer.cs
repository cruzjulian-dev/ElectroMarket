namespace CapaPresentacion
{
    partial class VistaSuper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.MenuLogo = new System.Windows.Forms.MenuStrip();
            this.MenuAdmin = new System.Windows.Forms.MenuStrip();
            this.MenuUser = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProd = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LUsuario = new System.Windows.Forms.Label();
            this.MenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(1090, 7);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(82, 63);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Cerrar sesión";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MenuLogo
            // 
            this.MenuLogo.AutoSize = false;
            this.MenuLogo.BackColor = System.Drawing.Color.Black;
            this.MenuLogo.Location = new System.Drawing.Point(0, 0);
            this.MenuLogo.Name = "MenuLogo";
            this.MenuLogo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuLogo.Size = new System.Drawing.Size(1184, 76);
            this.MenuLogo.TabIndex = 6;
            this.MenuLogo.Text = "menuStrip2";
            // 
            // MenuAdmin
            // 
            this.MenuAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.MenuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUser,
            this.MenuProd,
            this.MenuReportes});
            this.MenuAdmin.Location = new System.Drawing.Point(0, 76);
            this.MenuAdmin.Name = "MenuAdmin";
            this.MenuAdmin.Size = new System.Drawing.Size(1184, 69);
            this.MenuAdmin.TabIndex = 8;
            this.MenuAdmin.Text = "menuStrip1";
            // 
            // MenuUser
            // 
            this.MenuUser.AutoSize = false;
            this.MenuUser.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.MenuUser.IconColor = System.Drawing.Color.Black;
            this.MenuUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUser.IconSize = 46;
            this.MenuUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUser.Name = "MenuUser";
            this.MenuUser.Size = new System.Drawing.Size(122, 65);
            this.MenuUser.Text = "Usuarios del sistema";
            this.MenuUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUser.Click += new System.EventHandler(this.MenuUser_Click);
            // 
            // MenuProd
            // 
            this.MenuProd.AutoSize = false;
            this.MenuProd.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.MenuProd.IconColor = System.Drawing.Color.Black;
            this.MenuProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProd.IconSize = 46;
            this.MenuProd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProd.Name = "MenuProd";
            this.MenuProd.Size = new System.Drawing.Size(142, 65);
            this.MenuProd.Text = "Backup Base de Datos";
            this.MenuProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProd.Click += new System.EventHandler(this.MenuProd_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.AutoSize = false;
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.IconSize = 46;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(152, 65);
            this.MenuReportes.Text = "Restaurar Base de Datos";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuReportes.Click += new System.EventHandler(this.MenuReportes_Click);
            // 
            // PContenedor
            // 
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(0, 145);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1184, 553);
            this.PContenedor.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo_electromarket_blanco;
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(915, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 30);
            this.label3.TabIndex = 41;
            this.label3.Text = "Super Administrador";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(878, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 30);
            this.label5.TabIndex = 40;
            this.label5.Text = "Rol:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(878, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 30);
            this.label6.TabIndex = 39;
            this.label6.Text = "Bienvenido:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LUsuario
            // 
            this.LUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.LUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.Location = new System.Drawing.Point(983, 90);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(189, 21);
            this.LUsuario.TabIndex = 42;
            this.LUsuario.Text = "nombreUsuario";
            this.LUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VistaSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 698);
            this.ControlBox = false;
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.MenuAdmin);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.MenuLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VistaSuper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaSuper";
            this.Load += new System.EventHandler(this.VistaSuper_Load);
            this.MenuAdmin.ResumeLayout(false);
            this.MenuAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.MenuStrip MenuLogo;
        private System.Windows.Forms.MenuStrip MenuAdmin;
        private FontAwesome.Sharp.IconMenuItem MenuProd;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem MenuUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LUsuario;
    }
}