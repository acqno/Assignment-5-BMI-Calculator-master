namespace Assignment_5_BMI_Calculator
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
            this.BMICalculatorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyHeightTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.BMIResultsTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.BMITitleLabel = new System.Windows.Forms.Label();
            this.HeightCMLabel = new System.Windows.Forms.Label();
            this.WeightKGLablel = new System.Windows.Forms.Label();
            this.BMICalculatorTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculatorTableLayout
            // 
            this.BMICalculatorTableLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BMICalculatorTableLayout.ColumnCount = 4;
            this.BMICalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayout.Controls.Add(this.MetricRadioButton, 0, 0);
            this.BMICalculatorTableLayout.Controls.Add(this.ImperialRadioButton, 2, 0);
            this.BMICalculatorTableLayout.Controls.Add(this.MyHeightLabel, 0, 1);
            this.BMICalculatorTableLayout.Controls.Add(this.MyHeightTextBox, 0, 2);
            this.BMICalculatorTableLayout.Controls.Add(this.MyWeightLabel, 0, 3);
            this.BMICalculatorTableLayout.Controls.Add(this.MyWeightTextBox, 0, 4);
            this.BMICalculatorTableLayout.Controls.Add(this.CalculateBMIButton, 0, 5);
            this.BMICalculatorTableLayout.Controls.Add(this.HeightCMLabel, 1, 2);
            this.BMICalculatorTableLayout.Controls.Add(this.WeightKGLablel, 1, 4);
            this.BMICalculatorTableLayout.Controls.Add(this.BMIResultsTextBox, 0, 6);
            this.BMICalculatorTableLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMICalculatorTableLayout.Location = new System.Drawing.Point(12, 77);
            this.BMICalculatorTableLayout.Name = "BMICalculatorTableLayout";
            this.BMICalculatorTableLayout.RowCount = 7;
            this.BMICalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BMICalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BMICalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BMICalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BMICalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BMICalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BMICalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BMICalculatorTableLayout.Size = new System.Drawing.Size(280, 360);
            this.BMICalculatorTableLayout.TabIndex = 0;
            this.BMICalculatorTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.FormLayout_Paint);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.BMICalculatorTableLayout.SetColumnSpan(this.MetricRadioButton, 2);
            this.MetricRadioButton.Location = new System.Drawing.Point(3, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 0;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.BMICalculatorTableLayout.SetColumnSpan(this.ImperialRadioButton, 2);
            this.ImperialRadioButton.Location = new System.Drawing.Point(143, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.BMICalculatorTableLayout.SetColumnSpan(this.MyHeightLabel, 3);
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 51);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(136, 31);
            this.MyHeightLabel.TabIndex = 2;
            this.MyHeightLabel.Text = "My Height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyHeightTextBox
            // 
            this.MyHeightTextBox.Location = new System.Drawing.Point(3, 105);
            this.MyHeightTextBox.Name = "MyHeightTextBox";
            this.MyHeightTextBox.Size = new System.Drawing.Size(64, 38);
            this.MyHeightTextBox.TabIndex = 3;
            // 
            // CalculateBMIButton
            // 
            this.BMICalculatorTableLayout.SetColumnSpan(this.CalculateBMIButton, 2);
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 258);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(81, 26);
            this.CalculateBMIButton.TabIndex = 6;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // BMIResultsTextBox
            // 
            this.BMIResultsTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.BMICalculatorTableLayout.SetColumnSpan(this.BMIResultsTextBox, 4);
            this.BMIResultsTextBox.Enabled = false;
            this.BMIResultsTextBox.Location = new System.Drawing.Point(3, 309);
            this.BMIResultsTextBox.Name = "BMIResultsTextBox";
            this.BMIResultsTextBox.Size = new System.Drawing.Size(274, 38);
            this.BMIResultsTextBox.TabIndex = 7;
            // 
            // MyWeightTextBox
            // 
            this.MyWeightTextBox.Location = new System.Drawing.Point(3, 207);
            this.MyWeightTextBox.Name = "MyWeightTextBox";
            this.MyWeightTextBox.Size = new System.Drawing.Size(64, 38);
            this.MyWeightTextBox.TabIndex = 4;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.BMICalculatorTableLayout.SetColumnSpan(this.MyWeightLabel, 3);
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 153);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(141, 31);
            this.MyWeightLabel.TabIndex = 5;
            this.MyWeightLabel.Text = "My Weight";
            // 
            // BMITitleLabel
            // 
            this.BMITitleLabel.AutoSize = true;
            this.BMITitleLabel.Location = new System.Drawing.Point(54, 9);
            this.BMITitleLabel.Name = "BMITitleLabel";
            this.BMITitleLabel.Size = new System.Drawing.Size(192, 31);
            this.BMITitleLabel.TabIndex = 1;
            this.BMITitleLabel.Text = "BMI Calculator";
            this.BMITitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HeightCMLabel
            // 
            this.HeightCMLabel.AutoSize = true;
            this.HeightCMLabel.Location = new System.Drawing.Point(73, 102);
            this.HeightCMLabel.Name = "HeightCMLabel";
            this.HeightCMLabel.Size = new System.Drawing.Size(56, 31);
            this.HeightCMLabel.TabIndex = 9;
            this.HeightCMLabel.Text = "CM";
            // 
            // WeightKGLablel
            // 
            this.WeightKGLablel.AutoSize = true;
            this.WeightKGLablel.Location = new System.Drawing.Point(73, 204);
            this.WeightKGLablel.Name = "WeightKGLablel";
            this.WeightKGLablel.Size = new System.Drawing.Size(53, 31);
            this.WeightKGLablel.TabIndex = 10;
            this.WeightKGLablel.Text = "KG";
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMITitleLabel);
            this.Controls.Add(this.BMICalculatorTableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.BMICalculatorTableLayout.ResumeLayout(false);
            this.BMICalculatorTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICalculatorTableLayout;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox MyHeightTextBox;
        private System.Windows.Forms.TextBox MyWeightTextBox;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox BMIResultsTextBox;
        private System.Windows.Forms.Label BMITitleLabel;
        private System.Windows.Forms.Label HeightCMLabel;
        private System.Windows.Forms.Label WeightKGLablel;
    }
}

