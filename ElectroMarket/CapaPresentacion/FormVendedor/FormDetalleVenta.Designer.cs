﻿namespace CapaPresentacion
{
    partial class FormDetalleVenta
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
            this.TVendedor = new System.Windows.Forms.TextBox();
            this.labelusuario = new System.Windows.Forms.Label();
            this.TFecha = new System.Windows.Forms.TextBox();
            this.Ltipodoc = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.TIdVenta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labeldocucliente = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.DGDetalle = new System.Windows.Forms.DataGridView();
            this.CIdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labmontocambio = new System.Windows.Forms.Label();
            this.labmontopago = new System.Windows.Forms.Label();
            this.labmontototal = new System.Windows.Forms.Label();
            this.TCambio = new System.Windows.Forms.TextBox();
            this.TPago = new System.Windows.Forms.TextBox();
            this.TTotal = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(83, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(686, 526);
            this.label3.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Detalle Venta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.TVendedor);
            this.groupBox1.Controls.Add(this.labelusuario);
            this.groupBox1.Controls.Add(this.TFecha);
            this.groupBox1.Controls.Add(this.Ltipodoc);
            this.groupBox1.Controls.Add(this.LFecha);
            this.groupBox1.Controls.Add(this.TIdVenta);
            this.groupBox1.Location = new System.Drawing.Point(99, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 90);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // TVendedor
            // 
            this.TVendedor.Location = new System.Drawing.Point(389, 60);
            this.TVendedor.Name = "TVendedor";
            this.TVendedor.ReadOnly = true;
            this.TVendedor.Size = new System.Drawing.Size(178, 20);
            this.TVendedor.TabIndex = 3;
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.BackColor = System.Drawing.Color.White;
            this.labelusuario.Location = new System.Drawing.Point(390, 44);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(56, 13);
            this.labelusuario.TabIndex = 26;
            this.labelusuario.Text = "Vendedor:";
            // 
            // TFecha
            // 
            this.TFecha.Location = new System.Drawing.Point(184, 60);
            this.TFecha.Name = "TFecha";
            this.TFecha.ReadOnly = true;
            this.TFecha.Size = new System.Drawing.Size(181, 20);
            this.TFecha.TabIndex = 2;
            // 
            // Ltipodoc
            // 
            this.Ltipodoc.AutoSize = true;
            this.Ltipodoc.BackColor = System.Drawing.Color.White;
            this.Ltipodoc.Location = new System.Drawing.Point(181, 44);
            this.Ltipodoc.Name = "Ltipodoc";
            this.Ltipodoc.Size = new System.Drawing.Size(40, 13);
            this.Ltipodoc.TabIndex = 24;
            this.Ltipodoc.Text = "Fecha:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.White;
            this.LFecha.Location = new System.Drawing.Point(6, 44);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(52, 13);
            this.LFecha.TabIndex = 23;
            this.LFecha.Text = "ID Venta:";
            // 
            // TIdVenta
            // 
            this.TIdVenta.Location = new System.Drawing.Point(6, 60);
            this.TIdVenta.Name = "TIdVenta";
            this.TIdVenta.ReadOnly = true;
            this.TIdVenta.Size = new System.Drawing.Size(162, 20);
            this.TIdVenta.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.TDocumento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TApellido);
            this.groupBox2.Controls.Add(this.labelNombreCliente);
            this.groupBox2.Controls.Add(this.labeldocucliente);
            this.groupBox2.Controls.Add(this.TNombre);
            this.groupBox2.Location = new System.Drawing.Point(99, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 86);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // TDocumento
            // 
            this.TDocumento.Location = new System.Drawing.Point(389, 58);
            this.TDocumento.Name = "TDocumento";
            this.TDocumento.ReadOnly = true;
            this.TDocumento.Size = new System.Drawing.Size(191, 20);
            this.TDocumento.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Documento:";
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(186, 58);
            this.TApellido.Name = "TApellido";
            this.TApellido.ReadOnly = true;
            this.TApellido.Size = new System.Drawing.Size(179, 20);
            this.TApellido.TabIndex = 5;
            this.TApellido.TextChanged += new System.EventHandler(this.txtnombrecliente_TextChanged);
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.BackColor = System.Drawing.Color.White;
            this.labelNombreCliente.Location = new System.Drawing.Point(183, 42);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(47, 13);
            this.labelNombreCliente.TabIndex = 24;
            this.labelNombreCliente.Text = "Apellido:";
            this.labelNombreCliente.Click += new System.EventHandler(this.labelNombreCliente_Click);
            // 
            // labeldocucliente
            // 
            this.labeldocucliente.AutoSize = true;
            this.labeldocucliente.BackColor = System.Drawing.Color.White;
            this.labeldocucliente.Location = new System.Drawing.Point(6, 42);
            this.labeldocucliente.Name = "labeldocucliente";
            this.labeldocucliente.Size = new System.Drawing.Size(47, 13);
            this.labeldocucliente.TabIndex = 23;
            this.labeldocucliente.Text = "Nombre:";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(6, 58);
            this.TNombre.Name = "TNombre";
            this.TNombre.ReadOnly = true;
            this.TNombre.Size = new System.Drawing.Size(162, 20);
            this.TNombre.TabIndex = 4;
            // 
            // DGDetalle
            // 
            this.DGDetalle.AllowUserToAddRows = false;
            this.DGDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdProd,
            this.Cproducto,
            this.CDescripcion,
            this.CCategoria,
            this.Cprecio,
            this.Ccantidad,
            this.Csubtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGDetalle.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGDetalle.Location = new System.Drawing.Point(99, 271);
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
            this.DGDetalle.Size = new System.Drawing.Size(654, 223);
            this.DGDetalle.TabIndex = 8;
            // 
            // CIdProd
            // 
            this.CIdProd.HeaderText = "ID";
            this.CIdProd.Name = "CIdProd";
            this.CIdProd.ReadOnly = true;
            this.CIdProd.Width = 40;
            // 
            // Cproducto
            // 
            this.Cproducto.HeaderText = "Producto";
            this.Cproducto.Name = "Cproducto";
            this.Cproducto.ReadOnly = true;
            this.Cproducto.Width = 130;
            // 
            // CDescripcion
            // 
            this.CDescripcion.HeaderText = "Descripcion";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            this.CDescripcion.Width = 130;
            // 
            // CCategoria
            // 
            this.CCategoria.HeaderText = "Categoria";
            this.CCategoria.Name = "CCategoria";
            this.CCategoria.ReadOnly = true;
            this.CCategoria.Width = 80;
            // 
            // Cprecio
            // 
            this.Cprecio.HeaderText = "Precio";
            this.Cprecio.Name = "Cprecio";
            this.Cprecio.ReadOnly = true;
            // 
            // Ccantidad
            // 
            this.Ccantidad.HeaderText = "Cantidad";
            this.Ccantidad.Name = "Ccantidad";
            this.Ccantidad.ReadOnly = true;
            this.Ccantidad.Width = 60;
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
            this.labmontocambio.Location = new System.Drawing.Point(434, 510);
            this.labmontocambio.Name = "labmontocambio";
            this.labmontocambio.Size = new System.Drawing.Size(78, 13);
            this.labmontocambio.TabIndex = 47;
            this.labmontocambio.Text = "Monto Cambio:";
            // 
            // labmontopago
            // 
            this.labmontopago.AutoSize = true;
            this.labmontopago.BackColor = System.Drawing.Color.White;
            this.labmontopago.Location = new System.Drawing.Point(282, 510);
            this.labmontopago.Name = "labmontopago";
            this.labmontopago.Size = new System.Drawing.Size(68, 13);
            this.labmontopago.TabIndex = 48;
            this.labmontopago.Text = "Monto Pago:";
            // 
            // labmontototal
            // 
            this.labmontototal.AutoSize = true;
            this.labmontototal.BackColor = System.Drawing.Color.White;
            this.labmontototal.Location = new System.Drawing.Point(118, 510);
            this.labmontototal.Name = "labmontototal";
            this.labmontototal.Size = new System.Drawing.Size(67, 13);
            this.labmontototal.TabIndex = 49;
            this.labmontototal.Text = "Monto Total:";
            // 
            // TCambio
            // 
            this.TCambio.Location = new System.Drawing.Point(515, 507);
            this.TCambio.Name = "TCambio";
            this.TCambio.ReadOnly = true;
            this.TCambio.Size = new System.Drawing.Size(83, 20);
            this.TCambio.TabIndex = 11;
            // 
            // TPago
            // 
            this.TPago.Location = new System.Drawing.Point(354, 507);
            this.TPago.Name = "TPago";
            this.TPago.ReadOnly = true;
            this.TPago.Size = new System.Drawing.Size(74, 20);
            this.TPago.TabIndex = 10;
            // 
            // TTotal
            // 
            this.TTotal.Location = new System.Drawing.Point(189, 507);
            this.TTotal.Name = "TTotal";
            this.TTotal.ReadOnly = true;
            this.TTotal.Size = new System.Drawing.Size(78, 20);
            this.TTotal.TabIndex = 9;
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
            this.iconButton1.Location = new System.Drawing.Point(604, 500);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(149, 32);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "Descargar en Pdf";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // FormDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 561);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.TCambio);
            this.Controls.Add(this.TPago);
            this.Controls.Add(this.TTotal);
            this.Controls.Add(this.labmontototal);
            this.Controls.Add(this.labmontopago);
            this.Controls.Add(this.labmontocambio);
            this.Controls.Add(this.DGDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FormDetalleVenta";
            this.Text = "Detalle Venta";
            this.Load += new System.EventHandler(this.DetalleVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TVendedor;
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.TextBox TFecha;
        private System.Windows.Forms.Label Ltipodoc;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.TextBox TIdVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.Label labeldocucliente;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.DataGridView DGDetalle;
        private System.Windows.Forms.TextBox TPago;
        private System.Windows.Forms.TextBox TCambio;
        private System.Windows.Forms.Label labmontocambio;
        private System.Windows.Forms.Label labmontopago;
        private System.Windows.Forms.Label labmontototal;
        private System.Windows.Forms.TextBox TTotal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox TDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csubtotal;
    }
}