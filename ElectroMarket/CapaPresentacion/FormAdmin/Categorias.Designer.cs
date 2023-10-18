namespace CapaPresentacion
{
    partial class CategoriasAdmin
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
            this.BMostrar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.DGCategoria = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BEditar = new FontAwesome.Sharp.IconButton();
            this.TBusqueda = new System.Windows.Forms.TextBox();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.BBuscar = new FontAwesome.Sharp.IconButton();
            this.BGuardar = new FontAwesome.Sharp.IconButton();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.TDescripcion = new System.Windows.Forms.TextBox();
            this.lEstado = new System.Windows.Forms.Label();
            this.codigoProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.BLimpiar = new FontAwesome.Sharp.IconButton();
            this.TIndice = new System.Windows.Forms.TextBox();
            this.TId = new System.Windows.Forms.TextBox();
            this.CIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CestadoVAlor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ceditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGCategoria)).BeginInit();
            this.SuspendLayout();
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
            this.BMostrar.Location = new System.Drawing.Point(880, 54);
            this.BMostrar.Name = "BMostrar";
            this.BMostrar.Size = new System.Drawing.Size(35, 33);
            this.BMostrar.TabIndex = 48;
            this.BMostrar.UseVisualStyleBackColor = false;
            this.BMostrar.Click += new System.EventHandler(this.BMostrar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(293, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(631, 51);
            this.label3.TabIndex = 43;
            this.label3.Text = "Lista de Categorias:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGCategoria
            // 
            this.DGCategoria.AllowUserToAddRows = false;
            this.DGCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdCategoria,
            this.Cdescripcion,
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
            this.DGCategoria.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGCategoria.Location = new System.Drawing.Point(298, 117);
            this.DGCategoria.MultiSelect = false;
            this.DGCategoria.Name = "DGCategoria";
            this.DGCategoria.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGCategoria.RowTemplate.Height = 28;
            this.DGCategoria.Size = new System.Drawing.Size(626, 312);
            this.DGCategoria.TabIndex = 42;
            this.DGCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGCategoria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGCategoria_CellFormatting);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 33);
            this.label2.TabIndex = 41;
            this.label2.Text = "Gestión de Categorias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BEditar.Location = new System.Drawing.Point(38, 242);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(180, 33);
            this.BEditar.TabIndex = 40;
            this.BEditar.Text = "Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // TBusqueda
            // 
            this.TBusqueda.BackColor = System.Drawing.Color.White;
            this.TBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusqueda.Location = new System.Drawing.Point(733, 62);
            this.TBusqueda.Name = "TBusqueda";
            this.TBusqueda.Size = new System.Drawing.Size(100, 21);
            this.TBusqueda.TabIndex = 47;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.BackColor = System.Drawing.Color.White;
            this.CBBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(641, 61);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(86, 21);
            this.CBBusqueda.TabIndex = 46;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(561, 64);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(74, 13);
            this.lblBuscar.TabIndex = 45;
            this.lblBuscar.Text = "Buscar Por:";
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
            this.BBuscar.Location = new System.Drawing.Point(839, 54);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(35, 33);
            this.BBuscar.TabIndex = 49;
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.icoBtnBuscar_Click);
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
            this.BGuardar.Location = new System.Drawing.Point(38, 203);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(180, 33);
            this.BGuardar.TabIndex = 39;
            this.BGuardar.Text = "Agregar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.Color.White;
            this.CBEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(38, 155);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(180, 21);
            this.CBEstado.TabIndex = 36;
            // 
            // TDescripcion
            // 
            this.TDescripcion.BackColor = System.Drawing.Color.White;
            this.TDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDescripcion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDescripcion.Location = new System.Drawing.Point(39, 117);
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.Size = new System.Drawing.Size(180, 21);
            this.TDescripcion.TabIndex = 32;
            this.TDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.BackColor = System.Drawing.Color.White;
            this.lEstado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.Location = new System.Drawing.Point(35, 139);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(50, 13);
            this.lEstado.TabIndex = 31;
            this.lEstado.Text = "Estado:";
            // 
            // codigoProd
            // 
            this.codigoProd.AutoSize = true;
            this.codigoProd.BackColor = System.Drawing.Color.White;
            this.codigoProd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.codigoProd.Location = new System.Drawing.Point(35, 100);
            this.codigoProd.Name = "codigoProd";
            this.codigoProd.Size = new System.Drawing.Size(78, 13);
            this.codigoProd.TabIndex = 28;
            this.codigoProd.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 561);
            this.label1.TabIndex = 37;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.BackColor = System.Drawing.Color.White;
            this.lNombre.Location = new System.Drawing.Point(40, 139);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(50, 13);
            this.lNombre.TabIndex = 27;
            this.lNombre.Text = "Nombre: ";
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.White;
            this.BLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BLimpiar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BLimpiar.IconColor = System.Drawing.Color.Black;
            this.BLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BLimpiar.IconSize = 23;
            this.BLimpiar.Location = new System.Drawing.Point(38, 281);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(180, 33);
            this.BLimpiar.TabIndex = 66;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // TIndice
            // 
            this.TIndice.Location = new System.Drawing.Point(225, 117);
            this.TIndice.Name = "TIndice";
            this.TIndice.Size = new System.Drawing.Size(33, 20);
            this.TIndice.TabIndex = 69;
            this.TIndice.Visible = false;
            // 
            // TId
            // 
            this.TId.Location = new System.Drawing.Point(225, 154);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(33, 20);
            this.TId.TabIndex = 68;
            this.TId.Visible = false;
            // 
            // CIdCategoria
            // 
            this.CIdCategoria.HeaderText = "id";
            this.CIdCategoria.Name = "CIdCategoria";
            this.CIdCategoria.ReadOnly = true;
            this.CIdCategoria.Visible = false;
            // 
            // Cdescripcion
            // 
            this.Cdescripcion.HeaderText = "Descripcion";
            this.Cdescripcion.Name = "Cdescripcion";
            this.Cdescripcion.ReadOnly = true;
            this.Cdescripcion.Width = 200;
            // 
            // Cestado
            // 
            this.Cestado.HeaderText = "Estado";
            this.Cestado.Name = "Cestado";
            this.Cestado.ReadOnly = true;
            this.Cestado.Width = 120;
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
            // 
            // CategoriasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(985, 561);
            this.Controls.Add(this.TIndice);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BMostrar);
            this.Controls.Add(this.DGCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.TBusqueda);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.TDescripcion);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.codigoProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.label3);
            this.Name = "CategoriasAdmin";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.CategoriasAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton BMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGCategoria;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BEditar;
        private System.Windows.Forms.TextBox TBusqueda;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private FontAwesome.Sharp.IconButton BBuscar;
        private FontAwesome.Sharp.IconButton BGuardar;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.TextBox TDescripcion;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.Label codigoProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombre;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private System.Windows.Forms.TextBox TIndice;
        private System.Windows.Forms.TextBox TId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CestadoVAlor;
        private System.Windows.Forms.DataGridViewButtonColumn Ceditar;
    }
}