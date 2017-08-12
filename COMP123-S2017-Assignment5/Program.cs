using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/* Name: Bradley Sutton
 * Date: August 03, 2017
 * Date: August 11, 2017
 * Student Number: 300280496
 * GitHub: https://github.com/SadleyButton/COMP123-S2017/Assignment5
 * Description - This the driver class for the BMI Calculator Windows Form
 * Version 0.3 - Refactored for instantiation on loading event
 */

namespace COMP123_S2017_Assignment5
{
    public static class Program
    {
        //FORM INSTANTIATION
        public static BMICalculator calculateBMI;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            calculateBMI = new BMICalculator();

            Application.Run(new SplashScreen());
        }
    }
}
