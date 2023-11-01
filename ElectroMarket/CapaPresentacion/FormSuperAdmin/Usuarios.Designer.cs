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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TContra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.lEstado = new System.Windows.Forms.Label();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LRol = new System.Windows.Forms.Label();
            this.BBusqueda = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.TBusqueda = new System.Windows.Forms.TextBox();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TId = new System.Windows.Forms.TextBox();
            this.TIndice = new System.Windows.Forms.TextBox();
            this.BMostrarTodo = new FontAwesome.Sharp.IconButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TTelefono
            // 
            this.TTelefono.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTelefono.Location = new System.Drawing.Point(20, 311);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(180, 21);
            this.TTelefono.TabIndex = 16;
            this.TTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TTelefono_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.BackColor = System.Drawing.Color.White;
            this.LTelefono.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(21, 295);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(60, 13);
            this.LTelefono.TabIndex = 52;
            this.LTelefono.Text = "Telefono:";
            // 
            // TUsuario
            // 
            this.TUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUsuario.Location = new System.Drawing.Point(20, 184);
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(180, 21);
            this.TUsuario.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Usuario:";
            // 
            // DTFecha
            // 
            this.DTFecha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFecha.Location = new System.Drawing.Point(20, 269);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(180, 21);
            this.DTFecha.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Gestión de Usuarios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BEditar.Location = new System.Drawing.Point(20, 516);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(112, 33);
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
            this.BGuardar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TDomicilio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDomicilio.Location = new System.Drawing.Point(20, 354);
            this.TDomicilio.Name = "TDomicilio";
            this.TDomicilio.Size = new System.Drawing.Size(180, 21);
            this.TDomicilio.TabIndex = 17;
            this.TDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDomicilio_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TApellido.Location = new System.Drawing.Point(20, 100);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(180, 21);
            this.TApellido.TabIndex = 11;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TDni
            // 
            this.TDni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDni.Location = new System.Drawing.Point(20, 141);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(180, 21);
            this.TDni.TabIndex = 12;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.Location = new System.Drawing.Point(20, 59);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(180, 21);
            this.TNombre.TabIndex = 10;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.White;
            this.LFecha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.Location = new System.Drawing.Point(21, 253);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(130, 13);
            this.LFecha.TabIndex = 42;
            this.LFecha.Text = "Fecha de Nacimiento:";
            // 
            // LDomicilio
            // 
            this.LDomicilio.AutoSize = true;
            this.LDomicilio.BackColor = System.Drawing.Color.White;
            this.LDomicilio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDomicilio.Location = new System.Drawing.Point(21, 338);
            this.LDomicilio.Name = "LDomicilio";
            this.LDomicilio.Size = new System.Drawing.Size(64, 13);
            this.LDomicilio.TabIndex = 40;
            this.LDomicilio.Text = "Domicilio:";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.White;
            this.LDni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(21, 125);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(34, 13);
            this.LDni.TabIndex = 38;
            this.LDni.Text = "DNI:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.White;
            this.LApellido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(21, 84);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(57, 13);
            this.LApellido.TabIndex = 36;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.White;
            this.LNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(21, 43);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(57, 13);
            this.LNombre.TabIndex = 35;
            this.LNombre.Text = "Nombre:";
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
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(291, 32);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(881, 51);
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
            this.DGUsuarios.Location = new System.Drawing.Point(291, 113);
            this.DGUsuarios.Name = "DGUsuarios";
            this.DGUsuarios.Size = new System.Drawing.Size(881, 397);
            this.DGUsuarios.TabIndex = 21;
            this.DGUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUsuarios_CellContentClick);
            this.DGUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGUsuarios_CellFormatting);
            // 
            // TContra
            // 
            this.TContra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TContra.Location = new System.Drawing.Point(20, 226);
            this.TContra.Name = "TContra";
            this.TContra.Size = new System.Drawing.Size(180, 21);
            this.TContra.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Contraseña:";
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.Color.White;
            this.CBEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(20, 437);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(180, 21);
            this.CBEstado.TabIndex = 18;
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.BackColor = System.Drawing.Color.White;
            this.lEstado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.Location = new System.Drawing.Point(21, 421);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(50, 13);
            this.lEstado.TabIndex = 58;
            this.lEstado.Text = "Estado:";
            // 
            // CBRol
            // 
            this.CBRol.BackColor = System.Drawing.Color.White;
            this.CBRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(20, 393);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(180, 21);
            this.CBRol.TabIndex = 59;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.Color.White;
            this.LRol.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(21, 377);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(30, 13);
            this.LRol.TabIndex = 60;
            this.LRol.Text = "Rol:";
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
            this.BBusqueda.Location = new System.Drawing.Point(1077, 44);
            this.BBusqueda.Name = "BBusqueda";
            this.BBusqueda.Size = new System.Drawing.Size(35, 33);
            this.BBusqueda.TabIndex = 63;
            this.BBusqueda.UseVisualStyleBackColor = false;
            this.BBusqueda.Click += new System.EventHandler(this.BBusqueda_Click);
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
            this.iconButton1.Location = new System.Drawing.Point(140, 516);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(60, 33);
            this.iconButton1.TabIndex = 64;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            this.iconButton1.MouseHover += new System.EventHandler(this.iconButton1_MouseHover);
            // 
            // TBusqueda
            // 
            this.TBusqueda.BackColor = System.Drawing.Color.White;
            this.TBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusqueda.Location = new System.Drawing.Point(971, 50);
            this.TBusqueda.Name = "TBusqueda";
            this.TBusqueda.Size = new System.Drawing.Size(100, 21);
            this.TBusqueda.TabIndex = 62;
            this.TBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBusqueda_KeyPress);
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.BackColor = System.Drawing.Color.White;
            this.CBBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(879, 50);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(86, 21);
            this.CBBusqueda.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(799, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Buscar Por:";
            // 
            // TId
            // 
            this.TId.Location = new System.Drawing.Point(220, 77);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(33, 20);
            this.TId.TabIndex = 66;
            this.TId.Visible = false;
            // 
            // TIndice
            // 
            this.TIndice.Location = new System.Drawing.Point(220, 40);
            this.TIndice.Name = "TIndice";
            this.TIndice.Size = new System.Drawing.Size(33, 20);
            this.TIndice.TabIndex = 67;
            this.TIndice.Visible = false;
            // 
            // BMostrarTodo
            // 
            this.BMostrarTodo.BackColor = System.Drawing.Color.White;
            this.BMostrarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMostrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BMostrarTodo.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMostrarTodo.ForeColor = System.Drawing.Color.White;
            this.BMostrarTodo.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BMostrarTodo.IconColor = System.Drawing.Color.Black;
            this.BMostrarTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BMostrarTodo.IconSize = 23;
            this.BMostrarTodo.Location = new System.Drawing.Point(1118, 44);
            this.BMostrarTodo.Name = "BMostrarTodo";
            this.BMostrarTodo.Size = new System.Drawing.Size(35, 33);
            this.BMostrarTodo.TabIndex = 68;
            this.BMostrarTodo.UseVisualStyleBackColor = false;
            this.BMostrarTodo.Click += new System.EventHandler(this.BMostrarTodo_Click);
            this.BMostrarTodo.MouseHover += new System.EventHandler(this.BMostrarTodo_MouseHover);
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            this.CNombre.Width = 90;
            // 
            // CApellido
            // 
            this.CApellido.HeaderText = "Apellido";
            this.CApellido.Name = "CApellido";
            this.CApellido.ReadOnly = true;
            this.CApellido.Width = 90;
            // 
            // CDni
            // 
            this.CDni.HeaderText = "DNI";
            this.CDni.Name = "CDni";
            this.CDni.ReadOnly = true;
            this.CDni.Width = 70;
            // 
            // CUsuario
            // 
            this.CUsuario.HeaderText = "Usuario";
            this.CUsuario.Name = "CUsuario";
            this.CUsuario.ReadOnly = true;
            this.CUsuario.Width = 75;
            // 
            // CContra
            // 
            this.CContra.HeaderText = "Contraseña";
            this.CContra.Name = "CContra";
            this.CContra.ReadOnly = true;
            this.CContra.Visible = false;
            this.CContra.Width = 75;
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
            this.CRol.Width = 80;
            // 
            // CFechaNacim
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.CFechaNacim.DefaultCellStyle = dataGridViewCellStyle1;
            this.CFechaNacim.HeaderText = "Fecha de Nacimiento";
            this.CFechaNacim.Name = "CFechaNacim";
            this.CFechaNacim.ReadOnly = true;
            this.CFechaNacim.Width = 75;
            // 
            // CTelefono
            // 
            this.CTelefono.HeaderText = "Telefono";
            this.CTelefono.Name = "CTelefono";
            this.CTelefono.ReadOnly = true;
            this.CTelefono.Width = 75;
            // 
            // CDomicilio
            // 
            this.CDomicilio.HeaderText = "Domicilio";
            this.CDomicilio.Name = "CDomicilio";
            this.CDomicilio.ReadOnly = true;
            this.CDomicilio.Width = 90;
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
            this.CEstado.Width = 57;
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
            this.Ceditar.Width = 60;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.BMostrarTodo);
            this.Controls.Add(this.TIndice);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.BBusqueda);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.TBusqueda);
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
        private FontAwesome.Sharp.IconButton BBusqueda;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox TBusqueda;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TId;
        private System.Windows.Forms.TextBox TIndice;
        private FontAwesome.Sharp.IconButton BMostrarTodo;
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
    }
}