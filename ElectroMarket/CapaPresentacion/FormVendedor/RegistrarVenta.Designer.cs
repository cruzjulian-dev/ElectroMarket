namespace CapaPresentacion
{
    partial class RegistrarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TFecha = new System.Windows.Forms.TextBox();
            this.Ltipodoc = new System.Windows.Forms.Label();
            this.TTipoDoc = new System.Windows.Forms.ComboBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TApe = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TNomApe = new System.Windows.Forms.TextBox();
            this.BCliente = new FontAwesome.Sharp.IconButton();
            this.lnombrecom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TIdProd = new System.Windows.Forms.TextBox();
            this.TCantidad = new System.Windows.Forms.NumericUpDown();
            this.TProd = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.lstock = new System.Windows.Forms.Label();
            this.TStock = new System.Windows.Forms.TextBox();
            this.lprecio = new System.Windows.Forms.Label();
            this.TPrecio = new System.Windows.Forms.TextBox();
            this.BProd = new FontAwesome.Sharp.IconButton();
            this.lproducto = new System.Windows.Forms.Label();
            this.Lcodprod = new System.Windows.Forms.Label();
            this.TCod = new System.Windows.Forms.TextBox();
            this.DGDetalle = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TPagaCon = new System.Windows.Forms.TextBox();
            this.TCambio = new System.Windows.Forms.TextBox();
            this.TTotal = new System.Windows.Forms.TextBox();
            this.BVender = new FontAwesome.Sharp.IconButton();
            this.BAgregar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.CBForma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BEditar = new FontAwesome.Sharp.IconButton();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ceditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(94, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(806, 543);
            this.label3.TabIndex = 20;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Registrar venta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.TFecha);
            this.groupBox1.Controls.Add(this.Ltipodoc);
            this.groupBox1.Controls.Add(this.TTipoDoc);
            this.groupBox1.Controls.Add(this.LFecha);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(129, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // TFecha
            // 
            this.TFecha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFecha.Location = new System.Drawing.Point(6, 62);
            this.TFecha.Name = "TFecha";
            this.TFecha.ReadOnly = true;
            this.TFecha.Size = new System.Drawing.Size(116, 21);
            this.TFecha.TabIndex = 25;
            // 
            // Ltipodoc
            // 
            this.Ltipodoc.AutoSize = true;
            this.Ltipodoc.BackColor = System.Drawing.Color.White;
            this.Ltipodoc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltipodoc.Location = new System.Drawing.Point(125, 45);
            this.Ltipodoc.Name = "Ltipodoc";
            this.Ltipodoc.Size = new System.Drawing.Size(100, 13);
            this.Ltipodoc.TabIndex = 24;
            this.Ltipodoc.Text = "Tipo Documento";
            // 
            // TTipoDoc
            // 
            this.TTipoDoc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTipoDoc.FormattingEnabled = true;
            this.TTipoDoc.Location = new System.Drawing.Point(128, 61);
            this.TTipoDoc.Name = "TTipoDoc";
            this.TTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.TTipoDoc.TabIndex = 2;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.White;
            this.LFecha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.Location = new System.Drawing.Point(16, 46);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(45, 13);
            this.LFecha.TabIndex = 23;
            this.LFecha.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.TApe);
            this.groupBox2.Controls.Add(this.TNombre);
            this.groupBox2.Controls.Add(this.TNomApe);
            this.groupBox2.Controls.Add(this.BCliente);
            this.groupBox2.Controls.Add(this.lnombrecom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TDni);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(453, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // TApe
            // 
            this.TApe.Location = new System.Drawing.Point(223, 20);
            this.TApe.Name = "TApe";
            this.TApe.Size = new System.Drawing.Size(48, 21);
            this.TApe.TabIndex = 26;
            this.TApe.Visible = false;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(157, 20);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(48, 21);
            this.TNombre.TabIndex = 25;
            this.TNombre.Visible = false;
            // 
            // TNomApe
            // 
            this.TNomApe.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNomApe.Location = new System.Drawing.Point(157, 62);
            this.TNomApe.Name = "TNomApe";
            this.TNomApe.ReadOnly = true;
            this.TNomApe.Size = new System.Drawing.Size(134, 21);
            this.TNomApe.TabIndex = 5;
            // 
            // BCliente
            // 
            this.BCliente.BackColor = System.Drawing.Color.White;
            this.BCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BCliente.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCliente.ForeColor = System.Drawing.Color.White;
            this.BCliente.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.BCliente.IconColor = System.Drawing.Color.Black;
            this.BCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BCliente.IconSize = 23;
            this.BCliente.Location = new System.Drawing.Point(115, 59);
            this.BCliente.Name = "BCliente";
            this.BCliente.Size = new System.Drawing.Size(35, 26);
            this.BCliente.TabIndex = 4;
            this.BCliente.UseVisualStyleBackColor = false;
            this.BCliente.Click += new System.EventHandler(this.icoBtnBuscar_Click);
            // 
            // lnombrecom
            // 
            this.lnombrecom.AutoSize = true;
            this.lnombrecom.BackColor = System.Drawing.Color.White;
            this.lnombrecom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombrecom.Location = new System.Drawing.Point(155, 46);
            this.lnombrecom.Name = "lnombrecom";
            this.lnombrecom.Size = new System.Drawing.Size(116, 13);
            this.lnombrecom.TabIndex = 24;
            this.lnombrecom.Text = "Nombre Completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nro Documento:";
            // 
            // TDni
            // 
            this.TDni.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDni.Location = new System.Drawing.Point(6, 62);
            this.TDni.Name = "TDni";
            this.TDni.ReadOnly = true;
            this.TDni.Size = new System.Drawing.Size(100, 21);
            this.TDni.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.TDescripcion);
            this.groupBox3.Controls.Add(this.TIdProd);
            this.groupBox3.Controls.Add(this.TCantidad);
            this.groupBox3.Controls.Add(this.TProd);
            this.groupBox3.Controls.Add(this.LCantidad);
            this.groupBox3.Controls.Add(this.lstock);
            this.groupBox3.Controls.Add(this.TStock);
            this.groupBox3.Controls.Add(this.lprecio);
            this.groupBox3.Controls.Add(this.TPrecio);
            this.groupBox3.Controls.Add(this.BProd);
            this.groupBox3.Controls.Add(this.lproducto);
            this.groupBox3.Controls.Add(this.Lcodprod);
            this.groupBox3.Controls.Add(this.TCod);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(129, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 100);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // TIdProd
            // 
            this.TIdProd.Location = new System.Drawing.Point(6, 20);
            this.TIdProd.Name = "TIdProd";
            this.TIdProd.Size = new System.Drawing.Size(29, 21);
            this.TIdProd.TabIndex = 34;
            this.TIdProd.Visible = false;
            // 
            // TCantidad
            // 
            this.TCantidad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCantidad.Location = new System.Drawing.Point(530, 61);
            this.TCantidad.Name = "TCantidad";
            this.TCantidad.Size = new System.Drawing.Size(82, 21);
            this.TCantidad.TabIndex = 11;
            this.TCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TCantidad.ValueChanged += new System.EventHandler(this.TCantidad_ValueChanged);
            // 
            // TProd
            // 
            this.TProd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TProd.Location = new System.Drawing.Point(174, 61);
            this.TProd.Name = "TProd";
            this.TProd.ReadOnly = true;
            this.TProd.Size = new System.Drawing.Size(166, 21);
            this.TProd.TabIndex = 8;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.BackColor = System.Drawing.Color.White;
            this.LCantidad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.Location = new System.Drawing.Point(530, 47);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(63, 13);
            this.LCantidad.TabIndex = 33;
            this.LCantidad.Text = "Cantidad:";
            // 
            // lstock
            // 
            this.lstock.AutoSize = true;
            this.lstock.BackColor = System.Drawing.Color.White;
            this.lstock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstock.Location = new System.Drawing.Point(431, 45);
            this.lstock.Name = "lstock";
            this.lstock.Size = new System.Drawing.Size(44, 13);
            this.lstock.TabIndex = 31;
            this.lstock.Text = "Stock:";
            // 
            // TStock
            // 
            this.TStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TStock.Location = new System.Drawing.Point(434, 62);
            this.TStock.Name = "TStock";
            this.TStock.ReadOnly = true;
            this.TStock.Size = new System.Drawing.Size(82, 21);
            this.TStock.TabIndex = 10;
            // 
            // lprecio
            // 
            this.lprecio.AutoSize = true;
            this.lprecio.BackColor = System.Drawing.Color.White;
            this.lprecio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lprecio.Location = new System.Drawing.Point(343, 46);
            this.lprecio.Name = "lprecio";
            this.lprecio.Size = new System.Drawing.Size(47, 13);
            this.lprecio.TabIndex = 29;
            this.lprecio.Text = "Precio:";
            // 
            // TPrecio
            // 
            this.TPrecio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPrecio.Location = new System.Drawing.Point(346, 62);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.ReadOnly = true;
            this.TPrecio.Size = new System.Drawing.Size(82, 21);
            this.TPrecio.TabIndex = 9;
            // 
            // BProd
            // 
            this.BProd.BackColor = System.Drawing.Color.White;
            this.BProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BProd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BProd.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BProd.ForeColor = System.Drawing.Color.White;
            this.BProd.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.BProd.IconColor = System.Drawing.Color.Black;
            this.BProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BProd.IconSize = 23;
            this.BProd.Location = new System.Drawing.Point(133, 59);
            this.BProd.Name = "BProd";
            this.BProd.Size = new System.Drawing.Size(35, 26);
            this.BProd.TabIndex = 7;
            this.BProd.UseVisualStyleBackColor = false;
            this.BProd.Click += new System.EventHandler(this.btnBuscarProduc_Click);
            // 
            // lproducto
            // 
            this.lproducto.AutoSize = true;
            this.lproducto.BackColor = System.Drawing.Color.White;
            this.lproducto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lproducto.Location = new System.Drawing.Point(179, 43);
            this.lproducto.Name = "lproducto";
            this.lproducto.Size = new System.Drawing.Size(62, 13);
            this.lproducto.TabIndex = 24;
            this.lproducto.Text = "Producto:";
            // 
            // Lcodprod
            // 
            this.Lcodprod.AutoSize = true;
            this.Lcodprod.BackColor = System.Drawing.Color.White;
            this.Lcodprod.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcodprod.Location = new System.Drawing.Point(3, 45);
            this.Lcodprod.Name = "Lcodprod";
            this.Lcodprod.Size = new System.Drawing.Size(93, 13);
            this.Lcodprod.TabIndex = 23;
            this.Lcodprod.Text = "Cod. Producto:";
            // 
            // TCod
            // 
            this.TCod.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCod.Location = new System.Drawing.Point(6, 62);
            this.TCod.Name = "TCod";
            this.TCod.ReadOnly = true;
            this.TCod.Size = new System.Drawing.Size(121, 21);
            this.TCod.TabIndex = 6;
            // 
            // DGDetalle
            // 
            this.DGDetalle.AllowUserToAddRows = false;
            this.DGDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.CCod,
            this.Cproducto,
            this.CPrecio,
            this.Ccantidad,
            this.Csubtotal,
            this.CEliminar,
            this.Ceditar,
            this.CDescripcion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGDetalle.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGDetalle.Location = new System.Drawing.Point(129, 265);
            this.DGDetalle.MultiSelect = false;
            this.DGDetalle.Name = "DGDetalle";
            this.DGDetalle.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGDetalle.RowTemplate.Height = 28;
            this.DGDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGDetalle.Size = new System.Drawing.Size(622, 272);
            this.DGDetalle.TabIndex = 13;
            this.DGDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetalle_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(767, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Total a Pagar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(767, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Cambio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(767, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Paga con:";
            // 
            // TPagaCon
            // 
            this.TPagaCon.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPagaCon.Location = new System.Drawing.Point(770, 422);
            this.TPagaCon.Name = "TPagaCon";
            this.TPagaCon.Size = new System.Drawing.Size(121, 21);
            this.TPagaCon.TabIndex = 15;
            this.TPagaCon.TextChanged += new System.EventHandler(this.TPagaCon_TextChanged);
            this.TPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPagaCon_KeyPress);
            // 
            // TCambio
            // 
            this.TCambio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCambio.Location = new System.Drawing.Point(770, 461);
            this.TCambio.Name = "TCambio";
            this.TCambio.ReadOnly = true;
            this.TCambio.Size = new System.Drawing.Size(121, 21);
            this.TCambio.TabIndex = 16;
            // 
            // TTotal
            // 
            this.TTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTotal.Location = new System.Drawing.Point(770, 383);
            this.TTotal.Name = "TTotal";
            this.TTotal.ReadOnly = true;
            this.TTotal.Size = new System.Drawing.Size(121, 21);
            this.TTotal.TabIndex = 14;
            this.TTotal.Text = "0";
            // 
            // BVender
            // 
            this.BVender.BackColor = System.Drawing.Color.DarkCyan;
            this.BVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVender.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVender.ForeColor = System.Drawing.Color.White;
            this.BVender.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.BVender.IconColor = System.Drawing.Color.White;
            this.BVender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BVender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BVender.Location = new System.Drawing.Point(759, 488);
            this.BVender.Name = "BVender";
            this.BVender.Size = new System.Drawing.Size(134, 49);
            this.BVender.TabIndex = 17;
            this.BVender.Text = "Registrar Venta";
            this.BVender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVender.UseVisualStyleBackColor = false;
            this.BVender.Click += new System.EventHandler(this.iconButtonVenta_Click);
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.BAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.BAgregar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.ForeColor = System.Drawing.Color.White;
            this.BAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BAgregar.IconColor = System.Drawing.Color.White;
            this.BAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BAgregar.Location = new System.Drawing.Point(790, 161);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(75, 85);
            this.BAgregar.TabIndex = 12;
            this.BAgregar.Text = "Agregar Producto";
            this.BAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BAgregar.UseVisualStyleBackColor = false;
            this.BAgregar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 23;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(790, 66);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(71, 69);
            this.iconButton1.TabIndex = 65;
            this.iconButton1.Text = "Limpiar Campos";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // CBForma
            // 
            this.CBForma.FormattingEnabled = true;
            this.CBForma.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Mercado Pago"});
            this.CBForma.Location = new System.Drawing.Point(770, 337);
            this.CBForma.Name = "CBForma";
            this.CBForma.Size = new System.Drawing.Size(121, 21);
            this.CBForma.TabIndex = 66;
            this.CBForma.SelectedIndexChanged += new System.EventHandler(this.CBForma_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(767, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Forma de pago:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.DarkOrange;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEditar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.ForeColor = System.Drawing.Color.White;
            this.BEditar.IconChar = FontAwesome.Sharp.IconChar.EarthAmericas;
            this.BEditar.IconColor = System.Drawing.Color.White;
            this.BEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BEditar.IconSize = 23;
            this.BEditar.Location = new System.Drawing.Point(790, 252);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(75, 53);
            this.BEditar.TabIndex = 68;
            this.BEditar.Text = "Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProdcuto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // CCod
            // 
            this.CCod.HeaderText = "Codigo";
            this.CCod.Name = "CCod";
            this.CCod.ReadOnly = true;
            this.CCod.Width = 60;
            // 
            // Cproducto
            // 
            this.Cproducto.HeaderText = "Producto";
            this.Cproducto.Name = "Cproducto";
            this.Cproducto.ReadOnly = true;
            this.Cproducto.Width = 140;
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.ReadOnly = true;
            // 
            // Ccantidad
            // 
            this.Ccantidad.HeaderText = "Cantidad";
            this.Ccantidad.Name = "Ccantidad";
            this.Ccantidad.ReadOnly = true;
            this.Ccantidad.Width = 65;
            // 
            // Csubtotal
            // 
            this.Csubtotal.HeaderText = "Subtotal";
            this.Csubtotal.Name = "Csubtotal";
            this.Csubtotal.ReadOnly = true;
            this.Csubtotal.Width = 140;
            // 
            // CEliminar
            // 
            this.CEliminar.HeaderText = "Eliminar";
            this.CEliminar.Name = "CEliminar";
            this.CEliminar.ReadOnly = true;
            this.CEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CEliminar.Width = 75;
            // 
            // Ceditar
            // 
            this.Ceditar.HeaderText = "Editar";
            this.Ceditar.Name = "Ceditar";
            this.Ceditar.ReadOnly = true;
            // 
            // CDescripcion
            // 
            this.CDescripcion.HeaderText = "Descripcion";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            // 
            // TDescripcion
            // 
            this.TDescripcion.Location = new System.Drawing.Point(266, 20);
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.Size = new System.Drawing.Size(74, 21);
            this.TDescripcion.TabIndex = 35;
            this.TDescripcion.Visible = false;
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBForma);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.TTotal);
            this.Controls.Add(this.TCambio);
            this.Controls.Add(this.TPagaCon);
            this.Controls.Add(this.BVender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.DGDetalle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "RegistrarVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TTipoDoc;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label Ltipodoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lnombrecom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TDni;
        private FontAwesome.Sharp.IconButton BCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label lstock;
        private System.Windows.Forms.TextBox TStock;
        private System.Windows.Forms.Label lprecio;
        private System.Windows.Forms.TextBox TPrecio;
        private FontAwesome.Sharp.IconButton BProd;
        private System.Windows.Forms.Label lproducto;
        private System.Windows.Forms.Label Lcodprod;
        private System.Windows.Forms.TextBox TCod;
        private System.Windows.Forms.TextBox TProd;
        private System.Windows.Forms.NumericUpDown TCantidad;
        private System.Windows.Forms.DataGridView DGDetalle;
        private FontAwesome.Sharp.IconButton BAgregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton BVender;
        private System.Windows.Forms.TextBox TPagaCon;
        private System.Windows.Forms.TextBox TCambio;
        private System.Windows.Forms.TextBox TTotal;
        private System.Windows.Forms.TextBox TNomApe;
        private System.Windows.Forms.TextBox TFecha;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox CBForma;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BEditar;
        private System.Windows.Forms.TextBox TIdProd;
        private System.Windows.Forms.TextBox TApe;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Ceditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.TextBox TDescripcion;
    }
}