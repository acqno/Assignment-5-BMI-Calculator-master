using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Alvun Quijano
 * Student No: 300795606
 * Date: Aug 14, 2017
 * Desc: This is the BMI calculator project
 * Ver: 0.2 - Added the Splashform
 */

namespace Assignment_5_BMI_Calculator
{
    public static class Program
    {
        public static BMICalculator BMIcalculatorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BMIcalculatorForm = new BMICalculator();

            Application.Run(new BMICalculatorSplashForm());
        }
    }
}
