namespace Assignment_5_BMI_Calculator
{
    partial class BMICalculatorSplashForm
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
            this.SplashFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SplashFormLabel
            // 
            this.SplashFormLabel.AutoSize = true;
            this.SplashFormLabel.Location = new System.Drawing.Point(51, 9);
            this.SplashFormLabel.Name = "SplashFormLabel";
            this.SplashFormLabel.Size = new System.Drawing.Size(192, 31);
            this.SplashFormLabel.TabIndex = 0;
            this.SplashFormLabel.Text = "BMI Calculator";
            // 
            // BMICalculatorSplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(304, 464);
            this.ControlBox = false;
            this.Controls.Add(this.SplashFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BMICalculatorSplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SplashFormLabel;
    }
}