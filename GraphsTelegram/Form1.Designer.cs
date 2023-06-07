using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphsTelegram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            Title title1 = new Title();
            chart = new Chart();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // chart
            // 
            chartArea1.BackColor = Color.FromArgb(255, 255, 128);
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Информация графика";
            legend1.TitleSeparator = LegendSeparatorStyle.DashLine;
            chart.Legends.Add(legend1);
            chart.Location = new Point(131, 59);
            chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.Color = Color.Black;
            series1.LabelForeColor = Color.BlanchedAlmond;
            series1.Legend = "Legend1";
            series1.LegendText = "Количество \\nданных";
            series1.Name = "Series1";
            series1.ShadowColor = Color.White;
            chart.Series.Add(series1);
            chart.Size = new Size(516, 281);
            chart.TabIndex = 0;
            chart.Text = "chart";
            title1.Name = "Title1";
            title1.Text = "График скачивания файла Telegram";
            chart.Titles.Add(title1);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(chart);
            Name = "Form1";
            Text = "График скачивания файла";
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Chart chart;
    }
}