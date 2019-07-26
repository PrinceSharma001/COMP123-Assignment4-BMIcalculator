using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Assignment4_BMIcalculator
{
    public partial class BMICalculator : Form
    {
        public float UserHeight { get; set; }
        public float UserWeight { get; set; }


        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }

        private void ImperialUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            MetreLabel.Text = "in";
            KilogramLabel.Text = "Lb";
        }

        private void MetricUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
             MetreLabel.Text = "m";
            KilogramLabel.Text = "Kg";
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            //Only Numeric Value can be enter
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            WeightTextbox.Text = "";
            HeightTextbox.Text = "";
            MetricUnitRadioButton.Checked = false;
            ImperialUnitRadioButton.Checked = true;
            CalculatedBMITextBox.Text = "";
           
        }

        private void NumberButtonTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
