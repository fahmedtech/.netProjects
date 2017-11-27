using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proj5_Ramirez.Models
{
    public class Customer
    {
        public int ID { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }
        public String CandyBar { get; set; }
        public String EmailAddress { get; set; }   
    }
}