
using System;
using System.Data;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxResult.Text += button.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxResult.Text += button.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(textBoxResult.Text, null);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                textBoxResult.Text = "Error";
            }
        }
    }
}
