namespace CapaPresentacion
{
    partial class ListaProductos
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
            this.TBusqueda = new System.Windows.Forms.TextBox();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.DGProductos = new System.Windows.Forms.DataGridView();
            this.ccodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BBuscar = new FontAwesome.Sharp.IconButton();
            this.BMostrar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // TBusqueda
            // 
            this.TBusqueda.BackColor = System.Drawing.Color.White;
            this.TBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusqueda.Location = new System.Drawing.Point(575, 75);
            this.TBusqueda.Name = "TBusqueda";
            this.TBusqueda.Size = new System.Drawing.Size(100, 21);
            this.TBusqueda.TabIndex = 2;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.BackColor = System.Drawing.Color.White;
            this.CBBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(483, 74);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(86, 21);
            this.CBBusqueda.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(403, 77);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(74, 13);
            this.lblBuscar.TabIndex = 41;
            this.lblBuscar.Text = "Buscar Por:";
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToAddRows = false;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccodigo,
            this.cnombre,
            this.CDescripcion,
            this.CPrecio,
            this.cstock,
            this.CIdCategoria,
            this.ccategoria,
            this.CEstado,
            this.CEstadoValor,
            this.CSeleccionar,
            this.CId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGProductos.Location = new System.Drawing.Point(28, 136);
            this.DGProductos.MultiSelect = false;
            this.DGProductos.Name = "DGProductos";
            this.DGProductos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGProductos.RowTemplate.Height = 28;
            this.DGProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProductos.Size = new System.Drawing.Size(743, 403);
            this.DGProductos.TabIndex = 5;
            this.DGProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProductos_CellClick);
            this.DGProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridProd_CellContentClick);
            this.DGProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGProductos_CellFormatting);
            this.DGProductos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DGProductos_RowPrePaint);
            // 
            // ccodigo
            // 
            this.ccodigo.HeaderText = "Codigo";
            this.ccodigo.Name = "ccodigo";
            this.ccodigo.ReadOnly = true;
            this.ccodigo.Width = 60;
            // 
            // cnombre
            // 
            this.cnombre.HeaderText = "Nombre";
            this.cnombre.Name = "cnombre";
            this.cnombre.ReadOnly = true;
            this.cnombre.Width = 125;
            // 
            // CDescripcion
            // 
            this.CDescripcion.HeaderText = "Descripcion";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            this.CDescripcion.Width = 130;
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.ReadOnly = true;
            this.CPrecio.Width = 120;
            // 
            // cstock
            // 
            this.cstock.HeaderText = "Stock";
            this.cstock.Name = "cstock";
            this.cstock.ReadOnly = true;
            this.cstock.Width = 65;
            // 
            // CIdCategoria
            // 
            this.CIdCategoria.HeaderText = "IdCategoria";
            this.CIdCategoria.Name = "CIdCategoria";
            this.CIdCategoria.ReadOnly = true;
            this.CIdCategoria.Visible = false;
            // 
            // ccategoria
            // 
            this.ccategoria.HeaderText = "Categoria";
            this.ccategoria.Name = "ccategoria";
            this.ccategoria.ReadOnly = true;
            this.ccategoria.Width = 120;
            // 
            // CEstado
            // 
            this.CEstado.HeaderText = "Estado";
            this.CEstado.Name = "CEstado";
            this.CEstado.ReadOnly = true;
            this.CEstado.Visible = false;
            // 
            // CEstadoValor
            // 
            this.CEstadoValor.HeaderText = "EstadoValor";
            this.CEstadoValor.Name = "CEstadoValor";
            this.CEstadoValor.ReadOnly = true;
            this.CEstadoValor.Visible = false;
            // 
            // CSeleccionar
            // 
            this.CSeleccionar.HeaderText = "Seleccionar";
            this.CSeleccionar.Name = "CSeleccionar";
            this.CSeleccionar.ReadOnly = true;
            this.CSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CSeleccionar.Width = 80;
            // 
            // CId
            // 
            this.CId.HeaderText = "IdProd";
            this.CId.Name = "CId";
            this.CId.ReadOnly = true;
            this.CId.Visible = false;
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
            this.BBuscar.Location = new System.Drawing.Point(681, 67);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(35, 33);
            this.BBuscar.TabIndex = 3;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.icoBtnBuscar_Click);
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
            this.BMostrar.Location = new System.Drawing.Point(722, 67);
            this.BMostrar.Name = "BMostrar";
            this.BMostrar.Size = new System.Drawing.Size(35, 33);
            this.BMostrar.TabIndex = 4;
            this.BMostrar.UseVisualStyleBackColor = false;
            this.BMostrar.Click += new System.EventHandler(this.icoBtnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(28, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(743, 77);
            this.label3.TabIndex = 40;
            this.label3.Text = "Lista de Productos:";
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 561);
            this.Controls.Add(this.TBusqueda);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.DGProductos);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.BMostrar);
            this.Controls.Add(this.label3);
            this.Name = "ListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductosVendedor";
            this.Load += new System.EventHandler(this.ListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBusqueda;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView DGProductos;
        private FontAwesome.Sharp.IconButton BBuscar;
        private FontAwesome.Sharp.IconButton BMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstadoValor;
        private System.Windows.Forms.DataGridViewButtonColumn CSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
    }
}