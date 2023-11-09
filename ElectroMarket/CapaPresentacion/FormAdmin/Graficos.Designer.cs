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
            ((System.ComponentModel.ISupportInitialize)(this.chartProdPorCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdTop5)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProdPorCat
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chartProdPorCat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProdPorCat.Legends.Add(legend1);
            this.chartProdPorCat.Location = new System.Drawing.Point(12, 121);
            this.chartProdPorCat.Name = "chartProdPorCat";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProdPorCat.Series.Add(series1);
            this.chartProdPorCat.Size = new System.Drawing.Size(334, 368);
            this.chartProdPorCat.TabIndex = 0;
            this.chartProdPorCat.Text = "chart1";
            this.chartProdPorCat.Click += new System.EventHandler(this.chartProdPorCat_Click);
            // 
            // chartProdTop5
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProdTop5.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProdTop5.Legends.Add(legend2);
            this.chartProdTop5.Location = new System.Drawing.Point(505, 121);
            this.chartProdTop5.Name = "chartProdTop5";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartProdTop5.Series.Add(series2);
            this.chartProdTop5.Size = new System.Drawing.Size(408, 368);
            this.chartProdTop5.TabIndex = 1;
            this.chartProdTop5.Text = "chart1";
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 542);
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
    }
}