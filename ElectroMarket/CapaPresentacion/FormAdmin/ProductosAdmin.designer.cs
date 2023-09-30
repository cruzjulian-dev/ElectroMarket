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
            this.TCodProd = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TDescripcion = new System.Windows.Forms.TextBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridProd = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.icoBtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.icoBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TPrecio = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.Label();
            this.TStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.Ccodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CestadoVAlor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ceditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.BackColor = System.Drawing.Color.White;
            this.lNombre.Location = new System.Drawing.Point(34, 125);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(50, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre: ";
            // 
            // codigoProd
            // 
            this.codigoProd.AutoSize = true;
            this.codigoProd.BackColor = System.Drawing.Color.White;
            this.codigoProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.codigoProd.Location = new System.Drawing.Point(34, 81);
            this.codigoProd.Name = "codigoProd";
            this.codigoProd.Size = new System.Drawing.Size(89, 13);
            this.codigoProd.TabIndex = 1;
            this.codigoProd.Text = "Codigo Producto:";
            // 
            // lDescrip
            // 
            this.lDescrip.AutoSize = true;
            this.lDescrip.BackColor = System.Drawing.Color.White;
            this.lDescrip.Location = new System.Drawing.Point(34, 172);
            this.lDescrip.Name = "lDescrip";
            this.lDescrip.Size = new System.Drawing.Size(66, 13);
            this.lDescrip.TabIndex = 2;
            this.lDescrip.Text = "Descripcion:";
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.BackColor = System.Drawing.Color.White;
            this.lCategoria.Location = new System.Drawing.Point(39, 309);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(55, 13);
            this.lCategoria.TabIndex = 3;
            this.lCategoria.Text = "Categoria:";
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.BackColor = System.Drawing.Color.White;
            this.lEstado.Location = new System.Drawing.Point(39, 356);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(43, 13);
            this.lEstado.TabIndex = 4;
            this.lEstado.Text = "Estado:";
            // 
            // TCodProd
            // 
            this.TCodProd.BackColor = System.Drawing.Color.White;
            this.TCodProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCodProd.Location = new System.Drawing.Point(32, 97);
            this.TCodProd.Name = "TCodProd";
            this.TCodProd.Size = new System.Drawing.Size(180, 20);
            this.TCodProd.TabIndex = 10;
            this.TCodProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodprod_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.Color.White;
            this.TNombre.Location = new System.Drawing.Point(32, 141);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(180, 20);
            this.TNombre.TabIndex = 11;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // TDescripcion
            // 
            this.TDescripcion.BackColor = System.Drawing.Color.White;
            this.TDescripcion.Location = new System.Drawing.Point(32, 188);
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.Size = new System.Drawing.Size(180, 20);
            this.TDescripcion.TabIndex = 12;
            this.TDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // CBCategoria
            // 
            this.CBCategoria.BackColor = System.Drawing.Color.White;
            this.CBCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "categoria11",
            "categoria22",
            "categoria33"});
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
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Activo ",
            "No Activo "});
            this.CBEstado.Location = new System.Drawing.Point(32, 372);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(180, 21);
            this.CBEstado.TabIndex = 16;
            this.CBEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Detalle Producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datagridProd
            // 
            this.datagridProd.AllowUserToAddRows = false;
            this.datagridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ccodigo,
            this.Cnombre,
            this.Cdescripcion,
            this.cprecio,
            this.ColStock,
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
            this.datagridProd.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagridProd.Location = new System.Drawing.Point(298, 117);
            this.datagridProd.MultiSelect = false;
            this.datagridProd.Name = "datagridProd";
            this.datagridProd.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridProd.RowTemplate.Height = 28;
            this.datagridProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridProd.Size = new System.Drawing.Size(842, 390);
            this.datagridProd.TabIndex = 23;
            this.datagridProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridProd_CellContentClick);
            this.datagridProd.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.datagridProd_RowPrePaint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(298, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(622, 51);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lista de Productos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.EarthAmericas;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 23;
            this.btnEditar.Location = new System.Drawing.Point(32, 474);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 33);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnGuardar.IconSize = 23;
            this.btnGuardar.Location = new System.Drawing.Point(32, 435);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 33);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(567, 45);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 13);
            this.lblBuscar.TabIndex = 21;
            this.lblBuscar.Text = "Buscar Por:";
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.BackColor = System.Drawing.Color.White;
            this.cboBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(635, 42);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(86, 21);
            this.cboBusqueda.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(727, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            // 
            // icoBtnLimpiar
            // 
            this.icoBtnLimpiar.BackColor = System.Drawing.Color.White;
            this.icoBtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icoBtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.icoBtnLimpiar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.icoBtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.icoBtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.icoBtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnLimpiar.IconSize = 23;
            this.icoBtnLimpiar.Location = new System.Drawing.Point(874, 35);
            this.icoBtnLimpiar.Name = "icoBtnLimpiar";
            this.icoBtnLimpiar.Size = new System.Drawing.Size(35, 33);
            this.icoBtnLimpiar.TabIndex = 22;
            this.icoBtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // icoBtnBuscar
            // 
            this.icoBtnBuscar.BackColor = System.Drawing.Color.White;
            this.icoBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icoBtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.icoBtnBuscar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnBuscar.ForeColor = System.Drawing.Color.White;
            this.icoBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.icoBtnBuscar.IconColor = System.Drawing.Color.Black;
            this.icoBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnBuscar.IconSize = 23;
            this.icoBtnBuscar.Location = new System.Drawing.Point(833, 35);
            this.icoBtnBuscar.Name = "icoBtnBuscar";
            this.icoBtnBuscar.Size = new System.Drawing.Size(35, 33);
            this.icoBtnBuscar.TabIndex = 21;
            this.icoBtnBuscar.UseVisualStyleBackColor = false;
            // 
            // TPrecio
            // 
            this.TPrecio.BackColor = System.Drawing.Color.White;
            this.TPrecio.Location = new System.Drawing.Point(32, 233);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.Size = new System.Drawing.Size(180, 20);
            this.TPrecio.TabIndex = 13;
            this.TPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.TPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.BackColor = System.Drawing.Color.White;
            this.Precio.Location = new System.Drawing.Point(39, 217);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(40, 13);
            this.Precio.TabIndex = 27;
            this.Precio.Text = "Precio:";
            // 
            // TStock
            // 
            this.TStock.BackColor = System.Drawing.Color.White;
            this.TStock.Location = new System.Drawing.Point(32, 279);
            this.TStock.Name = "TStock";
            this.TStock.Size = new System.Drawing.Size(180, 20);
            this.TStock.TabIndex = 14;
            this.TStock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(39, 263);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 29;
            this.lblStock.Text = "Stock:";
            this.lblStock.Click += new System.EventHandler(this.label4_Click);
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
            // ColStock
            // 
            this.ColStock.HeaderText = "Stock";
            this.ColStock.Name = "ColStock";
            this.ColStock.ReadOnly = true;
            this.ColStock.Width = 80;
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
            // ProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.TStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.TPrecio);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.icoBtnBuscar);
            this.Controls.Add(this.icoBtnLimpiar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagridProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.TDescripcion);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TCodProd);
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
            ((System.ComponentModel.ISupportInitialize)(this.datagridProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label codigoProd;
        private System.Windows.Forms.Label lDescrip;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.TextBox TCodProd;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TDescripcion;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.TextBox textBox4;
        private FontAwesome.Sharp.IconButton icoBtnLimpiar;
        private FontAwesome.Sharp.IconButton icoBtnBuscar;
        private System.Windows.Forms.TextBox TPrecio;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox TStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CestadoVAlor;
        private System.Windows.Forms.DataGridViewButtonColumn Ceditar;
    }
}