﻿namespace CapaPresentacion
{
    partial class VistaAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuAdmin = new System.Windows.Forms.MenuStrip();
            this.MenuUser = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProd = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.MenuLogo = new System.Windows.Forms.MenuStrip();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.LUsuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuAdmin
            // 
            this.MenuAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.MenuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUser,
            this.MenuProd,
            this.iconMenuItem1,
            this.MenuReportes,
            this.iconMenuItem2});
            this.MenuAdmin.Location = new System.Drawing.Point(0, 76);
            this.MenuAdmin.Name = "MenuAdmin";
            this.MenuAdmin.Size = new System.Drawing.Size(1184, 69);
            this.MenuAdmin.TabIndex = 0;
            this.MenuAdmin.Text = "menuStrip1";
            this.MenuAdmin.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuAdmin_ItemClicked);
            // 
            // MenuUser
            // 
            this.MenuUser.AutoSize = false;
            this.MenuUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuUser.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.MenuUser.IconColor = System.Drawing.Color.Black;
            this.MenuUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUser.IconSize = 46;
            this.MenuUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUser.Name = "MenuUser";
            this.MenuUser.Size = new System.Drawing.Size(160, 65);
            this.MenuUser.Text = "Clientes";
            this.MenuUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUser.Click += new System.EventHandler(this.MenuUser_Click);
            // 
            // MenuProd
            // 
            this.MenuProd.AutoSize = false;
            this.MenuProd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProd.IconChar = FontAwesome.Sharp.IconChar.FolderTree;
            this.MenuProd.IconColor = System.Drawing.Color.Black;
            this.MenuProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProd.IconSize = 46;
            this.MenuProd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProd.Name = "MenuProd";
            this.MenuProd.Size = new System.Drawing.Size(160, 65);
            this.MenuProd.Text = "Categorias";
            this.MenuProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProd.Click += new System.EventHandler(this.MenuProd_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.AutoSize = false;
            this.iconMenuItem1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 46;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(160, 65);
            this.iconMenuItem1.Text = "Productos";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItem1.Click += new System.EventHandler(this.iconMenuItem1_Click_1);
            // 
            // MenuReportes
            // 
            this.MenuReportes.AutoSize = false;
            this.MenuReportes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.IconSize = 46;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(160, 65);
            this.MenuReportes.Text = "Reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuReportes.Click += new System.EventHandler(this.MenuReportes_Click);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.AutoSize = false;
            this.iconMenuItem2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 46;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(165, 65);
            this.iconMenuItem2.Text = "Graficos";
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItem2.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // MenuLogo
            // 
            this.MenuLogo.AutoSize = false;
            this.MenuLogo.BackColor = System.Drawing.Color.Black;
            this.MenuLogo.Location = new System.Drawing.Point(0, 0);
            this.MenuLogo.Name = "MenuLogo";
            this.MenuLogo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuLogo.Size = new System.Drawing.Size(1184, 76);
            this.MenuLogo.TabIndex = 1;
            this.MenuLogo.Text = "menuStrip2";
            this.MenuLogo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuLogo_ItemClicked);
            // 
            // PContenedor
            // 
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(0, 145);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1184, 553);
            this.PContenedor.TabIndex = 4;
            this.PContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PContenedor_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo_electromarket_blanco;
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Cerrar sesión";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // LUsuario
            // 
            this.LUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.LUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.Location = new System.Drawing.Point(940, 87);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(239, 21);
            this.LUsuario.TabIndex = 46;
            this.LUsuario.Text = "nombreUsuario";
            this.LUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(873, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 30);
            this.label5.TabIndex = 45;
            this.label5.Text = "Administrador";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(833, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 30);
            this.label6.TabIndex = 44;
            this.label6.Text = "Rol:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(833, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 30);
            this.label7.TabIndex = 43;
            this.label7.Text = "Bienvenido:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VistaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 698);
            this.ControlBox = false;
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.MenuAdmin);
            this.Controls.Add(this.MenuLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MenuAdmin;
            this.Name = "VistaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroMarket";
            this.Load += new System.EventHandler(this.VistaAdmin_Load);
            this.MenuAdmin.ResumeLayout(false);
            this.MenuAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuAdmin;
        private System.Windows.Forms.MenuStrip MenuLogo;
        private FontAwesome.Sharp.IconMenuItem MenuUser;
        private FontAwesome.Sharp.IconMenuItem MenuProd;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
    }
}

