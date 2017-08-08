using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Bradley Sutton
 * Created: August 03, 2017
 * Date: August 08, 2017
 * Student Number: 300280496
 * GitHub: https://github.com/SadleyButton/COMP123-S2017/Assignment5
 * Description - This is the splash screen for Assignment 5 - BMI Calculator
 *             - Created with timer (timeout 3 seconds)
 *             - Hide Splashscreen and display BMICalculator after timer
 * Version 0.1
 */

namespace COMP123_S2017_Assignment5
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            if (SplashScreenTimer.Enabled == true)
            {
                this.Hide();
                BMICalculator calulateBMI = new BMICalculator();
                calulateBMI.Show();
                SplashScreenTimer.Enabled = false;
            }

        }
    }
}
