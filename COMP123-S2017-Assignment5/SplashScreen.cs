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
 * Date: August 11, 2017
 * Student Number: 300280496
 * GitHub: https://github.com/SadleyButton/COMP123-S2017/Assignment5
 * Description - This is the splash screen for Assignment 5 - BMI Calculator
 * Version 0.2 - Refactored adding properties for instantiation
 */

namespace COMP123_S2017_Assignment5
{
    public partial class SplashScreen : Form
    {
        //PROPERTIES
        public BMICalculator CalculateBMI
        {
            get { return Program.calculateBMI; }
        }

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.CalculateBMI.Show();
            SplashScreenTimer.Enabled = false;
            this.Hide();
        }
    }
}
