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
 * Date: August 03, 2017
 * Student Number: 300280496
 * GitHub: https://github.com/SadleyButton/COMP123-S2017/Assignment5
 * Description - Added - try/catch for detection of input for BMI Calculation
 *             - Modified UI to add labels for unit of input, toggled from RadioButtons
 *             - Draft Three of UI, compliment display of calculationed results
 * Version 0.2
 */

namespace COMP123_S2017_Assignment5
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // PRIVATE INSTANCE VARIABLES
            double height, weight, bmi = 0;

            // COLOUR RESET; from highlighted result ranged
            UnderweightLabel.ForeColor = Color.Black;
            NormalWeightLabel.ForeColor = Color.Black;
            OverWeightLabel.ForeColor = Color.Black;
            ObeseLabel.ForeColor = Color.Black;
            BMIResultTextBox.ForeColor = Color.Black;

            // Try will validate entries against double, check metric flag, and calculate
            // Catch will find entries outside the double range and display error
            try
            {
                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);

                if (MetricRadioButton.Checked == true)
                {
                    bmi = Math.Round((weight / (height * height)), 1);
                    BMIResultTextBox.Text = Convert.ToString(bmi);
                    BMIResult();
                }
                else
                {
                    bmi = Math.Round(((weight * 703) / (height * height)), 1);
                    BMIResultTextBox.Text = Convert.ToString(bmi);
                    BMIResult();
                }
            }
            // Returns values not within double as an error, such as alphabetic entries.
            // Changes calculator title to reflect error & null in result box
            catch
            {
                BMICalculatorLabel.Text = "INCORRECT";
                BMICalculatorLabel.ForeColor = Color.Red;
                BMIResultTextBox.Text = "NULL";
                BMIResultTextBox.ForeColor = Color.Red;
            }

            // Highlights the range of the BMI calculated result
            // Reverts title text if previous was entered with error(s)
            void BMIResult()
            {
                if (bmi < 18.5)
                    UnderweightLabel.ForeColor = Color.Orange;
                else if (bmi >= 18.5 && bmi < 25)
                    NormalWeightLabel.ForeColor = Color.Blue;
                else if (bmi >= 25 && bmi < 30)
                    OverWeightLabel.ForeColor = Color.Blue;
                else
                    ObeseLabel.ForeColor = Color.Orange;

                BMICalculatorLabel.Text = "BMI Calculator";
                BMICalculatorLabel.ForeColor = Color.Black;
            }
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricRadioButton.Checked == true)
            {
                MetricRadioButton.ForeColor = Color.Blue;
                HeightUnitLabel.Text = "Meters";
                WeightUnitLabel.Text = "Kilograms";
            }
            else MetricRadioButton.ForeColor = Color.Black;
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked == true)
            {
                ImperialRadioButton.ForeColor = Color.Blue;
                HeightUnitLabel.Text = "Inches";
                WeightUnitLabel.Text = "Pounds";
            }
            else ImperialRadioButton.ForeColor = Color.Black;
        }

        /// <summary>
        /// This is the event handler for the "FormClosing" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}