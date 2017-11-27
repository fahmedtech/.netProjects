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

namespace Proj5_Ahmed
{
    public partial class view_applications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SimpleFormContext context = new SimpleFormContext())
            {
                //variable of Applicants as List
                var applicants = context.Applicants.ToList();

                //Looping over Applicant's properties and assigning Values to control
                foreach (Applicant a in applicants)
                {
                    lblData.Text = lblData.Text + 
                    "Name: " + a.FirstName + " " + a.LastName + "<br/>" +
                    "Gender: " + a.Gender + "<br/>" +
                    "DePaul ID: " + a.DepaulID + " | " +
                    "Major: " + a.Major + "<br/> <strong> Contact Information </strong> <br/>" +
                    "Email: " +  a.Email + "<br/>" +
                    "Cellphone: " + a.Cellphone + 
                    "<br/>  _________________________________________________________ <br/> <br/>";
                }
            }
        }//end of void method
    }
}