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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridProd = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.icoBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.icoBtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.CDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaNacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(689, 77);
            this.label3.TabIndex = 21;
            this.label3.Text = "Lista de Clientes:";
            // 
            // datagridProd
            // 
            this.datagridProd.AllowUserToAddRows = false;
            this.datagridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDni,
            this.CNombre,
            this.Apellido,
            this.CTelefono,
            this.CDomicilio,
            this.CFechaNacim});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridProd.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagridProd.Location = new System.Drawing.Point(12, 116);
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
            this.datagridProd.Size = new System.Drawing.Size(689, 209);
            this.datagridProd.TabIndex = 5;
            this.datagridProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridProd_CellDoubleClick);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(483, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.BackColor = System.Drawing.Color.White;
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Items.AddRange(new object[] {
            "ID",
            "DNI",
            "Nombre",
            "Apellido"});
            this.cboBusqueda.Location = new System.Drawing.Point(391, 54);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(86, 21);
            this.cboBusqueda.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(323, 57);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 13);
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
            this.icoBtnBuscar.Location = new System.Drawing.Point(589, 47);
            this.icoBtnBuscar.Name = "icoBtnBuscar";
            this.icoBtnBuscar.Size = new System.Drawing.Size(35, 33);
            this.icoBtnBuscar.TabIndex = 3;
            this.icoBtnBuscar.UseVisualStyleBackColor = false;
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
            this.icoBtnLimpiar.Location = new System.Drawing.Point(630, 47);
            this.icoBtnLimpiar.Name = "icoBtnLimpiar";
            this.icoBtnLimpiar.Size = new System.Drawing.Size(35, 33);
            this.icoBtnLimpiar.TabIndex = 4;
            this.icoBtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // CDni
            // 
            this.CDni.HeaderText = "DNI";
            this.CDni.Name = "CDni";
            this.CDni.ReadOnly = true;
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
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
            // CFechaNacim
            // 
            this.CFechaNacim.HeaderText = "Fecha de Nacimiento";
            this.CFechaNacim.Name = "CFechaNacim";
            this.CFechaNacim.ReadOnly = true;
            // 
            // mdClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 333);
            this.Controls.Add(this.icoBtnBuscar);
            this.Controls.Add(this.icoBtnLimpiar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagridProd);
            this.Name = "mdClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProveedor";
            this.Load += new System.EventHandler(this.mdProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datagridProd;
        private FontAwesome.Sharp.IconButton icoBtnBuscar;
        private FontAwesome.Sharp.IconButton icoBtnLimpiar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaNacim;
    }
}