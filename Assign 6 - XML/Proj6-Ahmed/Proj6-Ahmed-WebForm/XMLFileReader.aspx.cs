using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
Name: Faizan Ahmed
IT330 Project 6 - View XML Data on a Webform
Date: 5/29/2016
*/

//importing Libraries
using Proj6_Ahmed_WebForm.Models;
using System.IO;
using System.Xml;

namespace Proj6_Ahmed_WebForm
{
    public partial class XMLFileReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Button Method: Uploads XML file data in Memory (Displays New Panel of Table Data)
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            //If File has been uploaded
            if (upFile.HasFile)
            {
                List<Movie> movieList = new List<Movie>(); //creating an empty Movie instance
                MemoryStream stream = null;

                try
                {
                    //copying data into memory
                    stream = new MemoryStream(upFile.FileBytes);
                    //giving data in memory to XMLTextReader
                    XmlTextReader reader = new XmlTextReader(stream);

                    Movie newMovie = null;
                    string lastElementName = "";

                    //Reading the XML File to extract Data
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            //Case for getting the Elements
                            case XmlNodeType.Element:
                                if (reader.Name == "Movie")
                                {
                                    newMovie = new Movie();
                                }
                                else if (reader.Name == "Name" || reader.Name == "Genre" || reader.Name == "Plot" || reader.Name == "Rating" || reader.Name == "Year")
                                {
                                    lastElementName = reader.Name;
                                }
                                break;

                            //Case for getting Values
                            case XmlNodeType.Text:
                                switch (lastElementName)
                                {
                                    case ("Name"): newMovie.Name = reader.Value; break;
                                    case ("Genre"): newMovie.Genre = reader.Value; break;
                                    case ("Plot"): newMovie.Plot = reader.Value; break;
                                    case ("Rating"): newMovie.Rating = reader.Value; break;
                                    case ("Year"): newMovie.Year = reader.Value; break;
                                }
                                break;

                            //Case for End Element and Adding movie to List<Movie>
                            case XmlNodeType.EndElement:
                                if (reader.Name == "Movie")
                                {
                                    movieList.Add(newMovie);
                                }
                                break;
                        }
                    }//end of while loop

                    //adding all the movies from the List<Movie> to Table Rows
                    foreach (Movie m in movieList)
                    {
                        TableRow row = new TableRow();
                        row.Cells.Add(new TableCell { Text = m.Name });
                        row.Cells.Add(new TableCell { Text = m.Genre });
                        row.Cells.Add(new TableCell { Text = m.Plot });
                        row.Cells.Add(new TableCell { Text = m.Rating });
                        row.Cells.Add(new TableCell { Text = m.Year });
                        tblMovies.Rows.Add(row);
                    }

                    //setting upload panel "invisible"
                    pnlUpload.Visible = false;
                    //setting Movies Table panel to "visible"
                    pnlMovies.Visible = true;
                }
                catch (Exception)
                {
                    //output the Error on Label
                    lblError.Text = "An Error has Occured. Please Try again.";
                }
                finally
                {
                    //closing the strem
                    stream.Close();
                }
            }
        }//end of method
    }
}