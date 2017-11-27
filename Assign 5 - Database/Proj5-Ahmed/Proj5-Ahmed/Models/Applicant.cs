using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
Name: Faizan Ahmed
IT330 - Project 5: DePaul IT Club Form | Database 
Date: 5/15/2016
*/

namespace Proj5_Ahmed.Models
{
    public class Applicant
    {
        //read and write properties of an Applicant
        public int ID { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }

        public int DepaulID { get; set; }

        public String Major { get; set; }
        public String Email { get; set; }
        public String Cellphone { get; set; }
    }
}