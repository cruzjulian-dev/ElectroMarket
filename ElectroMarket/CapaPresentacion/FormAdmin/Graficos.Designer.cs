namespace CapaPresentacion.FormAdmin
{
    partial class Graficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProdPorCat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProdTop5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblProductoMasVendido = new System.Windows.Forms.Label();
            this.radioButtonClientes = new System.Windows.Forms.RadioButton();
            this.radioButtonCantProd = new System.Windows.Forms.RadioButton();
            this.lblCliente1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DTHasta = new System.Windows.Forms.DateTimePicker();
            this.DTDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.RBTopCategorias = new System.Windows.Forms.RadioButton();
            this.RBTop5Prod = new System.Windows.Forms.RadioButton();
            this.RBTopFormasPago = new System.Windows.Forms.RadioButton();
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.GB2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdPorCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdTop5)).BeginInit();
            this.GB1.SuspendLayout();
            this.GB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartProdPorCat
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartProdPorCat.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartProdPorCat.Legends.Add(legend1);
            this.chartProdPorCat.Location = new System.Drawing.Point(16, 105);
            this.chartProdPorCat.Name = "chartProdPorCat";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartProdPorCat.Series.Add(series1);
            this.chartProdPorCat.Size = new System.Drawing.Size(530, 390);
            this.chartProdPorCat.TabIndex = 0;
            this.chartProdPorCat.Text = "chart1";
            // 
            // chartProdTop5
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProdTop5.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProdTop5.Legends.Add(legend2);
            this.chartProdTop5.Location = new System.Drawing.Point(612, 105);
            this.chartProdTop5.Name = "chartProdTop5";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartProdTop5.Series.Add(series2);
            this.chartProdTop5.Size = new System.Drawing.Size(530, 390);
            this.chartProdTop5.TabIndex = 1;
            this.chartProdTop5.Text = "chart1";
            // 
            // lblProductoMasVendido
            // 
            this.lblProductoMasVendido.BackColor = System.Drawing.Color.White;
            this.lblProductoMasVendido.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoMasVendido.Location = new System.Drawing.Point(614, 500);
            this.lblProductoMasVendido.Name = "lblProductoMasVendido";
            this.lblProductoMasVendido.Size = new System.Drawing.Size(487, 30);
            this.lblProductoMasVendido.TabIndex = 22;
            this.lblProductoMasVendido.Text = "hhh";
            this.lblProductoMasVendido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButtonClientes
            // 
            this.radioButtonClientes.AutoSize = true;
            this.radioButtonClientes.Location = new System.Drawing.Point(7, 12);
            this.radioButtonClientes.Name = "radioButtonClientes";
            this.radioButtonClientes.Size = new System.Drawing.Size(182, 17);
            this.radioButtonClientes.TabIndex = 24;
            this.radioButtonClientes.TabStop = true;
            this.radioButtonClientes.Text = "TOP 5 Clientes con mas compras";
            this.radioButtonClientes.UseVisualStyleBackColor = true;
            // 
            // radioButtonCantProd
            // 
            this.radioButtonCantProd.AutoSize = true;
            this.radioButtonCantProd.Location = new System.Drawing.Point(246, 12);
            this.radioButtonCantProd.Name = "radioButtonCantProd";
            this.radioButtonCantProd.Size = new System.Drawing.Size(107, 17);
            this.radioButtonCantProd.TabIndex = 25;
            this.radioButtonCantProd.TabStop = true;
            this.radioButtonCantProd.Text = "TOP Vendedores";
            this.radioButtonCantProd.UseVisualStyleBackColor = true;
            // 
            // lblCliente1
            // 
            this.lblCliente1.BackColor = System.Drawing.Color.White;
            this.lblCliente1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente1.Location = new System.Drawing.Point(33, 500);
            this.lblCliente1.Name = "lblCliente1";
            this.lblCliente1.Size = new System.Drawing.Size(477, 30);
            this.lblCliente1.TabIndex = 26;
            this.lblCliente1.Text = "hhh";
            this.lblCliente1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(0, 1);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(1183, 51);
            this.label8.TabIndex = 83;
            this.label8.Text = "Filtrar por fechas:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // DTHasta
            // 
            this.DTHasta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTHasta.Location = new System.Drawing.Point(711, 14);
            this.DTHasta.Name = "DTHasta";
            this.DTHasta.Size = new System.Drawing.Size(200, 21);
            this.DTHasta.TabIndex = 87;
            // 
            // DTDesde
            // 
            this.DTDesde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTDesde.Location = new System.Drawing.Point(371, 15);
            this.DTDesde.Name = "DTDesde";
            this.DTDesde.Size = new System.Drawing.Size(200, 21);
            this.DTDesde.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 85;
            this.label7.Text = "Hasta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 84;
            this.label6.Text = "Desde:";
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 27;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(970, 6);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(118, 37);
            this.iconButton1.TabIndex = 88;
            this.iconButton1.Text = "Filtrar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // RBTopCategorias
            // 
            this.RBTopCategorias.AutoSize = true;
            this.RBTopCategorias.Location = new System.Drawing.Point(208, 14);
            this.RBTopCategorias.Name = "RBTopCategorias";
            this.RBTopCategorias.Size = new System.Drawing.Size(145, 17);
            this.RBTopCategorias.TabIndex = 91;
            this.RBTopCategorias.TabStop = true;
            this.RBTopCategorias.Text = "Categorías más vendidas";
            this.RBTopCategorias.UseVisualStyleBackColor = true;
            this.RBTopCategorias.CheckedChanged += new System.EventHandler(this.RBTopCategorias_CheckedChanged);
            // 
            // RBTop5Prod
            // 
            this.RBTop5Prod.AutoSize = true;
            this.RBTop5Prod.Location = new System.Drawing.Point(17, 14);
            this.RBTop5Prod.Name = "RBTop5Prod";
            this.RBTop5Prod.Size = new System.Drawing.Size(175, 17);
            this.RBTop5Prod.TabIndex = 90;
            this.RBTop5Prod.TabStop = true;
            this.RBTop5Prod.Text = "TOP 5 Productos más vendidos";
            this.RBTop5Prod.UseVisualStyleBackColor = true;
            // 
            // RBTopFormasPago
            // 
            this.RBTopFormasPago.AutoSize = true;
            this.RBTopFormasPago.Location = new System.Drawing.Point(374, 14);
            this.RBTopFormasPago.Name = "RBTopFormasPago";
            this.RBTopFormasPago.Size = new System.Drawing.Size(150, 17);
            this.RBTopFormasPago.TabIndex = 92;
            this.RBTopFormasPago.TabStop = true;
            this.RBTopFormasPago.Text = "Formas de pago preferidos";
            this.RBTopFormasPago.UseVisualStyleBackColor = true;
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.radioButtonCantProd);
            this.GB1.Controls.Add(this.radioButtonClientes);
            this.GB1.Location = new System.Drawing.Point(29, 58);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(449, 37);
            this.GB1.TabIndex = 93;
            this.GB1.TabStop = false;
            // 
            // GB2
            // 
            this.GB2.Controls.Add(this.RBTopFormasPago);
            this.GB2.Controls.Add(this.RBTopCategorias);
            this.GB2.Controls.Add(this.RBTop5Prod);
            this.GB2.Location = new System.Drawing.Point(611, 56);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(546, 38);
            this.GB2.TabIndex = 94;
            this.GB2.TabStop = false;
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.GB2);
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.DTHasta);
            this.Controls.Add(this.DTDesde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCliente1);
            this.Controls.Add(this.lblProductoMasVendido);
            this.Controls.Add(this.chartProdTop5);
            this.Controls.Add(this.chartProdPorCat);
            this.Name = "Graficos";
            this.Text = "Graficos";
            this.Load += new System.EventHandler(this.Graficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdPorCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdTop5)).EndInit();
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            this.GB2.ResumeLayout(false);
            this.GB2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdPorCat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdTop5;
        private System.Windows.Forms.Label lblProductoMasVendido;
        private System.Windows.Forms.RadioButton radioButtonClientes;
        private System.Windows.Forms.RadioButton radioButtonCantProd;
        private System.Windows.Forms.Label lblCliente1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DTHasta;
        private System.Windows.Forms.DateTimePicker DTDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.RadioButton RBTopCategorias;
        private System.Windows.Forms.RadioButton RBTop5Prod;
        private System.Windows.Forms.RadioButton RBTopFormasPago;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.GroupBox GB2;
    }
}