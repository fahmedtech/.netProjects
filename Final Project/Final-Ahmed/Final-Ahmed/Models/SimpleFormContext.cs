using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Name: Faizan Ahmed
Collaborated with Miguel Ramirez
IT330 Final Project
Video Game Library Application
*/

//importing Libraries
using System.Data.Entity;

namespace Final_Ahmed.Models
{
    //inheriting from DbContext
    public class SimpleFormContext : DbContext
    {
        public SimpleFormContext() : base("name=SimpleFormContext")
        {
            //Database.SetInitializer<SimpleFormContext>(new DropCreateDatabaseIfModelChanges<SimpleFormContext>());
        }

        //read and write Property for VideoGames
        public DbSet<VideoGame> VideoGames { get; set; }
    }
}
