﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Prince Sharma
//301043771

namespace COMP123_Assignment4_BMIcalculator
{
    public partial class BMICalculator : Form
    {
        // PRIVATE DATA MEMBERS
        private TextBox m_activeLabel;

        // PUBLIC PROPERTIES
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }

        public float UserHeight { get; set; }
        public float UserWeight { get; set; }

        public BMICalculator()
        {
            InitializeComponent();
        }

        public TextBox ActiveLabel
        {
            get
            {
                return m_activeLabel;
            }

            set
            {
                // check if m_activeLabel is already pointing at a label
                if (m_activeLabel != null)
                {
                    m_activeLabel.BackColor = Color.White;
                }

                m_activeLabel = value;

                // check if m_activeLabel has not been set to null
                if (m_activeLabel != null)
                {
                    m_activeLabel.BackColor = Color.LightBlue;
                }
            }
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            outputString = "0";
        }

        /// <summary>
        /// This checks if Imperial unit button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            MetreLabel.Text = "in";
            KilogramLabel.Text = "Lb";
        }

        /// <summary>
        /// This checks if metric unit button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
             MetreLabel.Text = "m";
            KilogramLabel.Text = "Kg";
        }


        /// <summary>
        /// This is an Event handler For Calculate BMI click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            //
            UserHeight = float.Parse(HeightTextbox.Text);
            UserWeight = float.Parse(WeightTextbox.Text);

            double height = Convert.ToDouble(HeightTextbox.Text);
            double weight = Convert.ToDouble(WeightTextbox.Text);
            double result;
            if (MetricUnitRadioButton.Checked == true)
            {
                result = weight / (height * height);
            }
            else
            {
                result = (weight * 703) / (height * height);
            }

            CalculatedBMITextBox.Text = result.ToString();
        }


        /// <summary>
        /// This is an click event for Reset Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ImperialUnitRadioButton.Checked = true;
            CalculatedBMITextBox.Text = "";
            WeightTextbox.Text = "";
            HeightTextbox.Text = "";
        }

        /// <summary>
        /// This is the event handler for the HeightLabel click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveLabel_Click(object sender, EventArgs e)
        {
            ActiveLabel = sender as TextBox;
            ActiveLabel.BackColor = Color.LightBlue;


            NumberButtonTableLayoutPanel.Location = new Point(12, ActiveLabel.Location.Y + 55);
            NumberButtonTableLayoutPanel.BringToFront();

            if (ActiveLabel.Text != "0")
            {
                outputString = ActiveLabel.Text;
            }


            NumberButtonTableLayoutPanel.Visible = true;
        }

        /// <summary>
        /// This is the shared Event Handler for all of the Calculator Buttons' Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButtons_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;

            bool numericResult = int.TryParse(tag, out numericValue);

            if (numericResult)
            {
                int maxSize = (decimalExists) ? 5 : 3;

                if (outputString == "0")
                {
                    outputString = tag;
                }
                else if (outputString.Length < 5)
                {
                    outputString += tag;
                }

                ActiveLabel.Text = outputString;
            }
            else
            {
                switch (tag)
                {
                    case "back":
                        removeLastCharacterFromResultLabel();
                        break;
                    case "done":
                        finalizeOuput();
                        break;
                    case "clear":
                        clearNumericKeyboard();
                        break;
                    case "decimal":
                        addDecimalToResultLabel();
                        break;
                }
            }
        }

        /// <summary>
        /// This method adds a decimal point to the resultLabel
        /// </summary>
        private void addDecimalToResultLabel()
        {
            if (!decimalExists)
            {
                outputString += ".";
                decimalExists = true;
            }
        }


        /// <summary>
        /// This method finalizes and converts the outputString to a floating point value
        /// </summary>
        private void finalizeOuput()
        {
            outputValue = float.Parse(outputString);

            outputValue = (float)(Math.Round(outputValue, 1));

            if (outputValue < 0.1f)
            {
                outputValue = 0.1f;
            }
            ActiveLabel.Text = outputValue.ToString();
            clearNumericKeyboard();
            NumberButtonTableLayoutPanel.Visible = false;
            ActiveLabel.BackColor = Color.White;
            ActiveLabel = null;
        }

        /// <summary>
        /// This method removes the last character from the Result Label
        /// </summary>
        private void removeLastCharacterFromResultLabel()
        {
            var lastChar = outputString.Substring(outputString.Length - 1);
            if (lastChar == ".")
            {
                decimalExists = false;
            }
            outputString = outputString.Remove(outputString.Length - 1);

            if (outputString.Length == 0)
            {
                outputString = "0";
            }

            ActiveLabel.Text = outputString;
        }

        /// <summary>
        /// This method resets the numeric keyboard and related variables
        /// </summary>
        private void clearNumericKeyboard()
        {
            outputString = "0";
            outputValue = 0.0f;
            decimalExists = false;
        }
    }
}
