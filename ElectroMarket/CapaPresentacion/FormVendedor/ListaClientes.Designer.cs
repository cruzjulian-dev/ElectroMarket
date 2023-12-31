﻿namespace CapaPresentacion.Modales
{
    partial class ListaClientes
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
            this.DGClientes = new System.Windows.Forms.DataGridView();
            this.CIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaNacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TBusqueda = new System.Windows.Forms.TextBox();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.icoBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.icoBtnLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(733, 77);
            this.label3.TabIndex = 21;
            this.label3.Text = "Lista de Clientes:";
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdCliente,
            this.CNombre,
            this.CApellido,
            this.CDni,
            this.CFechaNacim,
            this.CTelefono,
            this.CDomicilio,
            this.CSeleccionar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGClientes.Location = new System.Drawing.Point(12, 116);
            this.DGClientes.MultiSelect = false;
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGClientes.RowTemplate.Height = 28;
            this.DGClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientes.Size = new System.Drawing.Size(733, 209);
            this.DGClientes.TabIndex = 5;
            this.DGClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGClientes_CellContentClick);
            // 
            // CIdCliente
            // 
            this.CIdCliente.HeaderText = "IDCliente";
            this.CIdCliente.Name = "CIdCliente";
            this.CIdCliente.ReadOnly = true;
            this.CIdCliente.Visible = false;
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CApellido
            // 
            this.CApellido.HeaderText = "Apellido";
            this.CApellido.Name = "CApellido";
            this.CApellido.ReadOnly = true;
            // 
            // CDni
            // 
            this.CDni.HeaderText = "DNI";
            this.CDni.Name = "CDni";
            this.CDni.ReadOnly = true;
            // 
            // CFechaNacim
            // 
            this.CFechaNacim.HeaderText = "Fecha de Nacimiento";
            this.CFechaNacim.Name = "CFechaNacim";
            this.CFechaNacim.ReadOnly = true;
            // 
            // CTelefono
            // 
            this.CTelefono.HeaderText = "Telefono";
            this.CTelefono.Name = "CTelefono";
            this.CTelefono.ReadOnly = true;
            // 
            // CDomicilio
            // 
            this.CDomicilio.HeaderText = "Domicilio";
            this.CDomicilio.Name = "CDomicilio";
            this.CDomicilio.ReadOnly = true;
            // 
            // CSeleccionar
            // 
            this.CSeleccionar.HeaderText = "Seleccionar";
            this.CSeleccionar.Name = "CSeleccionar";
            this.CSeleccionar.ReadOnly = true;
            this.CSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CSeleccionar.Width = 90;
            // 
            // TBusqueda
            // 
            this.TBusqueda.BackColor = System.Drawing.Color.White;
            this.TBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusqueda.Location = new System.Drawing.Point(550, 54);
            this.TBusqueda.Name = "TBusqueda";
            this.TBusqueda.Size = new System.Drawing.Size(100, 21);
            this.TBusqueda.TabIndex = 2;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.BackColor = System.Drawing.Color.White;
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(458, 53);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(86, 21);
            this.CBBusqueda.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(378, 56);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(74, 13);
            this.lblBuscar.TabIndex = 27;
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
            this.icoBtnBuscar.Location = new System.Drawing.Point(656, 46);
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
            this.icoBtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.icoBtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.icoBtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnLimpiar.IconSize = 23;
            this.icoBtnLimpiar.Location = new System.Drawing.Point(697, 46);
            this.icoBtnLimpiar.Name = "icoBtnLimpiar";
            this.icoBtnLimpiar.Size = new System.Drawing.Size(35, 33);
            this.icoBtnLimpiar.TabIndex = 4;
            this.icoBtnLimpiar.UseVisualStyleBackColor = false;
            this.icoBtnLimpiar.Click += new System.EventHandler(this.icoBtnLimpiar_Click);
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 333);
            this.Controls.Add(this.icoBtnBuscar);
            this.Controls.Add(this.icoBtnLimpiar);
            this.Controls.Add(this.TBusqueda);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGClientes);
            this.Name = "ListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.mdProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGClientes;
        private FontAwesome.Sharp.IconButton icoBtnBuscar;
        private FontAwesome.Sharp.IconButton icoBtnLimpiar;
        private System.Windows.Forms.TextBox TBusqueda;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaNacim;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDomicilio;
        private System.Windows.Forms.DataGridViewButtonColumn CSeleccionar;
    }
}