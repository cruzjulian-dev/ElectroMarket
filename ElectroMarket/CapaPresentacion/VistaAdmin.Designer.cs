namespace CapaPresentacion
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
            this.MenuLogo = new System.Windows.Forms.MenuStrip();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.MenuUser = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProd = new FontAwesome.Sharp.IconMenuItem();
            this.SMCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.SMProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
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
            this.MenuReportes,
            this.MenuAcercaDe});
            this.MenuAdmin.Location = new System.Drawing.Point(0, 76);
            this.MenuAdmin.Name = "MenuAdmin";
            this.MenuAdmin.Size = new System.Drawing.Size(984, 69);
            this.MenuAdmin.TabIndex = 0;
            this.MenuAdmin.Text = "menuStrip1";
            this.MenuAdmin.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuAdmin_ItemClicked);
            // 
            // MenuLogo
            // 
            this.MenuLogo.AutoSize = false;
            this.MenuLogo.BackColor = System.Drawing.Color.Black;
            this.MenuLogo.Location = new System.Drawing.Point(0, 0);
            this.MenuLogo.Name = "MenuLogo";
            this.MenuLogo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuLogo.Size = new System.Drawing.Size(984, 76);
            this.MenuLogo.TabIndex = 1;
            this.MenuLogo.Text = "menuStrip2";
            this.MenuLogo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuLogo_ItemClicked);
            // 
            // PContenedor
            // 
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(0, 145);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(984, 553);
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
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(890, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(82, 63);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Cerrar sesión";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.MenuUser.Size = new System.Drawing.Size(122, 65);
            this.MenuUser.Text = "Clientes";
            this.MenuUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUser.Click += new System.EventHandler(this.MenuUser_Click);
            // 
            // MenuProd
            // 
            this.MenuProd.AutoSize = false;
            this.MenuProd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMCategoria,
            this.SMProductos});
            this.MenuProd.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MenuProd.IconColor = System.Drawing.Color.Black;
            this.MenuProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProd.IconSize = 46;
            this.MenuProd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProd.Name = "MenuProd";
            this.MenuProd.Size = new System.Drawing.Size(122, 65);
            this.MenuProd.Text = "Productos";
            this.MenuProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProd.Click += new System.EventHandler(this.MenuProd_Click);
            // 
            // SMCategoria
            // 
            this.SMCategoria.Name = "SMCategoria";
            this.SMCategoria.Size = new System.Drawing.Size(180, 22);
            this.SMCategoria.Text = "Categoria";
            this.SMCategoria.Click += new System.EventHandler(this.SMCategoria_Click);
            // 
            // SMProductos
            // 
            this.SMProductos.Name = "SMProductos";
            this.SMProductos.Size = new System.Drawing.Size(180, 22);
            this.SMProductos.Text = "Productos";
            this.SMProductos.Click += new System.EventHandler(this.SMProductos_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.AutoSize = false;
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.IconSize = 46;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(75, 65);
            this.MenuReportes.Text = "Reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuReportes.Click += new System.EventHandler(this.MenuReportes_Click);
            // 
            // MenuAcercaDe
            // 
            this.MenuAcercaDe.AutoSize = false;
            this.MenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MenuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.MenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAcercaDe.IconSize = 46;
            this.MenuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAcercaDe.Name = "MenuAcercaDe";
            this.MenuAcercaDe.Size = new System.Drawing.Size(75, 65);
            this.MenuAcercaDe.Text = "Acerca de";
            this.MenuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuAcercaDe.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // VistaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 698);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.MenuAdmin);
            this.Controls.Add(this.MenuLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private FontAwesome.Sharp.IconMenuItem MenuAcercaDe;
        private System.Windows.Forms.MenuStrip MenuLogo;
        private FontAwesome.Sharp.IconMenuItem MenuUser;
        private FontAwesome.Sharp.IconMenuItem MenuProd;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.ToolStripMenuItem SMCategoria;
        private System.Windows.Forms.ToolStripMenuItem SMProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

