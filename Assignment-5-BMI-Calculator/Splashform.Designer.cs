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
            this.components = new System.ComponentModel.Container();
            this.SplashFormLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.SplashFormPictureBox = new System.Windows.Forms.PictureBox();
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplashFormPictureBox)).BeginInit();
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
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(57, 44);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(108, 32);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "By: Alvin Quijano\r\nVersion: 1.1";
            // 
            // SplashFormPictureBox
            // 
            this.SplashFormPictureBox.Image = global::Assignment_5_BMI_Calculator.Properties.Resources.bodybuilder_flexing_muscles_pointing_side_retro_aloysius_patrimonio;
            this.SplashFormPictureBox.Location = new System.Drawing.Point(12, 109);
            this.SplashFormPictureBox.Name = "SplashFormPictureBox";
            this.SplashFormPictureBox.Size = new System.Drawing.Size(280, 217);
            this.SplashFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SplashFormPictureBox.TabIndex = 1;
            this.SplashFormPictureBox.TabStop = false;
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // BMICalculatorSplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(304, 464);
            this.ControlBox = false;
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.SplashFormPictureBox);
            this.Controls.Add(this.SplashFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BMICalculatorSplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.SplashFormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SplashFormLabel;
        private System.Windows.Forms.PictureBox SplashFormPictureBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Timer SplashFormTimer;
    }
}