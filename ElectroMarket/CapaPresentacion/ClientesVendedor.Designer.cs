namespace CapaPresentacion
{
    partial class ClientesVendedor
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
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LDomicilio = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TDomicilio = new System.Windows.Forms.TextBox();
            this.DGClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.BGuardar = new FontAwesome.Sharp.IconButton();
            this.TId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BEditar = new FontAwesome.Sharp.IconButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(22, 133);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(47, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            this.LNombre.Click += new System.EventHandler(this.LNombre_Click);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(22, 195);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(47, 13);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            this.LApellido.Click += new System.EventHandler(this.LApellido_Click);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(22, 259);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(29, 13);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI:";
            this.LDni.Click += new System.EventHandler(this.LDni_Click);
            // 
            // LDomicilio
            // 
            this.LDomicilio.AutoSize = true;
            this.LDomicilio.Location = new System.Drawing.Point(22, 393);
            this.LDomicilio.Name = "LDomicilio";
            this.LDomicilio.Size = new System.Drawing.Size(52, 13);
            this.LDomicilio.TabIndex = 3;
            this.LDomicilio.Text = "Domicilio:";
            this.LDomicilio.Click += new System.EventHandler(this.label4_Click);
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(22, 326);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(111, 13);
            this.LFecha.TabIndex = 4;
            this.LFecha.Text = "Fecha de Nacimiento:";
            this.LFecha.Click += new System.EventHandler(this.label5_Click);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(21, 149);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(160, 20);
            this.TNombre.TabIndex = 2;
            this.TNombre.TextChanged += new System.EventHandler(this.TNombre_TextChanged);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(21, 275);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(160, 20);
            this.TDni.TabIndex = 4;
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(21, 211);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(160, 20);
            this.TApellido.TabIndex = 3;
            this.TApellido.TextChanged += new System.EventHandler(this.TApellido_TextChanged);
            // 
            // TDomicilio
            // 
            this.TDomicilio.Location = new System.Drawing.Point(21, 409);
            this.TDomicilio.Name = "TDomicilio";
            this.TDomicilio.Size = new System.Drawing.Size(160, 20);
            this.TDomicilio.TabIndex = 6;
            this.TDomicilio.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // DGClientes
            // 
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.FechaNacim,
            this.Domicilio,
            this.Editar});
            this.DGClientes.Location = new System.Drawing.Point(238, 134);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.Size = new System.Drawing.Size(734, 373);
            this.DGClientes.TabIndex = 13;
            this.DGClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCliente_CellContentClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(244, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(594, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "Lista de Clientes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DTFecha
            // 
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFecha.Location = new System.Drawing.Point(25, 342);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(156, 20);
            this.DTFecha.TabIndex = 5;
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BGuardar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.BGuardar.IconColor = System.Drawing.Color.White;
            this.BGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGuardar.IconSize = 23;
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(21, 460);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(180, 33);
            this.BGuardar.TabIndex = 18;
            this.BGuardar.Text = "Agregar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // TId
            // 
            this.TId.Location = new System.Drawing.Point(45, 86);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(136, 20);
            this.TId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID:";
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.DarkCyan;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEditar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.ForeColor = System.Drawing.Color.White;
            this.BEditar.IconChar = FontAwesome.Sharp.IconChar.EarthAmericas;
            this.BEditar.IconColor = System.Drawing.Color.White;
            this.BEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BEditar.IconSize = 23;
            this.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditar.Location = new System.Drawing.Point(21, 499);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(180, 33);
            this.BEditar.TabIndex = 19;
            this.BEditar.Text = "Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // FechaNacim
            // 
            this.FechaNacim.HeaderText = "Fecha de Nacimiento";
            this.FechaNacim.Name = "FechaNacim";
            this.FechaNacim.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "Editar";
            // 
            // ClientesVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.DGClientes);
            this.Controls.Add(this.TDomicilio);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LDomicilio);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Name = "ClientesVendedor";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LDomicilio;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TDomicilio;
        private System.Windows.Forms.DataGridView DGClientes;
        private FontAwesome.Sharp.IconButton BGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.TextBox TId;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}