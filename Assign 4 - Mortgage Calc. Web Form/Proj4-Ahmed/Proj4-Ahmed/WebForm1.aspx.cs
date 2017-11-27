using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
Name: Faizan Ahmed
IT-330 Project 4: Mortgage Calculator WebForm
Date: 5/1/2016
*/

namespace Proj4_Ahmed
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Instantiating private variables
        //Rate is a DropDownList (value is converted to Double).
        private double _principal, _year;

        protected void Page_Load(object sender, EventArgs e)
        {
            rblYears_SelectedIndexChanged(sender, e); //calling event method to disable the Other Year Textbox as page loads
        }

        //Method Button: Calculates the Mortgage based on Input/Selected Control Values
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            string calculatedAmount;

            //Calling isDoubleValidation() Method for validating the textboxes and checking errors
            if (isDoubleValidation())
            {
                //looping through the list of RadioButtonList value
                foreach (ListItem list in rblYears.Items)
                {
                    if (list.Selected)
                    {
                        //assigning value to _year if the specific RadioButtonList is selected
                        if (list.Text.Equals("15 Years"))
                            _year = Convert.ToDouble(list.Value); //converting value to double: 15
                        else if (list.Text.Equals("30 Years"))
                            _year = Convert.ToDouble(list.Value); //converting value to double: 30
                    }
                }

                //Breakdown computation of the Monthly Mortgage Payment formula
                //ddlInterestRate is the DropDownList (value is converted to Double)
                double rate_div = (Convert.ToDouble(ddlInterestRate.SelectedValue) / 1200.0);
                double rate_pow = Math.Pow((1.0 + rate_div), -12.00 * _year);

                double mortgage_h1 = (_principal * rate_div);
                double mortgage_h2 = (1 - rate_pow);

                //Final computation
                double ComputeMortgage = mortgage_h1 / mortgage_h2;

                //Adding the ComputeMortgage to String and showing output in Label
                calculatedAmount = "Result: " + Math.Round(ComputeMortgage, 2).ToString("C");
                lblCalculatedValue.Text = calculatedAmount.ToString();
            }
        }

        //Method RadioButtonList: enabling and disabling the txtOtherYear textbox
        protected void rblYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblYears.SelectedItem.Text.Equals("15 Years") || rblYears.SelectedItem.Text.Equals("30 Years"))
            {
                txtOtherYear.Enabled = false;
                txtOtherYear.Text = "0";
            }
            else
                txtOtherYear.Enabled = true;
        }

        //UNIMPLEMENTED METHOD
        protected void txtOtherYear_TextChanged(object sender, EventArgs e)
        {
            //lblCalculatedValue.Text = "Result " + txtOtherYear.Text;
        }

        //Method Button: Resetting the values of all Controls
        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "";
            txtOtherYear.Text = "0";
            rblYears.SelectedIndex = 0;
            ddlInterestRate.SelectedIndex = 0;
            lblCalculatedValue.Text = "Result: $0.00";
        }

        //Method Boolean: Validates the Values for the Textbox Control fields (to Double)
        private Boolean isDoubleValidation()
        {
            //validating the "Principal" amount
            if (String.IsNullOrEmpty(txtPrincipal.Text) || !Double.TryParse(txtPrincipal.Text, out _principal))
            {
                txtPrincipal.BorderColor = System.Drawing.Color.Red;
                lblPrincipalError.Text = "Invalid Input!";
                return false;
            }
            else
            {
                lblPrincipalError.Text = "";
                txtPrincipal.BorderColor = System.Drawing.Color.Black;
            }

            //validating the "Other" amount for year
            if (String.IsNullOrEmpty(txtOtherYear.Text) || !Double.TryParse(txtOtherYear.Text, out _year))
            {
                txtOtherYear.BorderColor = System.Drawing.Color.Red;
                lblOtherYearError.Text = "Invalid Input!";
                return false;
            }
            else
            {
                lblOtherYearError.Text = "";
                txtOtherYear.BorderColor = System.Drawing.Color.Black;
            }

            return true;
        }
    } //end of class
}