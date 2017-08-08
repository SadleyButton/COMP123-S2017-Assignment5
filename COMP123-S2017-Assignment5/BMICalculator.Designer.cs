namespace COMP123_S2017_Assignment5
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
            this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ObeseLabel = new System.Windows.Forms.Label();
            this.OverWeightLabel = new System.Windows.Forms.Label();
            this.NormalWeightLabel = new System.Windows.Forms.Label();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.BodyMassIndexResultLabel = new System.Windows.Forms.Label();
            this.BMIResultLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.UnderweightLabel = new System.Windows.Forms.Label();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.BMITableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITableLayoutPanel
            // 
            this.BMITableLayoutPanel.ColumnCount = 2;
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.Controls.Add(this.WeightUnitLabel, 1, 4);
            this.BMITableLayoutPanel.Controls.Add(this.ObeseLabel, 0, 10);
            this.BMITableLayoutPanel.Controls.Add(this.OverWeightLabel, 0, 9);
            this.BMITableLayoutPanel.Controls.Add(this.NormalWeightLabel, 0, 8);
            this.BMITableLayoutPanel.Controls.Add(this.MetricRadioButton, 0, 1);
            this.BMITableLayoutPanel.Controls.Add(this.ImperialRadioButton, 1, 1);
            this.BMITableLayoutPanel.Controls.Add(this.HeightLabel, 0, 2);
            this.BMITableLayoutPanel.Controls.Add(this.WeightLabel, 1, 2);
            this.BMITableLayoutPanel.Controls.Add(this.HeightTextBox, 0, 3);
            this.BMITableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 3);
            this.BMITableLayoutPanel.Controls.Add(this.BMICalculatorLabel, 0, 0);
            this.BMITableLayoutPanel.Controls.Add(this.BMIResultTextBox, 1, 5);
            this.BMITableLayoutPanel.Controls.Add(this.BodyMassIndexResultLabel, 0, 6);
            this.BMITableLayoutPanel.Controls.Add(this.BMIResultLabel, 0, 5);
            this.BMITableLayoutPanel.Controls.Add(this.CalculateButton, 0, 11);
            this.BMITableLayoutPanel.Controls.Add(this.UnderweightLabel, 0, 7);
            this.BMITableLayoutPanel.Controls.Add(this.HeightUnitLabel, 0, 4);
            this.BMITableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
            this.BMITableLayoutPanel.RowCount = 12;
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00011F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.500004F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00001F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.500004F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999927F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999927F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249991F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249991F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249991F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249991F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999986F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMITableLayoutPanel.Size = new System.Drawing.Size(300, 440);
            this.BMITableLayoutPanel.TabIndex = 0;
            // 
            // ObeseLabel
            // 
            this.ObeseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ObeseLabel.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.ObeseLabel, 2);
            this.ObeseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObeseLabel.Location = new System.Drawing.Point(105, 370);
            this.ObeseLabel.Name = "ObeseLabel";
            this.ObeseLabel.Size = new System.Drawing.Size(90, 16);
            this.ObeseLabel.TabIndex = 15;
            this.ObeseLabel.Text = "Obese: > 30";
            // 
            // OverWeightLabel
            // 
            this.OverWeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OverWeightLabel.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.OverWeightLabel, 2);
            this.OverWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverWeightLabel.Location = new System.Drawing.Point(75, 343);
            this.OverWeightLabel.Name = "OverWeightLabel";
            this.OverWeightLabel.Size = new System.Drawing.Size(150, 16);
            this.OverWeightLabel.TabIndex = 14;
            this.OverWeightLabel.Text = "Overweight: 25 - 29.9";
            // 
            // NormalWeightLabel
            // 
            this.NormalWeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NormalWeightLabel.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.NormalWeightLabel, 2);
            this.NormalWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalWeightLabel.Location = new System.Drawing.Point(56, 316);
            this.NormalWeightLabel.Name = "NormalWeightLabel";
            this.NormalWeightLabel.Size = new System.Drawing.Size(187, 16);
            this.NormalWeightLabel.TabIndex = 13;
            this.NormalWeightLabel.Text = "Normal Weight: 18.5 - 24.9";
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(30, 51);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(89, 29);
            this.MetricRadioButton.TabIndex = 0;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(172, 51);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(105, 29);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(20, 96);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(109, 25);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height";
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(168, 96);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(114, 25);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "My Weight";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeightTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.HeightTextBox.Location = new System.Drawing.Point(25, 124);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 38);
            this.HeightTextBox.TabIndex = 4;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WeightTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.WeightTextBox.Location = new System.Drawing.Point(175, 124);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 38);
            this.WeightTextBox.TabIndex = 5;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMICalculatorLabel.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.BMICalculatorLabel, 2);
            this.BMICalculatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMICalculatorLabel.Location = new System.Drawing.Point(47, 6);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(206, 31);
            this.BMICalculatorLabel.TabIndex = 6;
            this.BMICalculatorLabel.Text = "BMI Calculator";
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BMIResultTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.BMIResultTextBox.Location = new System.Drawing.Point(153, 222);
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.ReadOnly = true;
            this.BMITableLayoutPanel.SetRowSpan(this.BMIResultTextBox, 2);
            this.BMIResultTextBox.Size = new System.Drawing.Size(100, 38);
            this.BMIResultTextBox.TabIndex = 9;
            this.BMIResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BodyMassIndexResultLabel
            // 
            this.BodyMassIndexResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BodyMassIndexResultLabel.AutoSize = true;
            this.BodyMassIndexResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyMassIndexResultLabel.Location = new System.Drawing.Point(28, 241);
            this.BodyMassIndexResultLabel.Name = "BodyMassIndexResultLabel";
            this.BodyMassIndexResultLabel.Size = new System.Drawing.Size(119, 16);
            this.BodyMassIndexResultLabel.TabIndex = 8;
            this.BodyMassIndexResultLabel.Text = "(Body Mass Index)";
            // 
            // BMIResultLabel
            // 
            this.BMIResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIResultLabel.AutoSize = true;
            this.BMIResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResultLabel.Location = new System.Drawing.Point(85, 210);
            this.BMIResultLabel.Name = "BMIResultLabel";
            this.BMIResultLabel.Size = new System.Drawing.Size(62, 31);
            this.BMIResultLabel.TabIndex = 10;
            this.BMIResultLabel.Text = "BMI";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculateButton.BackColor = System.Drawing.Color.LightBlue;
            this.BMITableLayoutPanel.SetColumnSpan(this.CalculateButton, 2);
            this.CalculateButton.Location = new System.Drawing.Point(5, 396);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(290, 40);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // UnderweightLabel
            // 
            this.UnderweightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnderweightLabel.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.UnderweightLabel, 2);
            this.UnderweightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderweightLabel.Location = new System.Drawing.Point(79, 289);
            this.UnderweightLabel.Name = "UnderweightLabel";
            this.UnderweightLabel.Size = new System.Drawing.Size(142, 16);
            this.UnderweightLabel.TabIndex = 12;
            this.UnderweightLabel.Text = "Underweight: < 18.5";
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnitLabel.Location = new System.Drawing.Point(75, 165);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(0, 24);
            this.HeightUnitLabel.TabIndex = 16;
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnitLabel.Location = new System.Drawing.Point(225, 165);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(0, 24);
            this.WeightUnitLabel.TabIndex = 17;
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.BMITableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.BMITableLayoutPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMITableLayoutPanel;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.Label BodyMassIndexResultLabel;
        private System.Windows.Forms.Label ObeseLabel;
        private System.Windows.Forms.Label OverWeightLabel;
        private System.Windows.Forms.Label NormalWeightLabel;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.Label BMIResultLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label UnderweightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.Label HeightUnitLabel;
    }
}

