namespace WindowsFormsApp_COP_4365
{
    partial class Form_StockViewer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog_stockPick = new System.Windows.Forms.OpenFileDialog();
            this.button_openFile = new System.Windows.Forms.Button();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_startDate = new System.Windows.Forms.Label();
            this.label_endDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_BeautyAnalysis = new System.Windows.Forms.GroupBox();
            this.button_ComputeBeauty = new System.Windows.Forms.Button();
            this.numericUpDown_Extension = new System.Windows.Forms.NumericUpDown();
            this.groupBox_FibonacciLevels = new System.Windows.Forms.GroupBox();
            this.button_ShowFibonacci = new System.Windows.Forms.Button();
            this.numericUpDown_Tolerance = new System.Windows.Forms.NumericUpDown();
            this.button_PredictNext = new System.Windows.Forms.Button();
            this.groupBox_WaveSelection = new System.Windows.Forms.GroupBox();
            this.button_ValidateWave = new System.Windows.Forms.Button();
            this.label_EndCandle = new System.Windows.Forms.Label();
            this.textBox_EndCandle = new System.Windows.Forms.TextBox();
            this.textBox_StartCandle = new System.Windows.Forms.TextBox();
            this.label_StartCandle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox_Patterns = new System.Windows.Forms.ComboBox();
            this.chart_OHLCV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Beauty = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.candlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox_BeautyAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Extension)).BeginInit();
            this.groupBox_FibonacciLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tolerance)).BeginInit();
            this.groupBox_WaveSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_OHLCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Beauty)).BeginInit();
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
            // button_openFile
            // 
            this.button_openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openFile.Location = new System.Drawing.Point(280, 18);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(104, 63);
            this.button_openFile.TabIndex = 0;
            this.button_openFile.Text = "Load Stock";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(12, 58);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(252, 23);
            this.dateTimePicker_startDate.TabIndex = 3;
            this.dateTimePicker_startDate.ValueChanged += new System.EventHandler(this.dateTimePicker_startDate_ValueChanged);
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(9, 134);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(255, 23);
            this.dateTimePicker_endDate.TabIndex = 4;
            this.dateTimePicker_endDate.ValueChanged += new System.EventHandler(this.dateTimePicker_endDate_ValueChanged);
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(279, 94);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(105, 65);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.BackColor = System.Drawing.SystemColors.Control;
            this.label_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_startDate.Location = new System.Drawing.Point(3, 18);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(99, 25);
            this.label_startDate.TabIndex = 6;
            this.label_startDate.Text = "Start Date";
            this.label_startDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_endDate.Location = new System.Drawing.Point(2, 94);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(125, 25);
            this.label_endDate.TabIndex = 7;
            this.label_endDate.Text = "Ending Date:";
            this.label_endDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_BeautyAnalysis);
            this.panel1.Controls.Add(this.groupBox_FibonacciLevels);
            this.panel1.Controls.Add(this.button_PredictNext);
            this.panel1.Controls.Add(this.groupBox_WaveSelection);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox_Patterns);
            this.panel1.Controls.Add(this.label_startDate);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.dateTimePicker_endDate);
            this.panel1.Controls.Add(this.label_endDate);
            this.panel1.Controls.Add(this.button_openFile);
            this.panel1.Controls.Add(this.dateTimePicker_startDate);
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 208);
            this.panel1.TabIndex = 8;
            // 
            // groupBox_BeautyAnalysis
            // 
            this.groupBox_BeautyAnalysis.Controls.Add(this.button_ComputeBeauty);
            this.groupBox_BeautyAnalysis.Controls.Add(this.numericUpDown_Extension);
            this.groupBox_BeautyAnalysis.Location = new System.Drawing.Point(1019, 18);
            this.groupBox_BeautyAnalysis.Name = "groupBox_BeautyAnalysis";
            this.groupBox_BeautyAnalysis.Size = new System.Drawing.Size(189, 96);
            this.groupBox_BeautyAnalysis.TabIndex = 14;
            this.groupBox_BeautyAnalysis.TabStop = false;
            // 
            // button_ComputeBeauty
            // 
            this.button_ComputeBeauty.Location = new System.Drawing.Point(6, 41);
            this.button_ComputeBeauty.Name = "button_ComputeBeauty";
            this.button_ComputeBeauty.Size = new System.Drawing.Size(160, 45);
            this.button_ComputeBeauty.TabIndex = 1;
            this.button_ComputeBeauty.Text = "Compute Beauty";
            this.button_ComputeBeauty.UseVisualStyleBackColor = true;
            this.button_ComputeBeauty.Click += new System.EventHandler(this.button_ComputeBeauty_Click);
            // 
            // numericUpDown_Extension
            // 
            this.numericUpDown_Extension.Location = new System.Drawing.Point(9, 12);
            this.numericUpDown_Extension.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_Extension.Name = "numericUpDown_Extension";
            this.numericUpDown_Extension.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_Extension.TabIndex = 0;
            this.numericUpDown_Extension.ValueChanged += new System.EventHandler(this.numericUpDown_Extension_ValueChanged);
            // 
            // groupBox_FibonacciLevels
            // 
            this.groupBox_FibonacciLevels.Controls.Add(this.button_ShowFibonacci);
            this.groupBox_FibonacciLevels.Controls.Add(this.numericUpDown_Tolerance);
            this.groupBox_FibonacciLevels.Location = new System.Drawing.Point(384, 114);
            this.groupBox_FibonacciLevels.Name = "groupBox_FibonacciLevels";
            this.groupBox_FibonacciLevels.Size = new System.Drawing.Size(375, 52);
            this.groupBox_FibonacciLevels.TabIndex = 13;
            this.groupBox_FibonacciLevels.TabStop = false;
            // 
            // button_ShowFibonacci
            // 
            this.button_ShowFibonacci.Location = new System.Drawing.Point(162, 15);
            this.button_ShowFibonacci.Name = "button_ShowFibonacci";
            this.button_ShowFibonacci.Size = new System.Drawing.Size(198, 37);
            this.button_ShowFibonacci.TabIndex = 1;
            this.button_ShowFibonacci.Text = "Show Fibonacci Levels";
            this.button_ShowFibonacci.UseVisualStyleBackColor = true;
            this.button_ShowFibonacci.Click += new System.EventHandler(this.button_ShowFibonacci_Click);
            // 
            // numericUpDown_Tolerance
            // 
            this.numericUpDown_Tolerance.Location = new System.Drawing.Point(22, 16);
            this.numericUpDown_Tolerance.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Tolerance.Name = "numericUpDown_Tolerance";
            this.numericUpDown_Tolerance.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_Tolerance.TabIndex = 0;
            this.numericUpDown_Tolerance.ValueChanged += new System.EventHandler(this.numericUpDown_Tolerance_ValueChanged);
            // 
            // button_PredictNext
            // 
            this.button_PredictNext.Location = new System.Drawing.Point(793, 90);
            this.button_PredictNext.Name = "button_PredictNext";
            this.button_PredictNext.Size = new System.Drawing.Size(199, 76);
            this.button_PredictNext.TabIndex = 12;
            this.button_PredictNext.Text = "Predict";
            this.button_PredictNext.UseVisualStyleBackColor = true;
            this.button_PredictNext.Click += new System.EventHandler(this.button_PredictNext_Click);
            // 
            // groupBox_WaveSelection
            // 
            this.groupBox_WaveSelection.Controls.Add(this.button_ValidateWave);
            this.groupBox_WaveSelection.Controls.Add(this.label_EndCandle);
            this.groupBox_WaveSelection.Controls.Add(this.textBox_EndCandle);
            this.groupBox_WaveSelection.Controls.Add(this.textBox_StartCandle);
            this.groupBox_WaveSelection.Controls.Add(this.label_StartCandle);
            this.groupBox_WaveSelection.Location = new System.Drawing.Point(391, 18);
            this.groupBox_WaveSelection.Name = "groupBox_WaveSelection";
            this.groupBox_WaveSelection.Size = new System.Drawing.Size(368, 90);
            this.groupBox_WaveSelection.TabIndex = 11;
            this.groupBox_WaveSelection.TabStop = false;
            // 
            // button_ValidateWave
            // 
            this.button_ValidateWave.Location = new System.Drawing.Point(236, 15);
            this.button_ValidateWave.Name = "button_ValidateWave";
            this.button_ValidateWave.Size = new System.Drawing.Size(111, 60);
            this.button_ValidateWave.TabIndex = 4;
            this.button_ValidateWave.Text = "Validate Wave";
            this.button_ValidateWave.UseVisualStyleBackColor = true;
            this.button_ValidateWave.Click += new System.EventHandler(this.button_ValidateWave_Click);
            // 
            // label_EndCandle
            // 
            this.label_EndCandle.AutoSize = true;
            this.label_EndCandle.Location = new System.Drawing.Point(6, 52);
            this.label_EndCandle.Name = "label_EndCandle";
            this.label_EndCandle.Size = new System.Drawing.Size(81, 17);
            this.label_EndCandle.TabIndex = 3;
            this.label_EndCandle.Text = "End Candle";
            // 
            // textBox_EndCandle
            // 
            this.textBox_EndCandle.Location = new System.Drawing.Point(108, 49);
            this.textBox_EndCandle.Name = "textBox_EndCandle";
            this.textBox_EndCandle.Size = new System.Drawing.Size(113, 23);
            this.textBox_EndCandle.TabIndex = 2;
            // 
            // textBox_StartCandle
            // 
            this.textBox_StartCandle.Location = new System.Drawing.Point(108, 13);
            this.textBox_StartCandle.Name = "textBox_StartCandle";
            this.textBox_StartCandle.Size = new System.Drawing.Size(113, 23);
            this.textBox_StartCandle.TabIndex = 1;
            // 
            // label_StartCandle
            // 
            this.label_StartCandle.AutoSize = true;
            this.label_StartCandle.Location = new System.Drawing.Point(6, 11);
            this.label_StartCandle.Name = "label_StartCandle";
            this.label_StartCandle.Size = new System.Drawing.Size(86, 17);
            this.label_StartCandle.TabIndex = 0;
            this.label_StartCandle.Text = "Start Candle";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(793, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 27);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Pattern";
            // 
            // comboBox_Patterns
            // 
            this.comboBox_Patterns.FormattingEnabled = true;
            this.comboBox_Patterns.Location = new System.Drawing.Point(871, 24);
            this.comboBox_Patterns.Name = "comboBox_Patterns";
            this.comboBox_Patterns.Size = new System.Drawing.Size(121, 25);
            this.comboBox_Patterns.TabIndex = 9;
            this.comboBox_Patterns.SelectedIndexChanged += new System.EventHandler(this.comboBox_Patterns_SelectedIndexChanged);
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
            this.chart_OHLCV.Size = new System.Drawing.Size(1318, 280);
            this.chart_OHLCV.TabIndex = 2;
            this.chart_OHLCV.Text = "chart1";
            this.chart_OHLCV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart_OHLCV_MouseDown);
            this.chart_OHLCV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart_OHLCV_MouseUp);
            // 
            // chart_Beauty
            // 
            chartArea3.Name = "ChartArea_Beauty";
            this.chart_Beauty.ChartAreas.Add(chartArea3);
            this.chart_Beauty.Location = new System.Drawing.Point(3, 286);
            this.chart_Beauty.Name = "chart_Beauty";
            series3.ChartArea = "ChartArea_Beauty";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Beauty";
            this.chart_Beauty.Series.Add(series3);
            this.chart_Beauty.Size = new System.Drawing.Size(1316, 134);
            this.chart_Beauty.TabIndex = 9;
            this.chart_Beauty.Text = "chart1";
            // 
            // candlestickBindingSource
            // 
            this.candlestickBindingSource.DataSource = typeof(WindowsFormsApp_COP_4365.Candlestick);
            // 
            // Form_StockViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 656);
            this.Controls.Add(this.chart_Beauty);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart_OHLCV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form_StockViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project 2";
            this.Load += new System.EventHandler(this.Form_Project_2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_BeautyAnalysis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Extension)).EndInit();
            this.groupBox_FibonacciLevels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tolerance)).EndInit();
            this.groupBox_WaveSelection.ResumeLayout(false);
            this.groupBox_WaveSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_OHLCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Beauty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_stockPick;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.BindingSource candlestickBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_Patterns;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_OHLCV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Beauty;
        private System.Windows.Forms.GroupBox groupBox_WaveSelection;
        private System.Windows.Forms.Label label_StartCandle;
        private System.Windows.Forms.TextBox textBox_StartCandle;
        private System.Windows.Forms.TextBox textBox_EndCandle;
        private System.Windows.Forms.Label label_EndCandle;
        private System.Windows.Forms.Button button_ValidateWave;
        private System.Windows.Forms.Button button_PredictNext;
        private System.Windows.Forms.GroupBox groupBox_FibonacciLevels;
        private System.Windows.Forms.NumericUpDown numericUpDown_Tolerance;
        private System.Windows.Forms.Button button_ShowFibonacci;
        private System.Windows.Forms.GroupBox groupBox_BeautyAnalysis;
        private System.Windows.Forms.NumericUpDown numericUpDown_Extension;
        private System.Windows.Forms.Button button_ComputeBeauty;
    }
}

