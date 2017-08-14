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
 * Date: Aug 14, 2017
 * Desc: This is the BMI calculator project
 * Ver: 0.7 - Refactored the CalculateBMIButton_Click event 
 */


namespace Assignment_5_BMI_Calculator
{
    public partial class BMICalculator : Form
    {
        // PRIVATE INSTANCE VARIABLES 

        private double _weightInKg;
        private double _heightInCm;
        private double _heightInInches;
        private double _weightInLbs;
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

        public double HeightInInches
        {
            get
            {
                return this._heightInInches;
            }
            set
            {
                this._heightInInches = value;
            }
        }

        public double WeightInLbs
        {
            get
            {
                return this._weightInLbs;
            }
            set
            {
                this._weightInLbs = value;
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

        

        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the BMI Calculator class
        /// </summary>
        public BMICalculator()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS 

        /// <summary>
        /// This is the Calculate BMI button click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {

            if (MetricRadioButton.Checked)
            {
                _CalculateMetBMI();
            }
            else
            {
                _CalculateImpBMI();
            }
            
            BMIResultsTextBox.Text = "Your Body Mass Index is " + Math.Round(this.BMI, 1) + ". This is considered " + this.BMIScale;
        }

        /// <summary>
        /// This is the Metric calculate BMI method that takes Metric units to calculate the BMI
        /// </summary>
        private void _CalculateMetBMI()
        {
            this.WeightInKg = Convert.ToDouble(MyWeightTextBox.Text);
            this.HeightInCm = Convert.ToDouble(MyHeightTextBox.Text);
            this.HeightInCm /= 100; // Converts height to meters

            this.BMI = WeightInKg / (HeightInCm * HeightInCm);

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

        /// <summary>
        /// This is the Imperial calculate BMI method that takes Imperial units to calculate the BMI
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        private void _CalculateImpBMI()
        {
            this.WeightInLbs = Convert.ToDouble(MyWeightTextBox.Text);
            this.HeightInInches = Convert.ToDouble(MyHeightTextBox.Text); // Takes height value from the Feet Textbox

            this.HeightInInches *= 12; // Convert feet to inches
            this.HeightInInches += Convert.ToDouble(MyHeightTextBox2.Text); // Adds inches value from Inches Textbox

            this.BMI = (WeightInLbs * 703) / (HeightInInches * HeightInInches);

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

        /// <summary>
        /// Radio button that changes the layout of the calculator to Imperial system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightTextBox2.Visible = true;
            HeightLabel2.Visible = true;
            HeightLabel1.Text = "ft";
            WeightLabel.Text = "lbs";
        }

        /// <summary>
        /// Radio button that changes the layout of the calculator to Metric system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightTextBox2.Visible = false;
            HeightLabel2.Visible = false;
            HeightLabel1.Text = "cm";
            WeightLabel.Text = "kg";
        }
    }
}
