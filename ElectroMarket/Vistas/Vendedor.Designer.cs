namespace ElectroMarket.Vistas
{
    partial class Vendedor
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
            this.TBVendedor = new System.Windows.Forms.TabControl();
            this.TBCliente = new System.Windows.Forms.TabPage();
            this.TBVenta = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBVendedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBVendedor
            // 
            this.TBVendedor.Controls.Add(this.TBCliente);
            this.TBVendedor.Controls.Add(this.TBVenta);
            this.TBVendedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.TBVendedor.Location = new System.Drawing.Point(3, 3);
            this.TBVendedor.Name = "TBVendedor";
            this.TBVendedor.SelectedIndex = 0;
            this.TBVendedor.Size = new System.Drawing.Size(797, 444);
            this.TBVendedor.TabIndex = 0;
            // 
            // TBCliente
            // 
            this.TBCliente.Location = new System.Drawing.Point(4, 22);
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.Padding = new System.Windows.Forms.Padding(3);
            this.TBCliente.Size = new System.Drawing.Size(789, 418);
            this.TBCliente.TabIndex = 0;
            this.TBCliente.Text = "Agregar Cliente";
            this.TBCliente.UseVisualStyleBackColor = true;
            // 
            // TBVenta
            // 
            this.TBVenta.Location = new System.Drawing.Point(4, 22);
            this.TBVenta.Name = "TBVenta";
            this.TBVenta.Padding = new System.Windows.Forms.Padding(3);
            this.TBVenta.Size = new System.Drawing.Size(789, 418);
            this.TBVenta.TabIndex = 1;
            this.TBVenta.Text = "Venta";
            this.TBVenta.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBVendedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Vendedor";
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.Vendedor_Load);
            this.TBVendedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TBVendedor;
        private System.Windows.Forms.TabPage TBCliente;
        private System.Windows.Forms.TabPage TBVenta;
        private System.Windows.Forms.Panel panel1;
    }
}