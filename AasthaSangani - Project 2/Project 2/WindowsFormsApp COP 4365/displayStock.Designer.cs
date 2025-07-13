namespace proj_2
{
    partial class displayStock
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog_stockPick = new System.Windows.Forms.OpenFileDialog();
            this.chart_OHLCV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.button_openFile = new System.Windows.Forms.Button();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.button_Update = new System.Windows.Forms.Button();
            this.comboBox_Patterns = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.candlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart_OHLCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_stockPick
            // 
            this.openFileDialog_stockPick.Filter = "CSV files (*.csv)|*-Day.csv;*-Week.csv;*-Month.csv|Daily|*-Day.csv|Weekly|*-Week." +
    "csv|Monthly|*-Month.csv";
            this.openFileDialog_stockPick.Multiselect = true;
            this.openFileDialog_stockPick.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_stockPick_FileOk);
            // 
            // chart_OHLCV
            // 
            this.chart_OHLCV.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea1.Name = "ChartArea_OHLC";
            chartArea2.AlignWithChartArea = "ChartArea_OHLC";
            chartArea2.Name = "ChartArea_Volume";
            this.chart_OHLCV.ChartAreas.Add(chartArea1);
            this.chart_OHLCV.ChartAreas.Add(chartArea2);
            this.chart_OHLCV.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Enabled = false;
            legend1.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.ReversedSeriesOrder;
            legend1.Name = "Legend_OHLCV";
            this.chart_OHLCV.Legends.Add(legend1);
            this.chart_OHLCV.Location = new System.Drawing.Point(0, 0);
            this.chart_OHLCV.Name = "chart_OHLCV";
            series1.ChartArea = "ChartArea_OHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend_OHLCV";
            series1.Name = "Series_OHLC";
            series1.XValueMember = "Date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "High,Low,Open,Close";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea_Volume";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend_OHLCV";
            series2.Name = "Series_Volume";
            series2.XValueMember = "Date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueMembers = "Volume";
            this.chart_OHLCV.Series.Add(series1);
            this.chart_OHLCV.Series.Add(series2);
            this.chart_OHLCV.Size = new System.Drawing.Size(1319, 470);
            this.chart_OHLCV.TabIndex = 2;
            this.chart_OHLCV.Text = "chart1";
            this.chart_OHLCV.Click += new System.EventHandler(this.chart_OHLCV_Click);
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(173, 487);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(344, 26);
            this.dateTimePicker_startDate.TabIndex = 3;
            this.dateTimePicker_startDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_startDate.ValueChanged += new System.EventHandler(this.dateTimePicker_startDate_ValueChanged);
            // 
            // button_openFile
            // 
            this.button_openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openFile.Location = new System.Drawing.Point(224, 552);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(104, 42);
            this.button_openFile.TabIndex = 0;
            this.button_openFile.Text = "Load Stock";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(173, 519);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(344, 26);
            this.dateTimePicker_endDate.TabIndex = 4;
            this.dateTimePicker_endDate.ValueChanged += new System.EventHandler(this.dateTimePicker_endDate_ValueChanged);
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(356, 552);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(105, 42);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // comboBox_Patterns
            // 
            this.comboBox_Patterns.FormattingEnabled = true;
            this.comboBox_Patterns.Location = new System.Drawing.Point(689, 508);
            this.comboBox_Patterns.Name = "comboBox_Patterns";
            this.comboBox_Patterns.Size = new System.Drawing.Size(203, 28);
            this.comboBox_Patterns.TabIndex = 9;
            this.comboBox_Patterns.SelectedIndexChanged += new System.EventHandler(this.comboBox_Patterns_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(766, 552);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 31);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Pattern";
            // 
            // candlestickBindingSource
            // 
            this.candlestickBindingSource.DataSource = typeof(proj_2.Candlestick);
            // 
            // displayStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 606);
            this.Controls.Add(this.button_openFile);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox_Patterns);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.chart_OHLCV);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "displayStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project 2";
            this.Load += new System.EventHandler(this.Form_Project_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_OHLCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_stockPick;
        private System.Windows.Forms.BindingSource candlestickBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_OHLCV;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.ComboBox comboBox_Patterns;
        private System.Windows.Forms.TextBox textBox1;
    }
}

