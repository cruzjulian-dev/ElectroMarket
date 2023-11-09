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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProdPorCat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProdTop5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblProductoMasVendido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdPorCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdTop5)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProdPorCat
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.Name = "ChartArea1";
            this.chartProdPorCat.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartProdPorCat.Legends.Add(legend3);
            this.chartProdPorCat.Location = new System.Drawing.Point(12, 129);
            this.chartProdPorCat.Name = "chartProdPorCat";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartProdPorCat.Series.Add(series3);
            this.chartProdPorCat.Size = new System.Drawing.Size(530, 390);
            this.chartProdPorCat.TabIndex = 0;
            this.chartProdPorCat.Text = "chart1";
            this.chartProdPorCat.Click += new System.EventHandler(this.chartProdPorCat_Click);
            // 
            // chartProdTop5
            // 
            chartArea4.Name = "ChartArea1";
            this.chartProdTop5.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartProdTop5.Legends.Add(legend4);
            this.chartProdTop5.Location = new System.Drawing.Point(608, 129);
            this.chartProdTop5.Name = "chartProdTop5";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartProdTop5.Series.Add(series4);
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
            this.lblProductoMasVendido.Size = new System.Drawing.Size(404, 30);
            this.lblProductoMasVendido.TabIndex = 22;
            this.lblProductoMasVendido.Text = "hhh";
            this.lblProductoMasVendido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblProductoMasVendido);
            this.Controls.Add(this.chartProdTop5);
            this.Controls.Add(this.chartProdPorCat);
            this.Name = "Graficos";
            this.Text = "Graficos";
            this.Load += new System.EventHandler(this.Graficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdPorCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdTop5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdPorCat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdTop5;
        private System.Windows.Forms.Label lblProductoMasVendido;
    }
}