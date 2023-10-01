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
            this.TDomicilio = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.LDomicilio = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.TBusqueda = new System.Windows.Forms.TextBox();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGClientes = new System.Windows.Forms.DataGridView();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.lEstado = new System.Windows.Forms.Label();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaNacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ceditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIndice = new System.Windows.Forms.TextBox();
            this.TId = new System.Windows.Forms.TextBox();
            this.BLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.DarkCyan;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEditar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.ForeColor = System.Drawing.Color.White;
            this.BEditar.IconChar = FontAwesome.Sharp.IconChar.EarthAmericas;
            this.BEditar.IconColor = System.Drawing.Color.White;
            this.BEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BEditar.IconSize = 23;
            this.BEditar.Location = new System.Drawing.Point(21, 459);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(180, 33);
            this.BEditar.TabIndex = 18;
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
            this.BGuardar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.BGuardar.IconColor = System.Drawing.Color.White;
            this.BGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGuardar.IconSize = 23;
            this.BGuardar.Location = new System.Drawing.Point(21, 420);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(180, 33);
            this.BGuardar.TabIndex = 17;
            this.BGuardar.Text = "Agregar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TDomicilio
            // 
            this.TDomicilio.Location = new System.Drawing.Point(22, 323);
            this.TDomicilio.Name = "TDomicilio";
            this.TDomicilio.Size = new System.Drawing.Size(180, 20);
            this.TDomicilio.TabIndex = 15;
            this.TDomicilio.TextChanged += new System.EventHandler(this.TDomicilio_TextChanged);
            this.TDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDomicilio_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(21, 131);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(180, 20);
            this.TApellido.TabIndex = 11;
            this.TApellido.TextChanged += new System.EventHandler(this.TApellido_TextChanged);
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(21, 178);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(180, 20);
            this.TDni.TabIndex = 12;
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(22, 83);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(180, 20);
            this.TNombre.TabIndex = 10;
            this.TNombre.TextChanged += new System.EventHandler(this.TNombre_TextChanged);
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.White;
            this.LFecha.Location = new System.Drawing.Point(22, 211);
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
            this.LDomicilio.Location = new System.Drawing.Point(22, 307);
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
            this.LDni.Location = new System.Drawing.Point(22, 162);
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
            this.LApellido.Location = new System.Drawing.Point(22, 115);
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
            this.LNombre.Location = new System.Drawing.Point(23, 67);
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
            this.iconButton2.Location = new System.Drawing.Point(987, 57);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 33);
            this.iconButton2.TabIndex = 21;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 23;
            this.iconButton1.Location = new System.Drawing.Point(1028, 57);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 33);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // TBusqueda
            // 
            this.TBusqueda.BackColor = System.Drawing.Color.White;
            this.TBusqueda.Location = new System.Drawing.Point(881, 63);
            this.TBusqueda.Name = "TBusqueda";
            this.TBusqueda.Size = new System.Drawing.Size(100, 20);
            this.TBusqueda.TabIndex = 20;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.BackColor = System.Drawing.Color.White;
            this.CBBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(789, 63);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(86, 21);
            this.CBBusqueda.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(721, 67);
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
            this.label3.Size = new System.Drawing.Size(777, 51);
            this.label3.TabIndex = 40;
            this.label3.Text = "Lista de Clientes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CApellido,
            this.Cdni,
            this.CFechaNacim,
            this.CTelefono,
            this.CDomicilio,
            this.Cestado,
            this.Ceditar,
            this.CIdCliente});
            this.DGClientes.Location = new System.Drawing.Point(300, 137);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.Size = new System.Drawing.Size(861, 373);
            this.DGClientes.TabIndex = 23;
            this.DGClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGClientes_CellContentClick);
            this.DGClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGClientes_CellFormatting);
            this.DGClientes.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DGClientes_RowPrePaint);
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.Color.White;
            this.CBEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(21, 371);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(180, 21);
            this.CBEstado.TabIndex = 16;
            this.CBEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.BackColor = System.Drawing.Color.White;
            this.lEstado.Location = new System.Drawing.Point(22, 355);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(43, 13);
            this.lEstado.TabIndex = 48;
            this.lEstado.Text = "Estado:";
            this.lEstado.Click += new System.EventHandler(this.lEstado_Click);
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(21, 276);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(180, 20);
            this.TTelefono.TabIndex = 14;
            this.TTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ttel_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.BackColor = System.Drawing.Color.White;
            this.LTelefono.Location = new System.Drawing.Point(22, 260);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(52, 13);
            this.LTelefono.TabIndex = 51;
            this.LTelefono.Text = "Telefono:";
            // 
            // DTFecha
            // 
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFecha.Location = new System.Drawing.Point(21, 227);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(136, 20);
            this.DTFecha.TabIndex = 13;
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CApellido
            // 
            this.CApellido.HeaderText = "Apellido";
            this.CApellido.Name = "CApellido";
            this.CApellido.ReadOnly = true;
            // 
            // Cdni
            // 
            this.Cdni.HeaderText = "DNI";
            this.Cdni.Name = "Cdni";
            this.Cdni.ReadOnly = true;
            // 
            // CFechaNacim
            // 
            this.CFechaNacim.HeaderText = "Fecha de Nacimiento";
            this.CFechaNacim.Name = "CFechaNacim";
            this.CFechaNacim.ReadOnly = true;
            // 
            // CTelefono
            // 
            this.CTelefono.HeaderText = "Telefono";
            this.CTelefono.Name = "CTelefono";
            this.CTelefono.ReadOnly = true;
            // 
            // CDomicilio
            // 
            this.CDomicilio.HeaderText = "Domicilio";
            this.CDomicilio.Name = "CDomicilio";
            this.CDomicilio.ReadOnly = true;
            // 
            // Cestado
            // 
            this.Cestado.HeaderText = "Estado";
            this.Cestado.Name = "Cestado";
            this.Cestado.ReadOnly = true;
            // 
            // Ceditar
            // 
            this.Ceditar.HeaderText = "Editar";
            this.Ceditar.Name = "Ceditar";
            this.Ceditar.ReadOnly = true;
            // 
            // CIdCliente
            // 
            this.CIdCliente.HeaderText = "IdCliente";
            this.CIdCliente.Name = "CIdCliente";
            this.CIdCliente.Visible = false;
            // 
            // TIndice
            // 
            this.TIndice.Location = new System.Drawing.Point(210, 18);
            this.TIndice.Name = "TIndice";
            this.TIndice.Size = new System.Drawing.Size(28, 20);
            this.TIndice.TabIndex = 52;
            this.TIndice.Visible = false;
            // 
            // TId
            // 
            this.TId.Location = new System.Drawing.Point(210, 44);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(28, 20);
            this.TId.TabIndex = 53;
            this.TId.Visible = false;
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.White;
            this.BLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BLimpiar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BLimpiar.IconColor = System.Drawing.Color.Black;
            this.BLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BLimpiar.IconSize = 23;
            this.BLimpiar.Location = new System.Drawing.Point(21, 498);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(180, 33);
            this.BLimpiar.TabIndex = 65;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // ClientesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.TIndice);
            this.Controls.Add(this.DTFecha);
            this.Controls.Add(this.TTelefono);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.TBusqueda);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGClientes);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.TDomicilio);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.TNombre);
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
        private System.Windows.Forms.TextBox TDomicilio;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LDomicilio;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cliente;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox TBusqueda;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGClientes;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaNacim;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cestado;
        private System.Windows.Forms.DataGridViewButtonColumn Ceditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdCliente;
        private System.Windows.Forms.TextBox TIndice;
        private System.Windows.Forms.TextBox TId;
        private FontAwesome.Sharp.IconButton BLimpiar;
    }
}