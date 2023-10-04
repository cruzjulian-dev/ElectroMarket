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
            this.icoBtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.DGCategoria = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CestadoVAlor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ceditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.BEditar = new FontAwesome.Sharp.IconButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.icoBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.BGuardar = new FontAwesome.Sharp.IconButton();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.TDescripcion = new System.Windows.Forms.TextBox();
            this.lEstado = new System.Windows.Forms.Label();
            this.codigoProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.BLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGCategoria)).BeginInit();
            this.SuspendLayout();
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
            this.icoBtnLimpiar.Location = new System.Drawing.Point(880, 54);
            this.icoBtnLimpiar.Name = "icoBtnLimpiar";
            this.icoBtnLimpiar.Size = new System.Drawing.Size(35, 33);
            this.icoBtnLimpiar.TabIndex = 48;
            this.icoBtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.id,
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
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Cdescripcion
            // 
            this.Cdescripcion.HeaderText = "Descripcion";
            this.Cdescripcion.Name = "Cdescripcion";
            this.Cdescripcion.ReadOnly = true;
            // 
            // Cestado
            // 
            this.Cestado.HeaderText = "Estado";
            this.Cestado.Name = "Cestado";
            this.Cestado.ReadOnly = true;
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 30);
            this.label2.TabIndex = 41;
            this.label2.Text = "Detalle Categoria";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.DarkCyan;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEditar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(733, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 47;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.BackColor = System.Drawing.Color.White;
            this.cboBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(641, 61);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(86, 21);
            this.cboBusqueda.TabIndex = 46;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(573, 64);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 13);
            this.lblBuscar.TabIndex = 45;
            this.lblBuscar.Text = "Buscar Por:";
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
            this.icoBtnBuscar.Location = new System.Drawing.Point(839, 54);
            this.icoBtnBuscar.Name = "icoBtnBuscar";
            this.icoBtnBuscar.Size = new System.Drawing.Size(35, 33);
            this.icoBtnBuscar.TabIndex = 49;
            this.icoBtnBuscar.UseVisualStyleBackColor = false;
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BGuardar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TDescripcion.Location = new System.Drawing.Point(39, 117);
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.Size = new System.Drawing.Size(180, 20);
            this.TDescripcion.TabIndex = 32;
            this.TDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.BackColor = System.Drawing.Color.White;
            this.lEstado.Location = new System.Drawing.Point(35, 139);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(43, 13);
            this.lEstado.TabIndex = 31;
            this.lEstado.Text = "Estado:";
            // 
            // codigoProd
            // 
            this.codigoProd.AutoSize = true;
            this.codigoProd.BackColor = System.Drawing.Color.White;
            this.codigoProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.codigoProd.Location = new System.Drawing.Point(35, 100);
            this.codigoProd.Name = "codigoProd";
            this.codigoProd.Size = new System.Drawing.Size(66, 13);
            this.codigoProd.TabIndex = 28;
            this.codigoProd.Text = "Descripcion:";
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
            this.BLimpiar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // CategoriasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.icoBtnLimpiar);
            this.Controls.Add(this.DGCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.icoBtnBuscar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.TDescripcion);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.codigoProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.label3);
            this.Name = "CategoriasAdmin";
            this.Text = "FormCategorias";
            this.Load += new System.EventHandler(this.CategoriasAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton icoBtnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGCategoria;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BEditar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private FontAwesome.Sharp.IconButton icoBtnBuscar;
        private FontAwesome.Sharp.IconButton BGuardar;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.TextBox TDescripcion;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.Label codigoProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CestadoVAlor;
        private System.Windows.Forms.DataGridViewButtonColumn Ceditar;
        private FontAwesome.Sharp.IconButton BLimpiar;
    }
}