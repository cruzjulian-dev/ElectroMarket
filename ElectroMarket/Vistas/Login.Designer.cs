namespace ElectroMarket
{
    partial class formLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LContra = new System.Windows.Forms.Label();
            this.TUsuario = new System.Windows.Forms.TextBox();
            this.TContra = new System.Windows.Forms.TextBox();
            this.BIniciar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ElectroMarket.Properties.Resources.logo_electromarket;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(25, 125);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(46, 13);
            this.LUsuario.TabIndex = 1;
            this.LUsuario.Text = "Usuario:";
            // 
            // LContra
            // 
            this.LContra.AutoSize = true;
            this.LContra.Location = new System.Drawing.Point(25, 185);
            this.LContra.Name = "LContra";
            this.LContra.Size = new System.Drawing.Size(64, 13);
            this.LContra.TabIndex = 2;
            this.LContra.Text = "Contraseña:";
            // 
            // TUsuario
            // 
            this.TUsuario.Location = new System.Drawing.Point(114, 122);
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(215, 20);
            this.TUsuario.TabIndex = 3;
            this.TUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TContra
            // 
            this.TContra.Location = new System.Drawing.Point(114, 182);
            this.TContra.Name = "TContra";
            this.TContra.Size = new System.Drawing.Size(215, 20);
            this.TContra.TabIndex = 4;
            this.TContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TContra_KeyPress);
            // 
            // BIniciar
            // 
            this.BIniciar.Location = new System.Drawing.Point(231, 268);
            this.BIniciar.Name = "BIniciar";
            this.BIniciar.Size = new System.Drawing.Size(98, 23);
            this.BIniciar.TabIndex = 5;
            this.BIniciar.Text = "Iniciar Sesión";
            this.BIniciar.UseVisualStyleBackColor = true;
            this.BIniciar.Click += new System.EventHandler(this.BIniciar_Click);
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(28, 268);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(75, 23);
            this.BSalir.TabIndex = 6;
            this.BSalir.Text = "&Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 324);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BIniciar);
            this.Controls.Add(this.TContra);
            this.Controls.Add(this.TUsuario);
            this.Controls.Add(this.LContra);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formLogin";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LContra;
        private System.Windows.Forms.TextBox TUsuario;
        private System.Windows.Forms.TextBox TContra;
        private System.Windows.Forms.Button BIniciar;
        private System.Windows.Forms.Button BSalir;
    }
}

