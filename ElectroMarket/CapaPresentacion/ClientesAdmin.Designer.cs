namespace CapaPresentacion
{
    partial class ClientesAdmin
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
            this.BEditar = new FontAwesome.Sharp.IconButton();
            this.BGuardar = new FontAwesome.Sharp.IconButton();
            this.BEliminar = new FontAwesome.Sharp.IconButton();
            this.TDomicilio = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TFecha = new System.Windows.Forms.TextBox();
            this.TCorreo = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LDomicilio = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ceditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.DarkCyan;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEditar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.ForeColor = System.Drawing.Color.White;
            this.BEditar.IconChar = FontAwesome.Sharp.IconChar.EarthAmericas;
            this.BEditar.IconColor = System.Drawing.Color.White;
            this.BEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BEditar.IconSize = 23;
            this.BEditar.Location = new System.Drawing.Point(21, 465);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(180, 33);
            this.BEditar.TabIndex = 35;
            this.BEditar.Text = "Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BGuardar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.BGuardar.IconColor = System.Drawing.Color.White;
            this.BGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGuardar.IconSize = 23;
            this.BGuardar.Location = new System.Drawing.Point(21, 426);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(180, 33);
            this.BGuardar.TabIndex = 34;
            this.BGuardar.Text = "Agregar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.Red;
            this.BEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEliminar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.ForeColor = System.Drawing.Color.White;
            this.BEliminar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.BEliminar.IconColor = System.Drawing.Color.White;
            this.BEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BEliminar.IconSize = 23;
            this.BEliminar.Location = new System.Drawing.Point(21, 504);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(180, 33);
            this.BEliminar.TabIndex = 33;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEliminar.UseVisualStyleBackColor = false;
            this.BEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // TDomicilio
            // 
            this.TDomicilio.Location = new System.Drawing.Point(21, 381);
            this.TDomicilio.Name = "TDomicilio";
            this.TDomicilio.Size = new System.Drawing.Size(180, 20);
            this.TDomicilio.TabIndex = 32;
            this.TDomicilio.TextChanged += new System.EventHandler(this.TDomicilio_TextChanged);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(21, 153);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(180, 20);
            this.TApellido.TabIndex = 31;
            this.TApellido.TextChanged += new System.EventHandler(this.TApellido_TextChanged);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(21, 199);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(180, 20);
            this.TDni.TabIndex = 30;
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            // 
            // TFecha
            // 
            this.TFecha.Location = new System.Drawing.Point(21, 259);
            this.TFecha.Name = "TFecha";
            this.TFecha.Size = new System.Drawing.Size(180, 20);
            this.TFecha.TabIndex = 29;
            this.TFecha.TextChanged += new System.EventHandler(this.TFecha_TextChanged);
            // 
            // TCorreo
            // 
            this.TCorreo.Location = new System.Drawing.Point(21, 323);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(180, 20);
            this.TCorreo.TabIndex = 28;
            this.TCorreo.TextChanged += new System.EventHandler(this.TCorreo_TextChanged);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(21, 101);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(180, 20);
            this.TNombre.TabIndex = 27;
            this.TNombre.TextChanged += new System.EventHandler(this.TNombre_TextChanged);
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.BackColor = System.Drawing.Color.White;
            this.LCorreo.Location = new System.Drawing.Point(22, 308);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(38, 13);
            this.LCorreo.TabIndex = 26;
            this.LCorreo.Text = "Correo";
            this.LCorreo.Click += new System.EventHandler(this.LCorreo_Click);
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.White;
            this.LFecha.Location = new System.Drawing.Point(22, 243);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(108, 13);
            this.LFecha.TabIndex = 25;
            this.LFecha.Text = "Fecha de Nacimiento";
            this.LFecha.Click += new System.EventHandler(this.LFecha_Click);
            // 
            // LDomicilio
            // 
            this.LDomicilio.AutoSize = true;
            this.LDomicilio.BackColor = System.Drawing.Color.White;
            this.LDomicilio.Location = new System.Drawing.Point(22, 365);
            this.LDomicilio.Name = "LDomicilio";
            this.LDomicilio.Size = new System.Drawing.Size(49, 13);
            this.LDomicilio.TabIndex = 24;
            this.LDomicilio.Text = "Domicilio";
            this.LDomicilio.Click += new System.EventHandler(this.LDomicilio_Click);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.White;
            this.LDni.Location = new System.Drawing.Point(22, 183);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 23;
            this.LDni.Text = "DNI";
            this.LDni.Click += new System.EventHandler(this.LDni_Click);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(22, 137);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 22;
            this.LApellido.Text = "Apellido";
            this.LApellido.Click += new System.EventHandler(this.LApellido_Click);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(22, 85);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 21;
            this.LNombre.Text = "Nombre";
            this.LNombre.Click += new System.EventHandler(this.LNombre_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 561);
            this.label1.TabIndex = 37;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cliente
            // 
            this.Cliente.BackColor = System.Drawing.Color.White;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(61, 18);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(96, 30);
            this.Cliente.TabIndex = 38;
            this.Cliente.Text = "Clientes";
            this.Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 23;
            this.iconButton2.Location = new System.Drawing.Point(826, 57);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 33);
            this.iconButton2.TabIndex = 45;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 23;
            this.iconButton1.Location = new System.Drawing.Point(867, 57);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 33);
            this.iconButton1.TabIndex = 44;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(720, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(628, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 21);
            this.comboBox1.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(560, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Buscar Por:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(295, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(623, 51);
            this.label3.TabIndex = 40;
            this.label3.Text = "Lista de Clientes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.FechaNacim,
            this.Domicilio,
            this.Ccorreo,
            this.Ceditar});
            this.DGClientes.Location = new System.Drawing.Point(291, 125);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.Size = new System.Drawing.Size(671, 373);
            this.DGClientes.TabIndex = 39;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // FechaNacim
            // 
            this.FechaNacim.HeaderText = "Fecha de Nacimiento";
            this.FechaNacim.Name = "FechaNacim";
            this.FechaNacim.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // Ccorreo
            // 
            this.Ccorreo.HeaderText = "Correo";
            this.Ccorreo.Name = "Ccorreo";
            // 
            // Ceditar
            // 
            this.Ceditar.HeaderText = "Editar";
            this.Ceditar.Name = "Ceditar";
            // 
            // TId
            // 
            this.TId.Location = new System.Drawing.Point(65, 62);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(136, 20);
            this.TId.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "ID:";
            // 
            // ClientesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGClientes);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BEliminar);
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
            this.Controls.Add(this.label1);
            this.Name = "ClientesAdmin";
            this.Text = "ClientesAdmin";
            this.Load += new System.EventHandler(this.ClientesAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton BEditar;
        private FontAwesome.Sharp.IconButton BGuardar;
        private FontAwesome.Sharp.IconButton BEliminar;
        private System.Windows.Forms.TextBox TDomicilio;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TFecha;
        private System.Windows.Forms.TextBox TCorreo;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LDomicilio;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cliente;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccorreo;
        private System.Windows.Forms.DataGridViewButtonColumn Ceditar;
        private System.Windows.Forms.TextBox TId;
        private System.Windows.Forms.Label label2;
    }
}