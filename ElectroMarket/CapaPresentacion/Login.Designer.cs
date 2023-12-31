﻿namespace CapaPresentacion
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TUser = new System.Windows.Forms.TextBox();
            this.TContra = new System.Windows.Forms.TextBox();
            this.LUser = new System.Windows.Forms.Label();
            this.LContra = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BSalir = new FontAwesome.Sharp.IconButton();
            this.BIngresar = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lfechahoy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TUser
            // 
            this.TUser.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUser.Location = new System.Drawing.Point(32, 126);
            this.TUser.Multiline = true;
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(272, 25);
            this.TUser.TabIndex = 1;
            this.TUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TUser_KeyPress);
            // 
            // TContra
            // 
            this.TContra.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TContra.Location = new System.Drawing.Point(32, 187);
            this.TContra.Multiline = true;
            this.TContra.Name = "TContra";
            this.TContra.PasswordChar = '*';
            this.TContra.Size = new System.Drawing.Size(272, 25);
            this.TContra.TabIndex = 2;
            this.TContra.TextChanged += new System.EventHandler(this.TContra_TextChanged);
            this.TContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TContra_KeyPress);
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUser.Location = new System.Drawing.Point(34, 106);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(61, 16);
            this.LUser.TabIndex = 3;
            this.LUser.Text = "Usuario:";
            // 
            // LContra
            // 
            this.LContra.AutoSize = true;
            this.LContra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContra.Location = new System.Drawing.Point(34, 167);
            this.LContra.Name = "LContra";
            this.LContra.Size = new System.Drawing.Size(88, 16);
            this.LContra.TabIndex = 4;
            this.LContra.Text = "Contraseña:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(340, 84);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Red;
            this.BSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.ForeColor = System.Drawing.Color.White;
            this.BSalir.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.BSalir.IconColor = System.Drawing.Color.White;
            this.BSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BSalir.IconSize = 23;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(32, 232);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(75, 33);
            this.BSalir.TabIndex = 9;
            this.BSalir.Text = "&Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BIngresar
            // 
            this.BIngresar.BackColor = System.Drawing.Color.ForestGreen;
            this.BIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BIngresar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIngresar.ForeColor = System.Drawing.Color.White;
            this.BIngresar.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.BIngresar.IconColor = System.Drawing.Color.White;
            this.BIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BIngresar.IconSize = 23;
            this.BIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BIngresar.Location = new System.Drawing.Point(208, 232);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(96, 33);
            this.BIngresar.TabIndex = 8;
            this.BIngresar.Text = "Ingresar";
            this.BIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BIngresar.UseVisualStyleBackColor = false;
            this.BIngresar.Click += new System.EventHandler(this.BIngresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo_electromarket_blanco;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lhora
            // 
            this.Lhora.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lhora.ForeColor = System.Drawing.Color.Chocolate;
            this.Lhora.Location = new System.Drawing.Point(276, 99);
            this.Lhora.Name = "Lhora";
            this.Lhora.Size = new System.Drawing.Size(64, 18);
            this.Lhora.TabIndex = 10;
            this.Lhora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lfechahoy
            // 
            this.Lfechahoy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lfechahoy.ForeColor = System.Drawing.Color.Chocolate;
            this.Lfechahoy.Location = new System.Drawing.Point(253, 84);
            this.Lfechahoy.Name = "Lfechahoy";
            this.Lfechahoy.Size = new System.Drawing.Size(87, 18);
            this.Lfechahoy.TabIndex = 11;
            this.Lfechahoy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 288);
            this.ControlBox = false;
            this.Controls.Add(this.Lfechahoy);
            this.Controls.Add(this.Lhora);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BIngresar);
            this.Controls.Add(this.LContra);
            this.Controls.Add(this.LUser);
            this.Controls.Add(this.TContra);
            this.Controls.Add(this.TUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - ElectroMarket";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TUser;
        private System.Windows.Forms.TextBox TContra;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label LContra;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconButton BIngresar;
        private FontAwesome.Sharp.IconButton BSalir;
        private System.Windows.Forms.Label Lhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lfechahoy;
    }
}