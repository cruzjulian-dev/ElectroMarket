namespace CapaPresentacion
{
    partial class DetalleVenta
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.labelusuario = new System.Windows.Forms.Label();
            this.txttipodocumento = new System.Windows.Forms.TextBox();
            this.Ltipodoc = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labeldocucliente = new System.Windows.Forms.Label();
            this.txtdocucliente = new System.Windows.Forms.TextBox();
            this.datagridProd = new System.Windows.Forms.DataGridView();
            this.Cproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cprecioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labmontocambio = new System.Windows.Forms.Label();
            this.labmontopago = new System.Windows.Forms.Label();
            this.labmontototal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(83, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(686, 517);
            this.label3.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Detalle Venta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.Location = new System.Drawing.Point(431, 50);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(156, 20);
            this.txtBusqueda.TabIndex = 41;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 23;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(590, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 33);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(363, 54);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 13);
            this.lblBuscar.TabIndex = 39;
            this.lblBuscar.Text = "Buscar Por:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 23;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(673, 44);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 33);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.labelusuario);
            this.groupBox1.Controls.Add(this.txttipodocumento);
            this.groupBox1.Controls.Add(this.Ltipodoc);
            this.groupBox1.Controls.Add(this.LFecha);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Location = new System.Drawing.Point(99, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 90);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(402, 60);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(237, 20);
            this.txtusuario.TabIndex = 27;
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.BackColor = System.Drawing.Color.White;
            this.labelusuario.Location = new System.Drawing.Point(399, 44);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(46, 13);
            this.labelusuario.TabIndex = 26;
            this.labelusuario.Text = "Usuario:";
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.Location = new System.Drawing.Point(184, 60);
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.Size = new System.Drawing.Size(212, 20);
            this.txttipodocumento.TabIndex = 25;
            // 
            // Ltipodoc
            // 
            this.Ltipodoc.AutoSize = true;
            this.Ltipodoc.BackColor = System.Drawing.Color.White;
            this.Ltipodoc.Location = new System.Drawing.Point(181, 44);
            this.Ltipodoc.Name = "Ltipodoc";
            this.Ltipodoc.Size = new System.Drawing.Size(89, 13);
            this.Ltipodoc.TabIndex = 24;
            this.Ltipodoc.Text = "Tipo Documento:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.White;
            this.LFecha.Location = new System.Drawing.Point(6, 44);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(40, 13);
            this.LFecha.TabIndex = 23;
            this.LFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(6, 60);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(172, 20);
            this.txtFecha.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtnombrecliente);
            this.groupBox2.Controls.Add(this.labelNombreCliente);
            this.groupBox2.Controls.Add(this.labeldocucliente);
            this.groupBox2.Controls.Add(this.txtdocucliente);
            this.groupBox2.Location = new System.Drawing.Point(99, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 86);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(184, 58);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(212, 20);
            this.txtnombrecliente.TabIndex = 25;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.BackColor = System.Drawing.Color.White;
            this.labelNombreCliente.Location = new System.Drawing.Point(181, 42);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(86, 13);
            this.labelNombreCliente.TabIndex = 24;
            this.labelNombreCliente.Text = "Tipo Documento";
            // 
            // labeldocucliente
            // 
            this.labeldocucliente.AutoSize = true;
            this.labeldocucliente.BackColor = System.Drawing.Color.White;
            this.labeldocucliente.Location = new System.Drawing.Point(6, 42);
            this.labeldocucliente.Name = "labeldocucliente";
            this.labeldocucliente.Size = new System.Drawing.Size(40, 13);
            this.labeldocucliente.TabIndex = 23;
            this.labeldocucliente.Text = "Fecha:";
            // 
            // txtdocucliente
            // 
            this.txtdocucliente.Location = new System.Drawing.Point(6, 58);
            this.txtdocucliente.Name = "txtdocucliente";
            this.txtdocucliente.Size = new System.Drawing.Size(172, 20);
            this.txtdocucliente.TabIndex = 0;
            // 
            // datagridProd
            // 
            this.datagridProd.AllowUserToAddRows = false;
            this.datagridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cproducto,
            this.Cprecioventa,
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
            this.datagridProd.Location = new System.Drawing.Point(99, 271);
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
            this.datagridProd.Size = new System.Drawing.Size(654, 223);
            this.datagridProd.TabIndex = 46;
            // 
            // Cproducto
            // 
            this.Cproducto.HeaderText = "Producto";
            this.Cproducto.Name = "Cproducto";
            this.Cproducto.ReadOnly = true;
            // 
            // Cprecioventa
            // 
            this.Cprecioventa.HeaderText = "Precio venta";
            this.Cprecioventa.Name = "Cprecioventa";
            this.Cprecioventa.ReadOnly = true;
            this.Cprecioventa.Visible = false;
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
            // labmontocambio
            // 
            this.labmontocambio.AutoSize = true;
            this.labmontocambio.BackColor = System.Drawing.Color.White;
            this.labmontocambio.Location = new System.Drawing.Point(434, 502);
            this.labmontocambio.Name = "labmontocambio";
            this.labmontocambio.Size = new System.Drawing.Size(78, 13);
            this.labmontocambio.TabIndex = 47;
            this.labmontocambio.Text = "Monto Cambio:";
            // 
            // labmontopago
            // 
            this.labmontopago.AutoSize = true;
            this.labmontopago.BackColor = System.Drawing.Color.White;
            this.labmontopago.Location = new System.Drawing.Point(282, 502);
            this.labmontopago.Name = "labmontopago";
            this.labmontopago.Size = new System.Drawing.Size(68, 13);
            this.labmontopago.TabIndex = 48;
            this.labmontopago.Text = "Monto Pago:";
            // 
            // labmontototal
            // 
            this.labmontototal.AutoSize = true;
            this.labmontototal.BackColor = System.Drawing.Color.White;
            this.labmontototal.Location = new System.Drawing.Point(118, 502);
            this.labmontototal.Name = "labmontototal";
            this.labmontototal.Size = new System.Drawing.Size(67, 13);
            this.labmontototal.TabIndex = 49;
            this.labmontototal.Text = "Monto Total:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(515, 499);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 499);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(189, 499);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 30;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 23;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(604, 496);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(149, 32);
            this.iconButton1.TabIndex = 50;
            this.iconButton1.Text = "Descargar en Pdf";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.BackColor = System.Drawing.Color.White;
            this.cboBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(431, 26);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(113, 21);
            this.cboBusqueda.TabIndex = 52;
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labmontototal);
            this.Controls.Add(this.labmontopago);
            this.Controls.Add(this.labmontocambio);
            this.Controls.Add(this.datagridProd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "DetalleVenta";
            this.Text = "Detalle Venta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.TextBox txttipodocumento;
        private System.Windows.Forms.Label Ltipodoc;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.Label labeldocucliente;
        private System.Windows.Forms.TextBox txtdocucliente;
        private System.Windows.Forms.DataGridView datagridProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cprecioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csubtotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labmontocambio;
        private System.Windows.Forms.Label labmontopago;
        private System.Windows.Forms.Label labmontototal;
        private System.Windows.Forms.TextBox textBox3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox cboBusqueda;
    }
}