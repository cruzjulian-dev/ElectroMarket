namespace CapaPresentacion
{
    partial class AgregarCliente
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
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LDomicilio = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TCorreo = new System.Windows.Forms.TextBox();
            this.TFecha = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TDomicilio = new System.Windows.Forms.TextBox();
            this.BAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(118, 28);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(118, 92);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(118, 150);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            // 
            // LDomicilio
            // 
            this.LDomicilio.AutoSize = true;
            this.LDomicilio.Location = new System.Drawing.Point(363, 150);
            this.LDomicilio.Name = "LDomicilio";
            this.LDomicilio.Size = new System.Drawing.Size(49, 13);
            this.LDomicilio.TabIndex = 3;
            this.LDomicilio.Text = "Domicilio";
            this.LDomicilio.Click += new System.EventHandler(this.label4_Click);
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(363, 28);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(108, 13);
            this.LFecha.TabIndex = 4;
            this.LFecha.Text = "Fecha de Nacimiento";
            this.LFecha.Click += new System.EventHandler(this.label5_Click);
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Location = new System.Drawing.Point(363, 93);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(38, 13);
            this.LCorreo.TabIndex = 5;
            this.LCorreo.Text = "Correo";
            this.LCorreo.Click += new System.EventHandler(this.label6_Click);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(117, 44);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(160, 20);
            this.TNombre.TabIndex = 6;
            // 
            // TCorreo
            // 
            this.TCorreo.Location = new System.Drawing.Point(362, 108);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(160, 20);
            this.TCorreo.TabIndex = 7;
            this.TCorreo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TFecha
            // 
            this.TFecha.Location = new System.Drawing.Point(362, 44);
            this.TFecha.Name = "TFecha";
            this.TFecha.Size = new System.Drawing.Size(160, 20);
            this.TFecha.TabIndex = 8;
            this.TFecha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(117, 166);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(160, 20);
            this.TDni.TabIndex = 9;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(117, 108);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(160, 20);
            this.TApellido.TabIndex = 10;
            // 
            // TDomicilio
            // 
            this.TDomicilio.Location = new System.Drawing.Point(362, 166);
            this.TDomicilio.Name = "TDomicilio";
            this.TDomicilio.Size = new System.Drawing.Size(160, 20);
            this.TDomicilio.TabIndex = 11;
            this.TDomicilio.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // BAgregar
            // 
            this.BAgregar.Location = new System.Drawing.Point(275, 230);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(75, 23);
            this.BAgregar.TabIndex = 12;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 155);
            this.dataGridView1.TabIndex = 13;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.TDomicilio);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.TFecha);
            this.Controls.Add(this.TCorreo);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.LCorreo);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LDomicilio);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LDomicilio;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TCorreo;
        private System.Windows.Forms.TextBox TFecha;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TDomicilio;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}