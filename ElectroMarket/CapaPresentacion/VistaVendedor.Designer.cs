namespace CapaPresentacion
{
    partial class VistaVendedor
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
            this.MenuLogo = new System.Windows.Forms.MenuStrip();
            this.MenuVendedor = new System.Windows.Forms.MenuStrip();
            this.MenuUser = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProd = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SMCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.SMProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.MenuVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLogo
            // 
            this.MenuLogo.AutoSize = false;
            this.MenuLogo.BackColor = System.Drawing.Color.Black;
            this.MenuLogo.Location = new System.Drawing.Point(0, 0);
            this.MenuLogo.Name = "MenuLogo";
            this.MenuLogo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuLogo.Size = new System.Drawing.Size(984, 76);
            this.MenuLogo.TabIndex = 4;
            this.MenuLogo.Text = "menuStrip2";
            // 
            // MenuVendedor
            // 
            this.MenuVendedor.BackColor = System.Drawing.SystemColors.Window;
            this.MenuVendedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUser,
            this.MenuProd,
            this.MenuVentas});
            this.MenuVendedor.Location = new System.Drawing.Point(0, 76);
            this.MenuVendedor.Name = "MenuVendedor";
            this.MenuVendedor.Size = new System.Drawing.Size(984, 69);
            this.MenuVendedor.TabIndex = 6;
            this.MenuVendedor.Text = "menuStrip1";
            // 
            // MenuUser
            // 
            this.MenuUser.AutoSize = false;
            this.MenuUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.MenuUser.IconColor = System.Drawing.Color.Black;
            this.MenuUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUser.IconSize = 46;
            this.MenuUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUser.Name = "MenuUser";
            this.MenuUser.Size = new System.Drawing.Size(75, 65);
            this.MenuUser.Text = "Clientes";
            this.MenuUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUser.Click += new System.EventHandler(this.MenuUser_Click);
            // 
            // MenuProd
            // 
            this.MenuProd.AutoSize = false;
            this.MenuProd.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MenuProd.IconColor = System.Drawing.Color.Black;
            this.MenuProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProd.IconSize = 46;
            this.MenuProd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProd.Name = "MenuProd";
            this.MenuProd.Size = new System.Drawing.Size(122, 65);
            this.MenuProd.Text = "Ver Productos";
            this.MenuProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProd.Click += new System.EventHandler(this.MenuProd_Click);
            // 
            // MenuVentas
            // 
            this.MenuVentas.AutoSize = false;
            this.MenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMCategoria,
            this.SMProductos});
            this.MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentas.IconColor = System.Drawing.Color.Black;
            this.MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentas.IconSize = 46;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(75, 65);
            this.MenuVentas.Text = "Ventas";
            this.MenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SMCategoria
            // 
            this.SMCategoria.Name = "SMCategoria";
            this.SMCategoria.Size = new System.Drawing.Size(140, 22);
            this.SMCategoria.Text = "Nueva Venta";
            this.SMCategoria.Click += new System.EventHandler(this.SMCategoria_Click);
            // 
            // SMProductos
            // 
            this.SMProductos.Name = "SMProductos";
            this.SMProductos.Size = new System.Drawing.Size(140, 22);
            this.SMProductos.Text = "Mis Ventas";
            this.SMProductos.Click += new System.EventHandler(this.SMProductos_Click);
            // 
            // PContenedor
            // 
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(0, 145);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(984, 553);
            this.PContenedor.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo_electromarket_blanco;
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(890, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(82, 63);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Cerrar sesión";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // VistaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 698);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.MenuVendedor);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.MenuLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VistaVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaVendedor";
            this.MenuVendedor.ResumeLayout(false);
            this.MenuVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.MenuStrip MenuLogo;
        private System.Windows.Forms.MenuStrip MenuVendedor;
        private FontAwesome.Sharp.IconMenuItem MenuUser;
        private FontAwesome.Sharp.IconMenuItem MenuProd;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private System.Windows.Forms.ToolStripMenuItem SMCategoria;
        private System.Windows.Forms.ToolStripMenuItem SMProductos;
    }
}