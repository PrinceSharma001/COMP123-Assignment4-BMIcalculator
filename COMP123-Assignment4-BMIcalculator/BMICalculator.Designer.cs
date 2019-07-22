namespace COMP123_Assignment4_BMIcalculator
{
    partial class BMICalculator
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
            this.BMICalculatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MetricUnitButton = new System.Windows.Forms.RadioButton();
            this.ImperialUnitButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMICalculatorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculatorTableLayoutPanel
            // 
            this.BMICalculatorTableLayoutPanel.ColumnCount = 2;
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83278F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16722F));
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ResultTextBox, 1, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.MetricUnitButton, 1, 0);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ImperialUnitButton, 0, 0);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ResultLabel, 0, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 4);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ResetButton, 1, 4);
            this.BMICalculatorTableLayoutPanel.Location = new System.Drawing.Point(1, 12);
            this.BMICalculatorTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BMICalculatorTableLayoutPanel.Name = "BMICalculatorTableLayoutPanel";
            this.BMICalculatorTableLayoutPanel.RowCount = 5;
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.Size = new System.Drawing.Size(299, 228);
            this.BMICalculatorTableLayoutPanel.TabIndex = 0;
            // 
            // MetricUnitButton
            // 
            this.MetricUnitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricUnitButton.AutoSize = true;
            this.MetricUnitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MetricUnitButton.Location = new System.Drawing.Point(152, 2);
            this.MetricUnitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MetricUnitButton.Name = "MetricUnitButton";
            this.MetricUnitButton.Size = new System.Drawing.Size(144, 41);
            this.MetricUnitButton.TabIndex = 1;
            this.MetricUnitButton.TabStop = true;
            this.MetricUnitButton.Text = "Metric";
            this.MetricUnitButton.UseVisualStyleBackColor = false;
            // 
            // ImperialUnitButton
            // 
            this.ImperialUnitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialUnitButton.AutoSize = true;
            this.ImperialUnitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ImperialUnitButton.Checked = true;
            this.ImperialUnitButton.Location = new System.Drawing.Point(3, 2);
            this.ImperialUnitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImperialUnitButton.Name = "ImperialUnitButton";
            this.ImperialUnitButton.Size = new System.Drawing.Size(143, 41);
            this.ImperialUnitButton.TabIndex = 0;
            this.ImperialUnitButton.TabStop = true;
            this.ImperialUnitButton.Text = "Imperial";
            this.ImperialUnitButton.UseVisualStyleBackColor = false;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 45);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(143, 45);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height";
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 90);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(143, 45);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "My Weight";
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(3, 135);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(143, 45);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "BMI is:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.AllowDrop = true;
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.Location = new System.Drawing.Point(152, 47);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(144, 38);
            this.HeightTextBox.TabIndex = 2;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(152, 92);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(144, 38);
            this.WeightTextBox.TabIndex = 5;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.Location = new System.Drawing.Point(152, 137);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(144, 38);
            this.ResultTextBox.TabIndex = 6;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBMIButton.BackColor = System.Drawing.Color.SkyBlue;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 182);
            this.CalculateBMIButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(143, 44);
            this.CalculateBMIButton.TabIndex = 7;
            this.CalculateBMIButton.Text = "CalculateBMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.ResetButton.Location = new System.Drawing.Point(152, 183);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(144, 42);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Clear";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMICalculatorTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.BMICalculatorTableLayoutPanel.ResumeLayout(false);
            this.BMICalculatorTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICalculatorTableLayoutPanel;
        private System.Windows.Forms.RadioButton MetricUnitButton;
        private System.Windows.Forms.RadioButton ImperialUnitButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

