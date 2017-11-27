using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Proj5_Ramirez.Models;

namespace Proj5_Ramirez
{
    public partial class view_applications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using(SimpleFormContext context = new SimpleFormContext())
            {
                var customersLists = context.Customers.ToList();


                foreach(Customer customer in customersLists)
                {
                    lblCustomerData.Text = customer.FirstName + "<br/>" +
                                           customer.LastName + "<br/>" +
                                           customer.Address + "<br/>" +
                                           customer.City + "<br/>" +
                                           customer.State + "<br/>" +
                                           customer.Zip + "<br/>" +
                                           customer.CandyBar + "<br/>" +
                                           customer.EmailAddress + "<br/> <br/>";
                }


            }

          

        }
    }
}