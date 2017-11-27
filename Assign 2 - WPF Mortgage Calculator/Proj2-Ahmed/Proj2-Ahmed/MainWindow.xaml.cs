using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//Name: Faizan Ahmed
//IT-330 Project 2: Mortgage Calculator WPF
//Date: 4/15/2016 

namespace Proj2_Ahmed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Instantiating private variables
        //Rate is a slider (which already has double value) - hence not instantiated
        private double _principal, _year;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Method Slider: Rounding Double Value and assigning to a Label for display
        private void sldRate_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double NewValue = Math.Round(e.NewValue, 2);
            lblRate.Content = NewValue.ToString();

            txtSliderValue.Text = Math.Round(sldRate.Value, 2).ToString(); //textbox value
        }

        //Method Button: Calculates the Mortgage based on Inputted/Selected Values
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            String CalculatedAmount;

            //Calling IsValidated() Method for Validation and Errors
            if (IsValidated())
            {
                //Checking Radio buttons values in StackPanel and Assigning Values
                foreach (RadioButton button in stkYear.Children)
                {
                    if (button.IsChecked.Value)
                    {
                        if (button.Content.ToString() == "15 Years")
                            _year = 15.0;

                        else if (button.Content.ToString() == "30 Years")
                            _year = 30.0;
                    }
                }

                //Breakdown computation of the Monthly Mortgage Payment formula
                //sldRate is the Slider (has Double Value)
                double rate_div = (sldRate.Value / 1200.0);
                double rate_pow = Math.Pow((1.0 + rate_div), -12.00 * _year);

                double mortgage_h1 = (_principal * rate_div);
                double mortgage_h2 = (1 - rate_pow);

                //Final computation
                double ComputeMortgage = mortgage_h1 / mortgage_h2;

                //Adding the ComputeMortgage to String and showing output in Label
                CalculatedAmount = "Result: " + Math.Round(ComputeMortgage, 2).ToString("C");
                lblOutput.Content = CalculatedAmount.ToString();
            }
        }

        //Method Boolean: Validates the Values for the Textboxes
        private bool IsValidated()
        {
            //1st - Validating the Principal Amount
            if (String.IsNullOrEmpty(txtPrincipal.Text) || !Double.TryParse(txtPrincipal.Text, out _principal) ||
                _principal <= 0)
            {
                txtPrincipal.BorderBrush = new SolidColorBrush(Colors.Red);
                lblErrorPrin.Content = "Invalid Input!";
                return false;
            }
            else
            {
                lblErrorPrin.Content = "";
                txtPrincipal.BorderBrush = new SolidColorBrush(Colors.Black);
            }
                
            //2nd - Validating the Other Amount for Year
            if (String.IsNullOrEmpty(txtOther.Text) || !Double.TryParse(txtOther.Text, out _year) || _year < 0)
            {
                txtOther.BorderBrush = new SolidColorBrush(Colors.Red);
                lblErrorYear.Content = "Invalid Input!";
                return false;
            }
            else
            {
                lblErrorYear.Content = "";
                txtOther.BorderBrush = new SolidColorBrush(Colors.Black);
            }
                

            return true;
        }

        //Method Button: Resets the Values of all the Objects and Labels
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtPrincipal.Text = "0.00";
            txtOther.Text = "0";
            sldRate.Value = 0;
            lblOutput.Content = "$0.00";
        }

        //Method RadioButton 15 Years: Disables and reset's "Other" textbox value (when checked)
        private void rad15_Checked(object sender, RoutedEventArgs e)
        {
            if (rad15.IsChecked.Value)
            {
                txtOther.Text = "0";
                lblErrorYear.Content = "";
                txtOther.IsEnabled = false;
            }
        }

        //Method RadioButton 30 Years: Disables and reset's "Other" textbox value (when checked)
        private void rad30_Checked(object sender, RoutedEventArgs e)
        {
            if (rad30.IsChecked.Value)
            {
                txtOther.Text = "0";
                lblErrorYear.Content = "";
                txtOther.IsEnabled = false;
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //txtSliderValue.Text = sldRate.Value;
        }

        //Method RadioButton Other Years: Enables "Other" textbox (when checked)
        private void radOther_Checked(object sender, RoutedEventArgs e)
        {
            if (radOther.IsChecked.Value)
                txtOther.IsEnabled = true;
        }
    }
}
