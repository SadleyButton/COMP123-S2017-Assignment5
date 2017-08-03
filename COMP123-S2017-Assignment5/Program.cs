using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/* Name: Bradley Sutton
 * Date: August 03, 2017
 * Student Number: 300280496
 * GitHub: https://github.com/SadleyButton/COMP123-S2017/Assignment5
 * Description - This is the Driver Class for the BMI Calculator Windows Form Application - COMP123 Assignment 5
 * Version 0.1
 */

namespace COMP123_S2017_Assignment5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
