namespace Lab_4_Release
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownWindV = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSimulationTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWindU = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSimulationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownWindV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownSimulationTime);
            this.groupBox1.Controls.Add(this.numericUpDownWindU);
            this.groupBox1.Location = new System.Drawing.Point(573, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(345, 426);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 265);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить источник";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(63, 319);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(221, 46);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Сбросить настройки";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Скорость ветра по Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Скорость ветра по X:";
            // 
            // numericUpDownWindV
            // 
            this.numericUpDownWindV.DecimalPlaces = 2;
            this.numericUpDownWindV.Location = new System.Drawing.Point(63, 175);
            this.numericUpDownWindV.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownWindV.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownWindV.Name = "numericUpDownWindV";
            this.numericUpDownWindV.Size = new System.Drawing.Size(221, 22);
            this.numericUpDownWindV.TabIndex = 4;
            this.numericUpDownWindV.ValueChanged += new System.EventHandler(this.numericUpDownWindV_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Временной слой:";
            // 
            // numericUpDownSimulationTime
            // 
            this.numericUpDownSimulationTime.DecimalPlaces = 2;
            this.numericUpDownSimulationTime.Location = new System.Drawing.Point(63, 114);
            this.numericUpDownSimulationTime.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownSimulationTime.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownSimulationTime.Name = "numericUpDownSimulationTime";
            this.numericUpDownSimulationTime.Size = new System.Drawing.Size(221, 22);
            this.numericUpDownSimulationTime.TabIndex = 1;
            this.numericUpDownSimulationTime.ValueChanged += new System.EventHandler(this.numericUpDownSimulationTime_ValueChanged);
            // 
            // numericUpDownWindU
            // 
            this.numericUpDownWindU.DecimalPlaces = 2;
            this.numericUpDownWindU.Location = new System.Drawing.Point(63, 235);
            this.numericUpDownWindU.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownWindU.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownWindU.Name = "numericUpDownWindU";
            this.numericUpDownWindU.Size = new System.Drawing.Size(221, 22);
            this.numericUpDownWindU.TabIndex = 5;
            this.numericUpDownWindU.ValueChanged += new System.EventHandler(this.numericUpDownWindU_ValueChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(554, 426);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Количество источников: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(260, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSimulationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownWindV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSimulationTime;
        private System.Windows.Forms.NumericUpDown numericUpDownWindU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

