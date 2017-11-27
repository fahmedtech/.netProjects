using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace Proj5_Ramirez.Models
{
    public class SimpleFormContext : DbContext
    {

        public SimpleFormContext() : base("name=SimpleFormContext")
        {
            Database.SetInitializer<SimpleFormContext>(new DropCreateDatabaseIfModelChanges<SimpleFormContext>());
        }

        public DbSet<Customer> Customers { get; set; }

    }
}