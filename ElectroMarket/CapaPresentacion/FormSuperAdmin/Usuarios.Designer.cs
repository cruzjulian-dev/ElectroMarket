namespace CapaPresentacion
{
    partial class Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGUsuarios = new System.Windows.Forms.DataGridView();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CContra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaNacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ceditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TContra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.lEstado = new System.Windows.Forms.Label();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LRol = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TId = new System.Windows.Forms.TextBox();
            this.TIndice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(20, 319);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(180, 20);
            this.TTelefono.TabIndex = 16;
            this.TTelefono.TextChanged += new System.EventHandler(this.TTelefono_TextChanged);
            this.TTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TTelefono_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.BackColor = System.Drawing.Color.White;
            this.LTelefono.Location = new System.Drawing.Point(21, 303);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(52, 13);
            this.LTelefono.TabIndex = 52;
            this.LTelefono.Text = "Telefono:";
            // 
            // TUsuario
            // 
            this.TUsuario.Location = new System.Drawing.Point(20, 184);
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(180, 20);
            this.TUsuario.TabIndex = 13;
            this.TUsuario.TextChanged += new System.EventHandler(this.TUsuario_TextChanged);
            this.TUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DTFecha
            // 
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFecha.Location = new System.Drawing.Point(20, 272);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(180, 20);
            this.DTFecha.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Gestión de Usuarios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.BEditar.Location = new System.Drawing.Point(20, 516);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(180, 33);
            this.BEditar.TabIndex = 20;
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
            this.BGuardar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.BGuardar.IconColor = System.Drawing.Color.White;
            this.BGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGuardar.IconSize = 23;
            this.BGuardar.Location = new System.Drawing.Point(20, 477);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(180, 33);
            this.BGuardar.TabIndex = 19;
            this.BGuardar.Text = "Agregar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // TDomicilio
            // 
            this.TDomicilio.Location = new System.Drawing.Point(20, 360);
            this.TDomicilio.Name = "TDomicilio";
            this.TDomicilio.Size = new System.Drawing.Size(180, 20);
            this.TDomicilio.TabIndex = 17;
            this.TDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDomicilio_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(20, 100);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(180, 20);
            this.TApellido.TabIndex = 11;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(20, 141);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(180, 20);
            this.TDni.TabIndex = 12;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(20, 59);
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
            this.LFecha.Location = new System.Drawing.Point(21, 256);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(111, 13);
            this.LFecha.TabIndex = 42;
            this.LFecha.Text = "Fecha de Nacimiento:";
            // 
            // LDomicilio
            // 
            this.LDomicilio.AutoSize = true;
            this.LDomicilio.BackColor = System.Drawing.Color.White;
            this.LDomicilio.Location = new System.Drawing.Point(21, 344);
            this.LDomicilio.Name = "LDomicilio";
            this.LDomicilio.Size = new System.Drawing.Size(52, 13);
            this.LDomicilio.TabIndex = 40;
            this.LDomicilio.Text = "Domicilio:";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.White;
            this.LDni.Location = new System.Drawing.Point(21, 125);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(29, 13);
            this.LDni.TabIndex = 38;
            this.LDni.Text = "DNI:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(21, 84);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(47, 13);
            this.LApellido.TabIndex = 36;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(21, 43);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(47, 13);
            this.LNombre.TabIndex = 35;
            this.LNombre.Text = "Nombre:";
            this.LNombre.Click += new System.EventHandler(this.LNombre_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 561);
            this.label4.TabIndex = 51;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(321, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(794, 51);
            this.label3.TabIndex = 55;
            this.label3.Text = "Lista de Usuarios:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGUsuarios
            // 
            this.DGUsuarios.AllowUserToAddRows = false;
            this.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CApellido,
            this.CDni,
            this.CUsuario,
            this.CContra,
            this.CIdRol,
            this.CRol,
            this.CFechaNacim,
            this.CTelefono,
            this.CDomicilio,
            this.CEstadoValor,
            this.CEstado,
            this.CIdUsuario,
            this.Ceditar});
            this.DGUsuarios.Location = new System.Drawing.Point(317, 113);
            this.DGUsuarios.Name = "DGUsuarios";
            this.DGUsuarios.Size = new System.Drawing.Size(842, 373);
            this.DGUsuarios.TabIndex = 21;
            this.DGUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUsuarios_CellContentClick);
            this.DGUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGUsuarios_CellFormatting);
            this.DGUsuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGUsuarios_CellPainting);
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
            // CUsuario
            // 
            this.CUsuario.HeaderText = "Usuario";
            this.CUsuario.Name = "CUsuario";
            this.CUsuario.ReadOnly = true;
            this.CUsuario.Width = 80;
            // 
            // CContra
            // 
            this.CContra.HeaderText = "Contraseña";
            this.CContra.Name = "CContra";
            this.CContra.ReadOnly = true;
            // 
            // CIdRol
            // 
            this.CIdRol.HeaderText = "IdRol";
            this.CIdRol.Name = "CIdRol";
            this.CIdRol.Visible = false;
            // 
            // CRol
            // 
            this.CRol.HeaderText = "Rol";
            this.CRol.Name = "CRol";
            this.CRol.ReadOnly = true;
            // 
            // CFechaNacim
            // 
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.CFechaNacim.DefaultCellStyle = dataGridViewCellStyle8;
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
            // CEstadoValor
            // 
            this.CEstadoValor.HeaderText = "EstadoValor";
            this.CEstadoValor.Name = "CEstadoValor";
            this.CEstadoValor.ReadOnly = true;
            this.CEstadoValor.Visible = false;
            // 
            // CEstado
            // 
            this.CEstado.HeaderText = "Estado";
            this.CEstado.Name = "CEstado";
            this.CEstado.ReadOnly = true;
            // 
            // CIdUsuario
            // 
            this.CIdUsuario.HeaderText = "IdUsuario";
            this.CIdUsuario.Name = "CIdUsuario";
            this.CIdUsuario.Visible = false;
            // 
            // Ceditar
            // 
            this.Ceditar.HeaderText = "Editar";
            this.Ceditar.Name = "Ceditar";
            this.Ceditar.ReadOnly = true;
            // 
            // TContra
            // 
            this.TContra.Location = new System.Drawing.Point(20, 226);
            this.TContra.Name = "TContra";
            this.TContra.Size = new System.Drawing.Size(180, 20);
            this.TContra.TabIndex = 14;
            this.TContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TContra_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Contraseña:";
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.Color.White;
            this.CBEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(20, 450);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(180, 21);
            this.CBEstado.TabIndex = 18;
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.BackColor = System.Drawing.Color.White;
            this.lEstado.Location = new System.Drawing.Point(24, 434);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(43, 13);
            this.lEstado.TabIndex = 58;
            this.lEstado.Text = "Estado:";
            // 
            // CBRol
            // 
            this.CBRol.BackColor = System.Drawing.Color.White;
            this.CBRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(20, 402);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(180, 21);
            this.CBRol.TabIndex = 59;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.Color.White;
            this.LRol.Location = new System.Drawing.Point(24, 386);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(26, 13);
            this.LRol.TabIndex = 60;
            this.LRol.Text = "Rol:";
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
            this.iconButton2.Location = new System.Drawing.Point(1028, 45);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 33);
            this.iconButton2.TabIndex = 63;
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
            this.iconButton1.Location = new System.Drawing.Point(1069, 45);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 33);
            this.iconButton1.TabIndex = 64;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(922, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 62;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.BackColor = System.Drawing.Color.White;
            this.CBBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(830, 51);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(86, 21);
            this.CBBusqueda.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(762, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Buscar Por:";
            // 
            // TId
            // 
            this.TId.Location = new System.Drawing.Point(220, 51);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(33, 20);
            this.TId.TabIndex = 66;
            this.TId.Visible = false;
            // 
            // TIndice
            // 
            this.TIndice.Location = new System.Drawing.Point(220, 25);
            this.TIndice.Name = "TIndice";
            this.TIndice.Size = new System.Drawing.Size(33, 20);
            this.TIndice.TabIndex = 67;
            this.TIndice.Visible = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.TIndice);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.LRol);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.TContra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGUsuarios);
            this.Controls.Add(this.TTelefono);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.TUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTFecha);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.label4);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox TUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGUsuarios;
        private System.Windows.Forms.TextBox TContra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label LRol;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CContra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaNacim;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn Ceditar;
        private System.Windows.Forms.TextBox TIndice;
    }
}