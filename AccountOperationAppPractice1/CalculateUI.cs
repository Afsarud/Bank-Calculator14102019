using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class CalculateUI : Form
    {
        public CalculateUI()
        {
            InitializeComponent();
        }

        Calculator aCalculator = new Calculator();
        
        private void addButton_Click(object sender, EventArgs e)
        {
           aCalculator.FirstNam = Convert.ToDouble(firstTextBox.Text);
           aCalculator.SecondNam = Convert.ToDouble(SecondTextBox.Text);


            //firstTextBox.Clear();
            //SecondTextBox.Clear();

            double Result  = aCalculator.Add();

            resultTextBox.Text = Result.ToString();
          }

        private void subButton_Click(object sender, EventArgs e)
        {
            aCalculator.FirstNam = Convert.ToDouble(firstTextBox.Text);
            aCalculator.SecondNam = Convert.ToDouble(SecondTextBox.Text);


            //firstTextBox.Clear();
            //SecondTextBox.Clear();

            double Result = aCalculator.Sub();

            resultTextBox.Text = Result.ToString();

        }

        private void multButton_Click(object sender, EventArgs e)
        {
            aCalculator.FirstNam = Convert.ToDouble(firstTextBox.Text);
            aCalculator.SecondNam = Convert.ToDouble(SecondTextBox.Text);


            //firstTextBox.Clear();
            //SecondTextBox.Clear();

            double Result = aCalculator.Mult();

            resultTextBox.Text = Result.ToString();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            aCalculator.FirstNam = Convert.ToDouble(firstTextBox.Text);
            aCalculator.SecondNam = Convert.ToDouble(SecondTextBox.Text);


            //firstTextBox.Clear();
            //SecondTextBox.Clear();

            double Result = aCalculator.Div();

            resultTextBox.Text = Result.ToString();
        }
    }
}
