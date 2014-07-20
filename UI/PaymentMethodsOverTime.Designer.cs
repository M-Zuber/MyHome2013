﻿namespace MyHome2013
{
    partial class PaymentMethodsOverTime
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dateRangeBox = new System.Windows.Forms.GroupBox();
            this.catShowBox = new System.Windows.Forms.GroupBox();
            this.seriesDisplayBox = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.methodData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.seriesNameIndicator = new System.Windows.Forms.Label();
            this.seriesNameValue = new System.Windows.Forms.Label();
            this.seriesColorIndicator = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.chooseColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.dateRangeBox.SuspendLayout();
            this.catShowBox.SuspendLayout();
            this.seriesDisplayBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.methodData)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clearButton);
            this.splitContainer1.Panel1.Controls.Add(this.calculateButton);
            this.splitContainer1.Panel1.Controls.Add(this.seriesDisplayBox);
            this.splitContainer1.Panel1.Controls.Add(this.catShowBox);
            this.splitContainer1.Panel1.Controls.Add(this.dateRangeBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.methodData);
            this.splitContainer1.Size = new System.Drawing.Size(651, 448);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 0;
            // 
            // dateRangeBox
            // 
            this.dateRangeBox.Controls.Add(this.endDate);
            this.dateRangeBox.Controls.Add(this.startDate);
            this.dateRangeBox.Controls.Add(this.dateTimePicker2);
            this.dateRangeBox.Controls.Add(this.dateTimePicker1);
            this.dateRangeBox.Location = new System.Drawing.Point(12, 12);
            this.dateRangeBox.Name = "dateRangeBox";
            this.dateRangeBox.Size = new System.Drawing.Size(200, 111);
            this.dateRangeBox.TabIndex = 0;
            this.dateRangeBox.TabStop = false;
            this.dateRangeBox.Text = "Date Range";
            // 
            // catShowBox
            // 
            this.catShowBox.Controls.Add(this.checkedListBox1);
            this.catShowBox.Location = new System.Drawing.Point(12, 129);
            this.catShowBox.Name = "catShowBox";
            this.catShowBox.Size = new System.Drawing.Size(200, 150);
            this.catShowBox.TabIndex = 1;
            this.catShowBox.TabStop = false;
            this.catShowBox.Text = "Categories To Show";
            // 
            // seriesDisplayBox
            // 
            this.seriesDisplayBox.Controls.Add(this.chooseColorButton);
            this.seriesDisplayBox.Controls.Add(this.seriesColorIndicator);
            this.seriesDisplayBox.Controls.Add(this.seriesNameValue);
            this.seriesDisplayBox.Controls.Add(this.seriesNameIndicator);
            this.seriesDisplayBox.Location = new System.Drawing.Point(12, 285);
            this.seriesDisplayBox.Name = "seriesDisplayBox";
            this.seriesDisplayBox.Size = new System.Drawing.Size(200, 122);
            this.seriesDisplayBox.TabIndex = 2;
            this.seriesDisplayBox.TabStop = false;
            this.seriesDisplayBox.Text = "Series Display Style";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 413);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(137, 413);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // methodData
            // 
            chartArea1.Name = "ChartArea1";
            this.methodData.ChartAreas.Add(chartArea1);
            this.methodData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodData.Location = new System.Drawing.Point(0, 0);
            this.methodData.Name = "methodData";
            this.methodData.Size = new System.Drawing.Size(430, 448);
            this.methodData.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(6, 27);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(55, 13);
            this.startDate.TabIndex = 2;
            this.startDate.Text = "Start Date";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(6, 66);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(52, 13);
            this.endDate.TabIndex = 3;
            this.endDate.Text = "End Date";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 16);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(194, 131);
            this.checkedListBox1.TabIndex = 0;
            // 
            // seriesNameIndicator
            // 
            this.seriesNameIndicator.AutoSize = true;
            this.seriesNameIndicator.Location = new System.Drawing.Point(6, 16);
            this.seriesNameIndicator.Name = "seriesNameIndicator";
            this.seriesNameIndicator.Size = new System.Drawing.Size(70, 13);
            this.seriesNameIndicator.TabIndex = 0;
            this.seriesNameIndicator.Text = "Series Name:";
            // 
            // seriesNameValue
            // 
            this.seriesNameValue.AutoSize = true;
            this.seriesNameValue.Location = new System.Drawing.Point(83, 16);
            this.seriesNameValue.Name = "seriesNameValue";
            this.seriesNameValue.Size = new System.Drawing.Size(35, 13);
            this.seriesNameValue.TabIndex = 1;
            this.seriesNameValue.Text = "label1";
            // 
            // seriesColorIndicator
            // 
            this.seriesColorIndicator.AutoSize = true;
            this.seriesColorIndicator.Location = new System.Drawing.Point(6, 43);
            this.seriesColorIndicator.Name = "seriesColorIndicator";
            this.seriesColorIndicator.Size = new System.Drawing.Size(66, 13);
            this.seriesColorIndicator.TabIndex = 2;
            this.seriesColorIndicator.Text = "Series Color:";
            // 
            // colorDialog1
            // 
            this.colorDialog1.SolidColorOnly = true;
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.Location = new System.Drawing.Point(86, 38);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(91, 23);
            this.chooseColorButton.TabIndex = 3;
            this.chooseColorButton.Text = "Choose a Color";
            this.chooseColorButton.UseVisualStyleBackColor = true;
            // 
            // PaymentMethodsOverTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 448);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PaymentMethodsOverTime";
            this.Text = "Payment Methods Over Time";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.dateRangeBox.ResumeLayout(false);
            this.dateRangeBox.PerformLayout();
            this.catShowBox.ResumeLayout(false);
            this.seriesDisplayBox.ResumeLayout(false);
            this.seriesDisplayBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.methodData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox seriesDisplayBox;
        private System.Windows.Forms.GroupBox catShowBox;
        private System.Windows.Forms.GroupBox dateRangeBox;
        private System.Windows.Forms.Label seriesColorIndicator;
        private System.Windows.Forms.Label seriesNameValue;
        private System.Windows.Forms.Label seriesNameIndicator;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart methodData;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}