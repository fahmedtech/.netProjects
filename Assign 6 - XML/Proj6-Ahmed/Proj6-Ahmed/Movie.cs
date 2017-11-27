using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Name: Faizan Ahmed
IT330 Project 6 - WPF DATA to XML
Date: 5/23/2016
*/

namespace Proj6_Ahmed
{
    public class Movie
    {
        //instantiating private variables
        private string _name, _plot, _year, _genre, _rating;

        //public constructor
        public Movie(string theName, string theGenre, String thePlot, string theRating, string theYear)
        {
            _name = theName;
            _plot = thePlot;
            _year = theYear;
            _genre = theGenre;
            _rating = theRating;
        }

        //public read-only properties
        public String Name { get { return _name; } }
        public String Genre { get { return _genre;  } }
        public String Plot { get { return _plot; } }
        public String Rating { get { return _rating; } }
        public String Year { get { return _year;  }  }
    }
}
