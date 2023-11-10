namespace CapaPresentacion
{
    partial class MisVentas
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
            this.DGMisVentas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.LVentas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DTDesde = new System.Windows.Forms.DateTimePicker();
            this.DTHasta = new System.Windows.Forms.DateTimePicker();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BBuscar = new FontAwesome.Sharp.IconButton();
            this.BMostrar = new FontAwesome.Sharp.IconButton();
            this.TBusqueda = new System.Windows.Forms.TextBox();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CForma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGMisVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGMisVentas
            // 
            this.DGMisVentas.AllowUserToAddRows = false;
            this.DGMisVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMisVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdVenta,
            this.CNumDoc,
            this.CVendedor,
            this.CDniCliente,
            this.CNombreCliente,
            this.CApellidoCliente,
            this.CTotal,
            this.CForma,
            this.CFecha,
            this.CDetalle});
            this.DGMisVentas.Location = new System.Drawing.Point(296, 114);
            this.DGMisVentas.Name = "DGMisVentas";
            this.DGMisVentas.Size = new System.Drawing.Size(843, 371);
            this.DGMisVentas.TabIndex = 12;
            this.DGMisVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(870, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total vendido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de ventas realizadas:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "Mis Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 561);
            this.label4.TabIndex = 59;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.Location = new System.Drawing.Point(1001, 502);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(26, 18);
            this.LTotal.TabIndex = 60;
            this.LTotal.Text = "...";
            // 
            // LVentas
            // 
            this.LVentas.AutoSize = true;
            this.LVentas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVentas.Location = new System.Drawing.Point(564, 502);
            this.LVentas.Name = "LVentas";
            this.LVentas.Size = new System.Drawing.Size(26, 18);
            this.LVentas.TabIndex = 61;
            this.LVentas.Text = "...";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 122);
            this.label5.TabIndex = 62;
            this.label5.Text = "Seleccione el rango de fechas en el que desea filtrar sus ventas. Por defecto, la" +
    "s ventas se cargan desde la más recientes a las más antiguas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "Desde:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Hasta:";
            // 
            // DTDesde
            // 
            this.DTDesde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTDesde.Location = new System.Drawing.Point(30, 281);
            this.DTDesde.Name = "DTDesde";
            this.DTDesde.Size = new System.Drawing.Size(200, 21);
            this.DTDesde.TabIndex = 65;
            // 
            // DTHasta
            // 
            this.DTHasta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTHasta.Location = new System.Drawing.Point(30, 380);
            this.DTHasta.Name = "DTHasta";
            this.DTHasta.Size = new System.Drawing.Size(200, 21);
            this.DTHasta.TabIndex = 66;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(48, 465);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(133, 55);
            this.iconButton1.TabIndex = 67;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.BBuscar.Location = new System.Drawing.Point(1053, 36);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(35, 33);
            this.BBuscar.TabIndex = 71;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
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
            this.BMostrar.Location = new System.Drawing.Point(1094, 36);
            this.BMostrar.Name = "BMostrar";
            this.BMostrar.Size = new System.Drawing.Size(35, 33);
            this.BMostrar.TabIndex = 73;
            this.BMostrar.UseVisualStyleBackColor = false;
            this.BMostrar.Click += new System.EventHandler(this.BMostrar_Click);
            // 
            // TBusqueda
            // 
            this.TBusqueda.BackColor = System.Drawing.Color.White;
            this.TBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusqueda.Location = new System.Drawing.Point(947, 44);
            this.TBusqueda.Name = "TBusqueda";
            this.TBusqueda.Size = new System.Drawing.Size(100, 21);
            this.TBusqueda.TabIndex = 70;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.BackColor = System.Drawing.Color.White;
            this.CBBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(829, 43);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(112, 21);
            this.CBBusqueda.TabIndex = 68;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(749, 48);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(74, 13);
            this.lblBuscar.TabIndex = 72;
            this.lblBuscar.Text = "Buscar Por:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(296, 25);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(847, 51);
            this.label8.TabIndex = 69;
            this.label8.Text = "Lista de Ventas:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CIdVenta
            // 
            this.CIdVenta.HeaderText = "IdVenta";
            this.CIdVenta.Name = "CIdVenta";
            this.CIdVenta.Visible = false;
            this.CIdVenta.Width = 90;
            // 
            // CNumDoc
            // 
            this.CNumDoc.HeaderText = "Num. Documento";
            this.CNumDoc.Name = "CNumDoc";
            this.CNumDoc.Width = 80;
            // 
            // CVendedor
            // 
            this.CVendedor.HeaderText = "Vendedor";
            this.CVendedor.Name = "CVendedor";
            this.CVendedor.ReadOnly = true;
            this.CVendedor.Visible = false;
            this.CVendedor.Width = 105;
            // 
            // CDniCliente
            // 
            this.CDniCliente.HeaderText = "DNI Cliente";
            this.CDniCliente.Name = "CDniCliente";
            this.CDniCliente.ReadOnly = true;
            // 
            // CNombreCliente
            // 
            this.CNombreCliente.HeaderText = "Nombre Cliente";
            this.CNombreCliente.Name = "CNombreCliente";
            this.CNombreCliente.ReadOnly = true;
            this.CNombreCliente.Width = 110;
            // 
            // CApellidoCliente
            // 
            this.CApellidoCliente.HeaderText = "Apellido Cliente";
            this.CApellidoCliente.Name = "CApellidoCliente";
            this.CApellidoCliente.ReadOnly = true;
            this.CApellidoCliente.Width = 110;
            // 
            // CTotal
            // 
            this.CTotal.HeaderText = "Monto Total";
            this.CTotal.Name = "CTotal";
            this.CTotal.ReadOnly = true;
            this.CTotal.Width = 120;
            // 
            // CForma
            // 
            this.CForma.HeaderText = "Forma de Pago";
            this.CForma.Name = "CForma";
            this.CForma.ReadOnly = true;
            this.CForma.Width = 110;
            // 
            // CFecha
            // 
            this.CFecha.HeaderText = "Fecha Venta";
            this.CFecha.Name = "CFecha";
            this.CFecha.ReadOnly = true;
            this.CFecha.Width = 95;
            // 
            // CDetalle
            // 
            this.CDetalle.HeaderText = "Ver detalle";
            this.CDetalle.Name = "CDetalle";
            this.CDetalle.ReadOnly = true;
            this.CDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CDetalle.Width = 80;
            // 
            // MisVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.BMostrar);
            this.Controls.Add(this.TBusqueda);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.DTHasta);
            this.Controls.Add(this.DTDesde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LVentas);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGMisVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MisVentas";
            this.Text = "Mis Ventas";
            this.Load += new System.EventHandler(this.MisVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGMisVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGMisVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label LVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTDesde;
        private System.Windows.Forms.DateTimePicker DTHasta;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BBuscar;
        private FontAwesome.Sharp.IconButton BMostrar;
        private System.Windows.Forms.TextBox TBusqueda;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CForma;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewButtonColumn CDetalle;
    }
}