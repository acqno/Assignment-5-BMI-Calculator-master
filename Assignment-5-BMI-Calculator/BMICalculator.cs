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
 * Date: Aug 13, 2017
 * Desc: This is the BMI calculator project
 * Ver: 0.3 - Created the _CalculateBMI event handler 
 */


namespace Assignment_5_BMI_Calculator
{
    public partial class BMICalculator : Form
    {
        // PRIVATE INSTANCE VARIABLES 

        private double _weightInKg;

        private double _heightInCm;

        private double _bmi;

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
        }

        /// <summary>
        /// This is the CalculateBMI method event that calculates the BMI once the button is clicked 
        /// </summary>
        private void _CalculateBMI(double weight, double height)
        {
            // convert to meters
            height /= 100;

            BMI = weight / ()
        }
    }
}
