using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalculadora
{
    public partial class MainPage : ContentPage
    {
        private string currentInput = "";
        private string currentOperator = "";
        private double result = 0.0;
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnNumberButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            resultLabel.Text = currentInput;
        }
        private void OnOperatorButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentOperator = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
        }
        private void OnEqualButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentOperator) && !string.IsNullOrEmpty(currentInput))
            {
                double secondOperand = double.Parse(currentInput);
                switch (currentOperator)
                {
                    case "+":
                        result += secondOperand;
                        break;
                    case "-":
                        result -= secondOperand;
                        break;
                    case "*":
                        result *= secondOperand;
                        break;
                    case "/":
                        if (secondOperand != 0)
                            result /= secondOperand;
                        else
                            resultLabel.Text = "Error";
                        break;
                }
                resultLabel.Text = result.ToString();
                currentInput = "";
                currentOperator = "";
            }
        }
       

    }
}




