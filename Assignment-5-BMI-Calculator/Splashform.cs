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
 * Desc: This is the BMI calculator Splashform
 * Ver: 0.2 - Implemented Splashform to BMICalculator form
 */

namespace Assignment_5_BMI_Calculator
{
    public partial class BMICalculatorSplashForm : Form
    {
        // PUBLIC PROPERTIES 

        public BMICalculator BMICalculatorForm
        {
            get
            {
                return Program.BMIcalculatorForm;
            }
        }

        public BMICalculatorSplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.BMICalculatorForm.Show();
            this.Hide();

            SplashFormTimer.Enabled = true;
        }
    }
}
