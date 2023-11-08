namespace CapaPresentacion
{
    partial class ClientesVendedor
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
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TDomicilio = new System.Windows.Forms.TextBox();
            this.DGClientes = new System.Windows.Forms.DataGridView();
            this.CIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaNacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ceditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.TBusqueda = new System.Windows.Forms.TextBox();
            this.BMostrar = new FontAwesome.Sharp.IconButton();
            this.BBusqueda = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.BEditar = new FontAwesome.Sharp.IconButton();
            this.BGuardar = new FontAwesome.Sharp.IconButton();
            this.Ttel = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.BLimpiar = new FontAwesome.Sharp.IconButton();
            this.TIdCliente = new System.Windows.Forms.TextBox();
            this.TIndice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.White;
            this.LNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(42, 95);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(57, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.White;
            this.LApellido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(42, 137);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(57, 13);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.White;
            this.LDni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(42, 182);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(34, 13);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI:";
            // 
            // LDomicilio
            // 
            this.LDomicilio.AutoSize = true;
            this.LDomicilio.BackColor = System.Drawing.Color.White;
            this.LDomicilio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDomicilio.Location = new System.Drawing.Point(42, 314);
            this.LDomicilio.Name = "LDomicilio";
            this.LDomicilio.Size = new System.Drawing.Size(64, 13);
            this.LDomicilio.TabIndex = 3;
            this.LDomicilio.Text = "Domicilio:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.White;
            this.LFecha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.Location = new System.Drawing.Point(42, 227);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(130, 13);
            this.LFecha.TabIndex = 4;
            this.LFecha.Text = "Fecha de Nacimiento:";
            // 
            // TNombre
            // 
            this.TNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.Location = new System.Drawing.Point(41, 111);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(180, 21);
            this.TNombre.TabIndex = 10;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // TDni
            // 
            this.TDni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDni.Location = new System.Drawing.Point(41, 198);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(180, 21);
            this.TDni.TabIndex = 12;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TApellido.Location = new System.Drawing.Point(41, 153);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(180, 21);
            this.TApellido.TabIndex = 11;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TDomicilio
            // 
            this.TDomicilio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDomicilio.Location = new System.Drawing.Point(41, 330);
            this.TDomicilio.Name = "TDomicilio";
            this.TDomicilio.Size = new System.Drawing.Size(180, 21);
            this.TDomicilio.TabIndex = 15;
            this.TDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDomicilio_KeyPress);
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdCliente,
            this.CNombre,
            this.CApellido,
            this.CDni,
            this.CFechaNacim,
            this.CTelefono,
            this.CDomicilio,
            this.Ceditar});
            this.DGClientes.Location = new System.Drawing.Point(292, 120);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.Size = new System.Drawing.Size(843, 373);
            this.DGClientes.TabIndex = 22;
            this.DGClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCliente_CellContentClick);
            // 
            // CIdCliente
            // 
            this.CIdCliente.HeaderText = "IdCliente";
            this.CIdCliente.Name = "CIdCliente";
            this.CIdCliente.Visible = false;
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
            // CDni
            // 
            this.CDni.HeaderText = "DNI";
            this.CDni.Name = "CDni";
            this.CDni.ReadOnly = true;
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
            // Ceditar
            // 
            this.Ceditar.HeaderText = "Editar";
            this.Ceditar.Name = "Ceditar";
            this.Ceditar.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Gestión de Clientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DTFecha
            // 
            this.DTFecha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFecha.Location = new System.Drawing.Point(41, 243);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(180, 21);
            this.DTFecha.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(296, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(839, 51);
            this.label3.TabIndex = 27;
            this.label3.Text = "Lista de Clientes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(772, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Buscar Por:";
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.BackColor = System.Drawing.Color.White;
            this.CBBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(852, 57);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(86, 21);
            this.CBBusqueda.TabIndex = 18;
            // 
            // TBusqueda
            // 
            this.TBusqueda.BackColor = System.Drawing.Color.White;
            this.TBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusqueda.Location = new System.Drawing.Point(944, 57);
            this.TBusqueda.Name = "TBusqueda";
            this.TBusqueda.Size = new System.Drawing.Size(100, 21);
            this.TBusqueda.TabIndex = 19;
            // 
            // BMostrar
            // 
            this.BMostrar.BackColor = System.Drawing.Color.White;
            this.BMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BMostrar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMostrar.ForeColor = System.Drawing.Color.White;
            this.BMostrar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BMostrar.IconColor = System.Drawing.Color.Black;
            this.BMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BMostrar.IconSize = 23;
            this.BMostrar.Location = new System.Drawing.Point(1091, 51);
            this.BMostrar.Name = "BMostrar";
            this.BMostrar.Size = new System.Drawing.Size(35, 33);
            this.BMostrar.TabIndex = 21;
            this.BMostrar.UseVisualStyleBackColor = false;
            this.BMostrar.Click += new System.EventHandler(this.BMostrar_Click);
            // 
            // BBusqueda
            // 
            this.BBusqueda.BackColor = System.Drawing.Color.White;
            this.BBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BBusqueda.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBusqueda.ForeColor = System.Drawing.Color.White;
            this.BBusqueda.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.BBusqueda.IconColor = System.Drawing.Color.Black;
            this.BBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BBusqueda.IconSize = 23;
            this.BBusqueda.Location = new System.Drawing.Point(1050, 51);
            this.BBusqueda.Name = "BBusqueda";
            this.BBusqueda.Size = new System.Drawing.Size(35, 33);
            this.BBusqueda.TabIndex = 20;
            this.BBusqueda.UseVisualStyleBackColor = false;
            this.BBusqueda.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 561);
            this.label4.TabIndex = 33;
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.DarkCyan;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEditar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.ForeColor = System.Drawing.Color.White;
            this.BEditar.IconChar = FontAwesome.Sharp.IconChar.EarthAmericas;
            this.BEditar.IconColor = System.Drawing.Color.White;
            this.BEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BEditar.IconSize = 23;
            this.BEditar.Location = new System.Drawing.Point(41, 429);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(180, 33);
            this.BEditar.TabIndex = 17;
            this.BEditar.Text = "Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BGuardar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.BGuardar.IconColor = System.Drawing.Color.White;
            this.BGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGuardar.IconSize = 23;
            this.BGuardar.Location = new System.Drawing.Point(41, 390);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(180, 33);
            this.BGuardar.TabIndex = 16;
            this.BGuardar.Text = "Agregar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // Ttel
            // 
            this.Ttel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ttel.Location = new System.Drawing.Point(41, 287);
            this.Ttel.Name = "Ttel";
            this.Ttel.Size = new System.Drawing.Size(180, 21);
            this.Ttel.TabIndex = 14;
            this.Ttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ttel_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.BackColor = System.Drawing.Color.White;
            this.LTelefono.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(42, 271);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(60, 13);
            this.LTelefono.TabIndex = 34;
            this.LTelefono.Text = "Telefono:";
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.White;
            this.BLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BLimpiar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BLimpiar.IconColor = System.Drawing.Color.Black;
            this.BLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BLimpiar.IconSize = 23;
            this.BLimpiar.Location = new System.Drawing.Point(41, 468);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(180, 33);
            this.BLimpiar.TabIndex = 66;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // TIdCliente
            // 
            this.TIdCliente.Location = new System.Drawing.Point(160, 85);
            this.TIdCliente.Name = "TIdCliente";
            this.TIdCliente.Size = new System.Drawing.Size(33, 20);
            this.TIdCliente.TabIndex = 67;
            this.TIdCliente.Visible = false;
            // 
            // TIndice
            // 
            this.TIndice.Location = new System.Drawing.Point(199, 85);
            this.TIndice.Name = "TIndice";
            this.TIndice.Size = new System.Drawing.Size(33, 20);
            this.TIndice.TabIndex = 68;
            this.TIndice.Visible = false;
            // 
            // ClientesVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.TIndice);
            this.Controls.Add(this.TIdCliente);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.Ttel);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.BBusqueda);
            this.Controls.Add(this.BMostrar);
            this.Controls.Add(this.TBusqueda);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.DGClientes);
            this.Controls.Add(this.TDomicilio);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LDomicilio);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.label4);
            this.Name = "ClientesVendedor";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LDomicilio;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TDomicilio;
        private System.Windows.Forms.DataGridView DGClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton BMostrar;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton BEditar;
        private FontAwesome.Sharp.IconButton BGuardar;
        private System.Windows.Forms.TextBox Ttel;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaNacim;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDomicilio;
        private System.Windows.Forms.DataGridViewButtonColumn Ceditar;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private System.Windows.Forms.TextBox TIdCliente;
        private System.Windows.Forms.TextBox TIndice;
    }
}