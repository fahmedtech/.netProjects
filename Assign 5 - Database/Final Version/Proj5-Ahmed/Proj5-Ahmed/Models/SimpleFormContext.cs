using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
Name: Faizan Ahmed
IT330 - Project 5: DePaul IT Club Form | Database 
Date: 5/15/2016
*/
using System.Data.Entity;

namespace Proj5_Ahmed.Models
{
    public class SimpleFormContext : DbContext
    {
        //constructor - making Connection
        public SimpleFormContext() : base ("name=SimpleFormContext")
        {
           //Database.SetInitializer<SimpleFormContext>(new DropCreateDatabaseIfModelChanges<SimpleFormContext>());
        }

        //read and write properties for Applicant
        public DbSet<Applicant> Applicants { get; set; }
    }
}