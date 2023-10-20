namespace CapaPresentacion
{
    partial class ProductosAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lNombre = new System.Windows.Forms.Label();
            this.codigoProd = new System.Windows.Forms.Label();
            this.lDescrip = new System.Windows.Forms.Label();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lEstado = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TDescripcion = new System.Windows.Forms.TextBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGProductos = new System.Windows.Forms.DataGridView();
            this.Ccodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CestadoVAlor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ceditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.BEditar = new FontAwesome.Sharp.IconButton();
            this.BGuardar = new FontAwesome.Sharp.IconButton();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.TBusqueda = new System.Windows.Forms.TextBox();
            this.BMostrar = new FontAwesome.Sharp.IconButton();
            this.BBuscar = new FontAwesome.Sharp.IconButton();
            this.TPrecio = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.Label();
            this.TStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.TIndice = new System.Windows.Forms.TextBox();
            this.BLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.BackColor = System.Drawing.Color.White;
            this.lNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(34, 125);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(61, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre: ";
            // 
            // codigoProd
            // 
            this.codigoProd.AutoSize = true;
            this.codigoProd.BackColor = System.Drawing.Color.White;
            this.codigoProd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.codigoProd.Location = new System.Drawing.Point(34, 81);
            this.codigoProd.Name = "codigoProd";
            this.codigoProd.Size = new System.Drawing.Size(106, 13);
            this.codigoProd.TabIndex = 1;
            this.codigoProd.Text = "Codigo Producto:";
            // 
            // lDescrip
            // 
            this.lDescrip.AutoSize = true;
            this.lDescrip.BackColor = System.Drawing.Color.White;
            this.lDescrip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescrip.Location = new System.Drawing.Point(34, 172);
            this.lDescrip.Name = "lDescrip";
            this.lDescrip.Size = new System.Drawing.Size(78, 13);
            this.lDescrip.TabIndex = 2;
            this.lDescrip.Text = "Descripción:";
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.BackColor = System.Drawing.Color.White;
            this.lCategoria.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCategoria.Location = new System.Drawing.Point(39, 309);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(68, 13);
            this.lCategoria.TabIndex = 3;
            this.lCategoria.Text = "Categoria:";
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.BackColor = System.Drawing.Color.White;
            this.lEstado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.Location = new System.Drawing.Point(39, 356);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(50, 13);
            this.lEstado.TabIndex = 4;
            this.lEstado.Text = "Estado:";
            // 
            // Codigo
            // 
            this.Codigo.BackColor = System.Drawing.Color.White;
            this.Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Codigo.Enabled = false;
            this.Codigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.ForeColor = System.Drawing.Color.White;
            this.Codigo.Location = new System.Drawing.Point(32, 97);
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Size = new System.Drawing.Size(91, 21);
            this.Codigo.TabIndex = 10;
            this.Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodprod_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.Color.White;
            this.TNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.Location = new System.Drawing.Point(32, 141);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(180, 21);
            this.TNombre.TabIndex = 11;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // TDescripcion
            // 
            this.TDescripcion.BackColor = System.Drawing.Color.White;
            this.TDescripcion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDescripcion.Location = new System.Drawing.Point(32, 188);
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.Size = new System.Drawing.Size(180, 21);
            this.TDescripcion.TabIndex = 12;
            this.TDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // CBCategoria
            // 
            this.CBCategoria.BackColor = System.Drawing.Color.White;
            this.CBCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Aires Acondicionados",
            "Heladeras",
            "Lavarropas",
            "Televisores",
            "Hornos",
            "Microondas"});
            this.CBCategoria.Location = new System.Drawing.Point(32, 325);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(180, 21);
            this.CBCategoria.TabIndex = 15;
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.Color.White;
            this.CBEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(32, 372);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(180, 21);
            this.CBEstado.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 561);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gestión de Productos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToAddRows = false;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ccodigo,
            this.Cnombre,
            this.Cdescripcion,
            this.cprecio,
            this.CStock,
            this.idCat,
            this.Ccategoria,
            this.Cestado,
            this.CestadoVAlor,
            this.Ceditar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGProductos.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGProductos.Location = new System.Drawing.Point(298, 117);
            this.DGProductos.MultiSelect = false;
            this.DGProductos.Name = "DGProductos";
            this.DGProductos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGProductos.RowTemplate.Height = 28;
            this.DGProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProductos.Size = new System.Drawing.Size(842, 390);
            this.DGProductos.TabIndex = 23;
            this.DGProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridProd_CellContentClick);
            this.DGProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGProductos_CellFormatting);
            // 
            // Ccodigo
            // 
            this.Ccodigo.HeaderText = "Codigo";
            this.Ccodigo.Name = "Ccodigo";
            this.Ccodigo.ReadOnly = true;
            this.Ccodigo.Width = 70;
            // 
            // Cnombre
            // 
            this.Cnombre.HeaderText = "Nombre";
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            // 
            // Cdescripcion
            // 
            this.Cdescripcion.HeaderText = "Descripcion";
            this.Cdescripcion.Name = "Cdescripcion";
            this.Cdescripcion.ReadOnly = true;
            // 
            // cprecio
            // 
            this.cprecio.HeaderText = "Precio ";
            this.cprecio.Name = "cprecio";
            this.cprecio.ReadOnly = true;
            // 
            // CStock
            // 
            this.CStock.HeaderText = "Stock";
            this.CStock.Name = "CStock";
            this.CStock.ReadOnly = true;
            this.CStock.Width = 80;
            // 
            // idCat
            // 
            this.idCat.HeaderText = "idCategoria";
            this.idCat.Name = "idCat";
            this.idCat.ReadOnly = true;
            this.idCat.Visible = false;
            // 
            // Ccategoria
            // 
            this.Ccategoria.HeaderText = "Categoria";
            this.Ccategoria.Name = "Ccategoria";
            this.Ccategoria.ReadOnly = true;
            // 
            // Cestado
            // 
            this.Cestado.HeaderText = "Estado";
            this.Cestado.Name = "Cestado";
            this.Cestado.ReadOnly = true;
            this.Cestado.Width = 80;
            // 
            // CestadoVAlor
            // 
            this.CestadoVAlor.HeaderText = "EstadoValor";
            this.CestadoVAlor.Name = "CestadoVAlor";
            this.CestadoVAlor.ReadOnly = true;
            this.CestadoVAlor.Visible = false;
            // 
            // Ceditar
            // 
            this.Ceditar.HeaderText = "Editar";
            this.Ceditar.Name = "Ceditar";
            this.Ceditar.ReadOnly = true;
            this.Ceditar.Width = 75;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(293, 34);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(847, 51);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lista de Productos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.DarkCyan;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEditar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.ForeColor = System.Drawing.Color.White;
            this.BEditar.IconChar = FontAwesome.Sharp.IconChar.EarthAmericas;
            this.BEditar.IconColor = System.Drawing.Color.White;
            this.BEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BEditar.IconSize = 23;
            this.BEditar.Location = new System.Drawing.Point(32, 460);
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
            this.BGuardar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.BGuardar.IconColor = System.Drawing.Color.White;
            this.BGuardar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.BGuardar.IconSize = 23;
            this.BGuardar.Location = new System.Drawing.Point(32, 421);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(180, 33);
            this.BGuardar.TabIndex = 17;
            this.BGuardar.Text = "Agregar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(772, 56);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(74, 13);
            this.lblBuscar.TabIndex = 21;
            this.lblBuscar.Text = "Buscar Por:";
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.BackColor = System.Drawing.Color.White;
            this.CBBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(852, 52);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(86, 21);
            this.CBBusqueda.TabIndex = 19;
            // 
            // TBusqueda
            // 
            this.TBusqueda.BackColor = System.Drawing.Color.White;
            this.TBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusqueda.Location = new System.Drawing.Point(944, 53);
            this.TBusqueda.Name = "TBusqueda";
            this.TBusqueda.Size = new System.Drawing.Size(100, 21);
            this.TBusqueda.TabIndex = 20;
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
            this.BMostrar.Location = new System.Drawing.Point(1091, 45);
            this.BMostrar.Name = "BMostrar";
            this.BMostrar.Size = new System.Drawing.Size(35, 33);
            this.BMostrar.TabIndex = 22;
            this.BMostrar.UseVisualStyleBackColor = false;
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.White;
            this.BBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BBuscar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.BBuscar.IconColor = System.Drawing.Color.Black;
            this.BBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BBuscar.IconSize = 23;
            this.BBuscar.Location = new System.Drawing.Point(1050, 45);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(35, 33);
            this.BBuscar.TabIndex = 21;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // TPrecio
            // 
            this.TPrecio.BackColor = System.Drawing.Color.White;
            this.TPrecio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPrecio.Location = new System.Drawing.Point(32, 233);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.Size = new System.Drawing.Size(180, 21);
            this.TPrecio.TabIndex = 13;
            this.TPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.BackColor = System.Drawing.Color.White;
            this.Precio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.Location = new System.Drawing.Point(39, 217);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(47, 13);
            this.Precio.TabIndex = 27;
            this.Precio.Text = "Precio:";
            // 
            // TStock
            // 
            this.TStock.BackColor = System.Drawing.Color.White;
            this.TStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TStock.Location = new System.Drawing.Point(32, 279);
            this.TStock.Name = "TStock";
            this.TStock.Size = new System.Drawing.Size(180, 21);
            this.TStock.TabIndex = 14;
            this.TStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.White;
            this.lblStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(39, 263);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(44, 13);
            this.lblStock.TabIndex = 29;
            this.lblStock.Text = "Stock:";
            // 
            // TIndice
            // 
            this.TIndice.Location = new System.Drawing.Point(222, 65);
            this.TIndice.Name = "TIndice";
            this.TIndice.Size = new System.Drawing.Size(26, 20);
            this.TIndice.TabIndex = 30;
            this.TIndice.Visible = false;
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
            this.BLimpiar.Location = new System.Drawing.Point(32, 499);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(180, 33);
            this.BLimpiar.TabIndex = 66;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // ProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.TIndice);
            this.Controls.Add(this.TStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.TPrecio);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.BMostrar);
            this.Controls.Add(this.TBusqueda);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.TDescripcion);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.lCategoria);
            this.Controls.Add(this.lDescrip);
            this.Controls.Add(this.codigoProd);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.label1);
            this.Name = "ProductosAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.AgregarProcucto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label codigoProd;
        private System.Windows.Forms.Label lDescrip;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TDescripcion;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BGuardar;
        private FontAwesome.Sharp.IconButton BEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton BMostrar;
        private FontAwesome.Sharp.IconButton BBuscar;
        private System.Windows.Forms.TextBox TPrecio;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox TStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox TIndice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CestadoVAlor;
        private System.Windows.Forms.DataGridViewButtonColumn Ceditar;
        private FontAwesome.Sharp.IconButton BLimpiar;
    }
}