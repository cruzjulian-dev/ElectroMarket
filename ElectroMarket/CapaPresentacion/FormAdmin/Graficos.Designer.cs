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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartProdPorCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdTop5)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProdPorCat
            // 
            chartArea7.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea7.Name = "ChartArea1";
            this.chartProdPorCat.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartProdPorCat.Legends.Add(legend7);
            this.chartProdPorCat.Location = new System.Drawing.Point(12, 129);
            this.chartProdPorCat.Name = "chartProdPorCat";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartProdPorCat.Series.Add(series7);
            this.chartProdPorCat.Size = new System.Drawing.Size(530, 390);
            this.chartProdPorCat.TabIndex = 0;
            this.chartProdPorCat.Text = "chart1";
            this.chartProdPorCat.Click += new System.EventHandler(this.chartProdPorCat_Click);
            // 
            // chartProdTop5
            // 
            chartArea8.Name = "ChartArea1";
            this.chartProdTop5.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartProdTop5.Legends.Add(legend8);
            this.chartProdTop5.Location = new System.Drawing.Point(608, 129);
            this.chartProdTop5.Name = "chartProdTop5";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series8.IsValueShownAsLabel = true;
            series8.LabelForeColor = System.Drawing.Color.White;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartProdTop5.Series.Add(series8);
            this.chartProdTop5.Size = new System.Drawing.Size(530, 390);
            this.chartProdTop5.TabIndex = 1;
            this.chartProdTop5.Text = "chart1";
            // 
            // lblProductoMasVendido
            // 
            this.lblProductoMasVendido.BackColor = System.Drawing.Color.White;
            this.lblProductoMasVendido.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoMasVendido.Location = new System.Drawing.Point(610, 524);
            this.lblProductoMasVendido.Name = "lblProductoMasVendido";
            this.lblProductoMasVendido.Size = new System.Drawing.Size(487, 30);
            this.lblProductoMasVendido.TabIndex = 22;
            this.lblProductoMasVendido.Text = "hhh";
            this.lblProductoMasVendido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButtonClientes
            // 
            this.radioButtonClientes.AutoSize = true;
            this.radioButtonClientes.Location = new System.Drawing.Point(32, 94);
            this.radioButtonClientes.Name = "radioButtonClientes";
            this.radioButtonClientes.Size = new System.Drawing.Size(179, 17);
            this.radioButtonClientes.TabIndex = 24;
            this.radioButtonClientes.TabStop = true;
            this.radioButtonClientes.Text = "TOP3 Clientes con mas compras";
            this.radioButtonClientes.UseVisualStyleBackColor = true;
            // 
            // radioButtonCantProd
            // 
            this.radioButtonCantProd.AutoSize = true;
            this.radioButtonCantProd.Location = new System.Drawing.Point(244, 94);
            this.radioButtonCantProd.Name = "radioButtonCantProd";
            this.radioButtonCantProd.Size = new System.Drawing.Size(189, 17);
            this.radioButtonCantProd.TabIndex = 25;
            this.radioButtonCantProd.TabStop = true;
            this.radioButtonCantProd.Text = "Cantidad Productos por Categorias";
            this.radioButtonCantProd.UseVisualStyleBackColor = true;
            // 
            // lblCliente1
            // 
            this.lblCliente1.BackColor = System.Drawing.Color.White;
            this.lblCliente1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente1.Location = new System.Drawing.Point(29, 524);
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
            this.label8.Location = new System.Drawing.Point(0, -2);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(1186, 51);
            this.label8.TabIndex = 83;
            this.label8.Text = "Filtrar por fechas:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.iconButton1.Location = new System.Drawing.Point(979, 6);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(118, 37);
            this.iconButton1.TabIndex = 88;
            this.iconButton1.Text = "Filtrar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.DTHasta);
            this.Controls.Add(this.DTDesde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCliente1);
            this.Controls.Add(this.radioButtonCantProd);
            this.Controls.Add(this.radioButtonClientes);
            this.Controls.Add(this.lblProductoMasVendido);
            this.Controls.Add(this.chartProdTop5);
            this.Controls.Add(this.chartProdPorCat);
            this.Name = "Graficos";
            this.Text = "Graficos";
            this.Load += new System.EventHandler(this.Graficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdPorCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdTop5)).EndInit();
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
    }
}