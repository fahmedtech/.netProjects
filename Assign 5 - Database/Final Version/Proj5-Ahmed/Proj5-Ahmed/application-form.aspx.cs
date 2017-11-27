using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
Name: Faizan Ahmed
IT330 - Project 5: DePaul IT Club Form | Database 
Date: 5/15/2016
*/

using Proj5_Ahmed.Models;
using System.Text.RegularExpressions;

namespace Proj5_Ahmed
{
    public partial class FormPage : System.Web.UI.Page
    {
        //instantiating int variable
        private int _depaulID;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        //Method Button: Creates a new Applicant
        protected void btnSubmitForm_Click(object sender, EventArgs e)
        {
            using (SimpleFormContext context = new SimpleFormContext())
            {
                //Check for validations
                if (checkValidations())
                {
                    //creating a new Applicant and assigning Values to its properties
                    Applicant applicant = new Applicant();
                    applicant.FirstName = txtFirstName.Text;
                    applicant.LastName = txtLastName.Text;
                    applicant.Gender = rblGender.SelectedValue;
                    applicant.DepaulID = _depaulID; 
                    applicant.Major = ddlMajor.SelectedValue;
                    applicant.Email = txtEmail.Text;
                    applicant.Cellphone = txtCellphone.Text;

                    //adding Applicant to the database
                    context.Applicants.Add(applicant);
                    context.SaveChanges();

                    lblValue.Text = "Form was Successfully Processed!";
                    //lblValue.Text = applicant.ID.ToString(); //test
                }
            }
        }

        //Method Boolean: Checking the Validations for the Textboxes
        private Boolean checkValidations()
        {
            //instantiating two Regular expressions for Phone and Email
            Regex rgxPhone = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            Regex rgxEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            //validating the First Name textbox
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.BackColor = System.Drawing.Color.Red;
                //txtFirstName.BorderColor = System.Drawing.Color.Red;
                //lblFirstnameErr.Text = "First Name cannot be Empty.";
                return false;
            }
            else
            {
                //lblFirstnameErr.Text = "";
                txtFirstName.BackColor = System.Drawing.Color.White;
            }

            //validating the Last Name textbox
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.BackColor = System.Drawing.Color.Red;
                //txtLastName.BorderColor = System.Drawing.Color.Red;
                //lblLastnameErr.Text = "Last Name cannot be Empty.";
                return false;
            }
            else
            {
                //lblLastnameErr.Text = "";
                txtLastName.BackColor = System.Drawing.Color.White;
            }

            //validating Depaul ID textbox - Numeric & Length 7
            if (String.IsNullOrEmpty(txtDePaulID.Text) || !Int32.TryParse(txtDePaulID.Text, out _depaulID) || txtDePaulID.Text.Length != 7)
            {
                txtDePaulID.BackColor = System.Drawing.Color.Red;
                //lblDepaulIDErr.Text = "Depaul ID should be a Number and of Length 7";
                return false;
            }
            else
            {
                //lblDepaulIDErr.Text = "";
                txtDePaulID.BackColor = System.Drawing.Color.White;
            }

            //validating the Email ID with Regular Expression
            if (String.IsNullOrEmpty(txtEmail.Text) || !rgxEmail.IsMatch(txtEmail.Text))
            {
                txtEmail.BackColor = System.Drawing.Color.Red;
                //lblEmailErr.Text = "Incorrect Email Format";
                return false;
            }
            else
            {
                //lblEmailErr.Text = "";
                txtEmail.BackColor = System.Drawing.Color.White;
            }

            //validating the Cellphone textbox with Regular Expression & Length 12
            if (String.IsNullOrEmpty(txtCellphone.Text) || !rgxPhone.IsMatch(txtCellphone.Text) || txtCellphone.Text.Length != 12)
            {
                txtCellphone.BackColor = System.Drawing.Color.Red;
                //lblCellphoneErr.Text = "Cellphone format should be xxx-xxx-xxxx";
                return false;
            }
            else
            {
                //lblCellphoneErr.Text = "";
                txtCellphone.BackColor = System.Drawing.Color.White;
            }

            return true;
        }//end of checkValidations() method.

        //clear all of the information in the Controls
        protected void btnClearForm_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            rblGender.SelectedValue = "Male";
            txtDePaulID.Text = "";
            ddlMajor.SelectedIndex = 0;
            txtEmail.Text = "";
            txtCellphone.Text = "";
            lblValue.Text = "";
        }
    }
}