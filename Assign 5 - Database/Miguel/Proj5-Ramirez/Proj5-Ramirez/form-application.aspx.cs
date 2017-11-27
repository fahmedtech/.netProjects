using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Proj5_Ramirez.Models;

using System.Text.RegularExpressions;

namespace Proj5_Ramirez
{
    public partial class form_application : System.Web.UI.Page
    {
        private Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnApplyNow_Click(object sender, EventArgs e)
        {

            using(SimpleFormContext context = new SimpleFormContext())
            {
                if (isValidated())
                {
                    Customer customer = new Customer();
                    customer.FirstName = txtFirstname.Text;
                    customer.LastName = txtLastname.Text;
                    customer.Address = txtAddress.Text;
                    customer.City = ddlCity.SelectedValue;
                    customer.State = txtState.Text;
                    customer.Zip = txtZipcode.Text;
                    customer.CandyBar = rblCandy.SelectedValue;
                    customer.EmailAddress = txtEmailAddress.Text;

                    context.Customers.Add(customer);
                    context.SaveChanges();

                }
            }
        }

        private bool isValidated()
        {
            //firstname
            if (String.IsNullOrEmpty(txtFirstname.Text))
            {
                txtFirstname.BorderColor = System.Drawing.Color.Red;
                return false;
            }
            else
                txtFirstname.BorderColor = System.Drawing.Color.Black;

            //lastname
            if (String.IsNullOrEmpty(txtLastname.Text))
            {
                txtLastname.BorderColor = System.Drawing.Color.Red;
                return false;
            }
            else
                txtLastname.BorderColor = System.Drawing.Color.Black;

            //address
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                txtAddress.BorderColor = System.Drawing.Color.Red;
                return false;
            }
            else
                txtAddress.BorderColor = System.Drawing.Color.Black;

            //state
            if (String.IsNullOrEmpty(txtState.Text))
            {
                txtState.BorderColor = System.Drawing.Color.Red;
                return false;
            }
            else
                txtState.BorderColor = System.Drawing.Color.Black;

            //zip
            if (String.IsNullOrEmpty(txtZipcode.Text))
            {
                txtZipcode.BorderColor = System.Drawing.Color.Red;
                return false;
            }
            else
                txtZipcode.BorderColor = System.Drawing.Color.Black;

            //email with regular expression
            if (String.IsNullOrEmpty(txtEmailAddress.Text) || !email.IsMatch(txtEmailAddress.Text))
            {
                txtEmailAddress.BorderColor = System.Drawing.Color.Red;
                return false;
            }
            else
                txtEmailAddress.BorderColor = System.Drawing.Color.Black;

            return true;
        }
    }
}