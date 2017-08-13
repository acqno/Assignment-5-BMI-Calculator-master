using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Alvun Quijano
 * Student No: 300795606
 * Date: Aug 13, 2017
 * Desc: This is the BMI calculator project
 * Ver: 0.5 - Implemented RadioButton_Clicked event handler for switching from Metric To Imperial  
 */


namespace Assignment_5_BMI_Calculator
{
    public partial class BMICalculator : Form
    {
        // PRIVATE INSTANCE VARIABLES 

        private double _weightInKg;

        private double _heightInCm;

        private double _bmi;

        private string _bmiScale;

        // PUBLIC PROPERTIES 

        public double WeightInKg
        {
            get
            {
                return this._weightInKg;
            }
            set
            {
                this._weightInKg = value;
            } 
        }

        public double HeightInCm
        {
            get
            {
                return this._heightInCm;
            }
            set
            {
                this._heightInCm = value;
            }
        }

        public double BMI
        {
            get
            {
                return this._bmi;
            }
            set
            {
                this._bmi = value;
            }
        }

        public string BMIScale
        {
            get
            {
                return this._bmiScale;
            }
            set
            {
                this._bmiScale = value;
            }
        }

        /// <summary>
        /// This is the main constructor for the BMI Calculator class
        /// </summary>
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void FormLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// This is the Calculate BMI button click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            WeightInKg = Convert.ToDouble(MyWeightTextBox.Text);
            HeightInCm = Convert.ToDouble(MyHeightTextBox.Text);

            _CalculateBMI(this.WeightInKg, this.HeightInCm);
            BMIResultsTextBox.Text = "Your Body Mass Index is " + Math.Round(this.BMI, 1) + ". This is considered " + this.BMIScale;
        }

        /// <summary>
        /// This is the CalculateBMI method event that calculates the BMI once the button is clicked 
        /// </summary>
        private void _CalculateBMI(double weight, double height)
        {
            // convert to meters
            height /= 100;

            BMI = weight / (height * height);

            if (BMI < 18.5)
            {
                this.BMIScale = "Underweight";
            }
            else if ((BMI >= 18.5) && (BMI <= 24.9))
            {
                this.BMIScale = "Normal";
            }
            else if ((BMI >= 25) && (BMI <= 29.9))
            {
                this.BMIScale = "Overweight";
            }
            else
            {
                this.BMIScale = "Obese";
            }
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightTextBox2.Visible = true;
            HeightInchLabel.Visible = true;
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightTextBox2.Visible = false;
            HeightInchLabel.Visible = false;
        }
    }
}
