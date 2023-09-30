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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.Ltipodoc = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.icoBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.lnombrecom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.lstock = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lprecio = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnBuscarProduc = new FontAwesome.Sharp.IconButton();
            this.lproducto = new System.Windows.Forms.Label();
            this.Lcodprod = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.datagridProd = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.iconButtonVenta = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(94, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(783, 507);
            this.label3.TabIndex = 20;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Registrar venta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.DTFecha);
            this.groupBox1.Controls.Add(this.Ltipodoc);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.LFecha);
            this.groupBox1.Location = new System.Drawing.Point(129, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // DTFecha
            // 
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFecha.Location = new System.Drawing.Point(19, 62);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(100, 20);
            this.DTFecha.TabIndex = 1;
            // 
            // Ltipodoc
            // 
            this.Ltipodoc.AutoSize = true;
            this.Ltipodoc.BackColor = System.Drawing.Color.White;
            this.Ltipodoc.Location = new System.Drawing.Point(125, 45);
            this.Ltipodoc.Name = "Ltipodoc";
            this.Ltipodoc.Size = new System.Drawing.Size(86, 13);
            this.Ltipodoc.TabIndex = 24;
            this.Ltipodoc.Text = "Tipo Documento";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.White;
            this.LFecha.Location = new System.Drawing.Point(16, 46);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(40, 13);
            this.LFecha.TabIndex = 23;
            this.LFecha.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.icoBtnBuscar);
            this.groupBox2.Controls.Add(this.lnombrecom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(453, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(157, 60);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(134, 20);
            this.textBox7.TabIndex = 5;
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
            this.icoBtnBuscar.Location = new System.Drawing.Point(111, 56);
            this.icoBtnBuscar.Name = "icoBtnBuscar";
            this.icoBtnBuscar.Size = new System.Drawing.Size(35, 26);
            this.icoBtnBuscar.TabIndex = 4;
            this.icoBtnBuscar.UseVisualStyleBackColor = false;
            this.icoBtnBuscar.Click += new System.EventHandler(this.icoBtnBuscar_Click);
            // 
            // lnombrecom
            // 
            this.lnombrecom.AutoSize = true;
            this.lnombrecom.BackColor = System.Drawing.Color.White;
            this.lnombrecom.Location = new System.Drawing.Point(152, 45);
            this.lnombrecom.Name = "lnombrecom";
            this.lnombrecom.Size = new System.Drawing.Size(91, 13);
            this.lnombrecom.TabIndex = 24;
            this.lnombrecom.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nro Documento:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.LCantidad);
            this.groupBox3.Controls.Add(this.lstock);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.lprecio);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.btnBuscarProduc);
            this.groupBox3.Controls.Add(this.lproducto);
            this.groupBox3.Controls.Add(this.Lcodprod);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(129, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 100);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(533, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(174, 61);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(166, 20);
            this.textBox8.TabIndex = 8;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.BackColor = System.Drawing.Color.White;
            this.LCantidad.Location = new System.Drawing.Point(530, 47);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(52, 13);
            this.LCantidad.TabIndex = 33;
            this.LCantidad.Text = "Cantidad:";
            this.LCantidad.Click += new System.EventHandler(this.label9_Click);
            // 
            // lstock
            // 
            this.lstock.AutoSize = true;
            this.lstock.BackColor = System.Drawing.Color.White;
            this.lstock.Location = new System.Drawing.Point(431, 45);
            this.lstock.Name = "lstock";
            this.lstock.Size = new System.Drawing.Size(38, 13);
            this.lstock.TabIndex = 31;
            this.lstock.Text = "Stock:";
            this.lstock.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(434, 62);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(82, 20);
            this.textBox6.TabIndex = 10;
            // 
            // lprecio
            // 
            this.lprecio.AutoSize = true;
            this.lprecio.BackColor = System.Drawing.Color.White;
            this.lprecio.Location = new System.Drawing.Point(343, 46);
            this.lprecio.Name = "lprecio";
            this.lprecio.Size = new System.Drawing.Size(40, 13);
            this.lprecio.TabIndex = 29;
            this.lprecio.Text = "Precio:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(346, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(82, 20);
            this.textBox5.TabIndex = 9;
            // 
            // btnBuscarProduc
            // 
            this.btnBuscarProduc.BackColor = System.Drawing.Color.White;
            this.btnBuscarProduc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProduc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarProduc.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduc.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProduc.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarProduc.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProduc.IconSize = 23;
            this.btnBuscarProduc.Location = new System.Drawing.Point(133, 57);
            this.btnBuscarProduc.Name = "btnBuscarProduc";
            this.btnBuscarProduc.Size = new System.Drawing.Size(35, 26);
            this.btnBuscarProduc.TabIndex = 7;
            this.btnBuscarProduc.UseVisualStyleBackColor = false;
            this.btnBuscarProduc.Click += new System.EventHandler(this.btnBuscarProduc_Click);
            // 
            // lproducto
            // 
            this.lproducto.AutoSize = true;
            this.lproducto.BackColor = System.Drawing.Color.White;
            this.lproducto.Location = new System.Drawing.Point(179, 43);
            this.lproducto.Name = "lproducto";
            this.lproducto.Size = new System.Drawing.Size(53, 13);
            this.lproducto.TabIndex = 24;
            this.lproducto.Text = "Producto:";
            // 
            // Lcodprod
            // 
            this.Lcodprod.AutoSize = true;
            this.Lcodprod.BackColor = System.Drawing.Color.White;
            this.Lcodprod.Location = new System.Drawing.Point(3, 45);
            this.Lcodprod.Name = "Lcodprod";
            this.Lcodprod.Size = new System.Drawing.Size(78, 13);
            this.Lcodprod.TabIndex = 23;
            this.Lcodprod.Text = "Cod. Producto:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 6;
            // 
            // datagridProd
            // 
            this.datagridProd.AllowUserToAddRows = false;
            this.datagridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Cproducto,
            this.CPrecio,
            this.Ccantidad,
            this.Csubtotal});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridProd.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagridProd.Location = new System.Drawing.Point(129, 265);
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
            this.datagridProd.Size = new System.Drawing.Size(622, 241);
            this.datagridProd.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(767, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Total a Pagar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(767, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Cambio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(767, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Paga con:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(770, 379);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(86, 20);
            this.textBox11.TabIndex = 15;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(770, 418);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(86, 20);
            this.textBox12.TabIndex = 16;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(770, 340);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(86, 20);
            this.textBox13.TabIndex = 14;
            this.textBox13.Text = "0";
            // 
            // iconButtonVenta
            // 
            this.iconButtonVenta.BackColor = System.Drawing.Color.DarkCyan;
            this.iconButtonVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonVenta.ForeColor = System.Drawing.Color.White;
            this.iconButtonVenta.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconButtonVenta.IconColor = System.Drawing.Color.White;
            this.iconButtonVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonVenta.Location = new System.Drawing.Point(757, 457);
            this.iconButtonVenta.Name = "iconButtonVenta";
            this.iconButtonVenta.Size = new System.Drawing.Size(109, 49);
            this.iconButtonVenta.TabIndex = 17;
            this.iconButtonVenta.Text = "Crear Venta";
            this.iconButtonVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonVenta.UseVisualStyleBackColor = false;
            this.iconButtonVenta.Click += new System.EventHandler(this.iconButtonVenta_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(770, 174);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 85);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "Agregar Producto";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProdcuto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // Cproducto
            // 
            this.Cproducto.HeaderText = "Producto";
            this.Cproducto.Name = "Cproducto";
            this.Cproducto.ReadOnly = true;
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
            // 
            // Csubtotal
            // 
            this.Csubtotal.HeaderText = "Subtotal";
            this.Csubtotal.Name = "Csubtotal";
            this.Csubtotal.ReadOnly = true;
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.iconButtonVenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.datagridProd);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label Ltipodoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lnombrecom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton icoBtnBuscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label lstock;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lprecio;
        private System.Windows.Forms.TextBox textBox5;
        private FontAwesome.Sharp.IconButton btnBuscarProduc;
        private System.Windows.Forms.Label lproducto;
        private System.Windows.Forms.Label Lcodprod;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView datagridProd;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton iconButtonVenta;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csubtotal;
    }
}