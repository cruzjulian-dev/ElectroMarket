﻿namespace CapaPresentacion.Modales
{
    partial class mdProductos
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridProd = new System.Windows.Forms.DataGridView();
            this.icoBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.icoBtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cprecioven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.Location = new System.Drawing.Point(543, 65);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 2;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.BackColor = System.Drawing.Color.White;
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Items.AddRange(new object[] {
            "Nombre",
            "Categoria",
            "Codigo"});
            this.cboBusqueda.Location = new System.Drawing.Point(451, 64);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(86, 21);
            this.cboBusqueda.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(383, 67);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 13);
            this.lblBuscar.TabIndex = 34;
            this.lblBuscar.Text = "Buscar Por:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(729, 77);
            this.label3.TabIndex = 33;
            this.label3.Text = "Lista de Productos:";
            // 
            // datagridProd
            // 
            this.datagridProd.AllowUserToAddRows = false;
            this.datagridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ccodigo,
            this.cnombre,
            this.ccategoria,
            this.CDescripcion,
            this.cstock,
            this.cprecioven,
            this.CEstado});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridProd.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagridProd.Location = new System.Drawing.Point(12, 127);
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
            this.datagridProd.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridProd.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridProd.RowTemplate.Height = 28;
            this.datagridProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridProd.Size = new System.Drawing.Size(729, 209);
            this.datagridProd.TabIndex = 32;
            this.datagridProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridProd_CellDoubleClick);
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
            this.icoBtnBuscar.Location = new System.Drawing.Point(649, 57);
            this.icoBtnBuscar.Name = "icoBtnBuscar";
            this.icoBtnBuscar.Size = new System.Drawing.Size(35, 33);
            this.icoBtnBuscar.TabIndex = 3;
            this.icoBtnBuscar.UseVisualStyleBackColor = false;
            this.icoBtnBuscar.Click += new System.EventHandler(this.icoBtnBuscar_Click);
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
            this.icoBtnLimpiar.Location = new System.Drawing.Point(690, 57);
            this.icoBtnLimpiar.Name = "icoBtnLimpiar";
            this.icoBtnLimpiar.Size = new System.Drawing.Size(35, 33);
            this.icoBtnLimpiar.TabIndex = 4;
            this.icoBtnLimpiar.UseVisualStyleBackColor = false;
            this.icoBtnLimpiar.Click += new System.EventHandler(this.icoBtnLimpiar_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ccodigo
            // 
            this.ccodigo.HeaderText = "Codigo";
            this.ccodigo.Name = "ccodigo";
            this.ccodigo.ReadOnly = true;
            // 
            // cnombre
            // 
            this.cnombre.HeaderText = "Nombre";
            this.cnombre.Name = "cnombre";
            this.cnombre.ReadOnly = true;
            // 
            // ccategoria
            // 
            this.ccategoria.HeaderText = "Categoria";
            this.ccategoria.Name = "ccategoria";
            this.ccategoria.ReadOnly = true;
            // 
            // CDescripcion
            // 
            this.CDescripcion.HeaderText = "Descripcion";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            // 
            // cstock
            // 
            this.cstock.HeaderText = "Stock";
            this.cstock.Name = "cstock";
            this.cstock.ReadOnly = true;
            // 
            // cprecioven
            // 
            this.cprecioven.HeaderText = "Precio";
            this.cprecioven.Name = "cprecioven";
            this.cprecioven.ReadOnly = true;
            // 
            // CEstado
            // 
            this.CEstado.HeaderText = "Estado";
            this.CEstado.Name = "CEstado";
            this.CEstado.ReadOnly = true;
            // 
            // mdProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 350);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.datagridProd);
            this.Controls.Add(this.icoBtnBuscar);
            this.Controls.Add(this.icoBtnLimpiar);
            this.Controls.Add(this.label3);
            this.Name = "mdProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProductos";
            this.Load += new System.EventHandler(this.mdProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datagridProd;
        private FontAwesome.Sharp.IconButton icoBtnBuscar;
        private FontAwesome.Sharp.IconButton icoBtnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cprecioven;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
    }
}