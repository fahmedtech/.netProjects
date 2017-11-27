using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
Name: Faizan Ahmed
IT330 Project 6 - View XML Data on a Webform
Date: 5/29/2016
*/

namespace Proj6_Ahmed_WebForm.Models
{
    public class Movie
    {
        //instantiating private variables
        private string _name, _plot, _year, _genre, _rating;

        //public no-arg constructor
        public Movie()
        {

        }

        //public constructor
        public Movie(string theName, string theGenre, String thePlot, string theRating, string theYear)
        {
            _name = theName;
            _plot = thePlot;
            _year = theYear;
            _genre = theGenre;
            _rating = theRating;
        }

        //public 5 read and write properties
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public String Plot
        {
            get { return _plot; }
            set { _plot = value; }
        }
        public String Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public String Year
        {
            get { return _year; }
            set { _year = value; }
        }
    }
}