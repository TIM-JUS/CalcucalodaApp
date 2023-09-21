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
        

    }
}




