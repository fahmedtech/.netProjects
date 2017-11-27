using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
Name: Faizan Ahmed
IT330 Project 6 - WPF DATA to XML
Date: 5/23/2016
*/

//importing new library for XML writer
using System.Xml;

namespace Proj6_Ahmed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //instantiating private Collection List of "Movies"
        private List<Movie> MovieList = null;

        private int _year;

        public MainWindow()
        {
            InitializeComponent();
            MovieList = new List<Movie>();
        }

        //Method ComboBox Control - Genre of Movie
        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            //Creating list for dropdown menus using List Collection
            List<String> genres = new List<String>();
            genres.Add("Action");
            genres.Add("Animation");
            genres.Add("Comedy");
            genres.Add("Romance");
            genres.Add("Drama");
            genres.Add("Fantasy");
            genres.Add("Thriller");

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = genres; //assigning to ComboBox all the data
            comboBox.SelectedIndex = 0;  //default selected value
        }

        //Method ComboBox Control - Genre (assigning value to String)
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            string selectedGenre = comboBox.SelectedItem as string;
        }

        //Method ComboBox Control - RATING
        private void cboRating_Loaded(object sender, RoutedEventArgs e)
        {
            //Creating list for dropdown menus using List Collection
            List<string> ratings = new List<string>();
            ratings.Add("G - General Audiences");
            ratings.Add("PG - Parental Guidance");
            ratings.Add("R - Restricted");

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = ratings; //assigning to ComboBox all the data
            comboBox.SelectedIndex = 0; //default selected value 
        }

        //Method ComboBox Control - Rating (assigning value to String)
        private void cboRating_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            string selectedRating = comboBox.SelectedItem as string;
        }

        //Method Button: Add Data to a List<Movie> and Write XML file
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //Calling Validation Method to validate Textboxes
            if (checkValidations())
            {
                //Creating a new movie using Movie Class
                Movie m = new Movie(txtName.Text, cboGenres.SelectedValue.ToString(), txtPlot.Text,
                                    cboRating.SelectedValue.ToString(), txtYear.Text);

                //adding to the List
                MovieList.Add(m);

                //Writing the Movie data into XML 
                XmlTextWriter writer = new XmlTextWriter("movies.xml", null);

                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';

                //Starting from the Root Element
                writer.WriteStartElement("Movies");
                foreach (Movie x in MovieList)
                {
                    writer.WriteStartElement("Movie");
                    writer.WriteElementString("Name", x.Name);
                    writer.WriteElementString("Genre", x.Genre);
                    writer.WriteElementString("Plot", x.Plot);
                    writer.WriteElementString("Rating", x.Rating);
                    writer.WriteElementString("Year", x.Year);
                    writer.WriteEndElement();
                }

                writer.WriteEndElement(); //End element for root 
                writer.Close(); //Closing the Writer object

                //Keeping the Count of the List<Movie>
                lblCount.Content = "Movies Count: " + MovieList.Count;

                MessageBox.Show("Movie has been added to List<Movie> and XML Successfully!");

                /* TESTING PURPOSE ONLY
                foreach(Movie x in MovieList)
                {
                    lblCount.Content = x.Name + "\n " ;
                }*/
            }
        }

        //Method Boolean - Validates the Values of the Textboxes
        private Boolean checkValidations()
        {
            //Validating Name Textbox Field
            if (String.IsNullOrEmpty(txtName.Text))
            {
                txtName.BorderBrush = new SolidColorBrush(Colors.Red);
                lblError.Content = "ERR: Name Field Empty!";
                return false;
            }
            else
            {
                lblError.Content = "";
                txtName.BorderBrush = new SolidColorBrush(Colors.Black);
            }

            //Validating Plot Textbox Field
            if (String.IsNullOrEmpty(txtPlot.Text))
            {
                txtPlot.BorderBrush = new SolidColorBrush(Colors.Red);
                lblError.Content = "ERR: Plot Field Empty!";
                return false;
            }
            else
            {
                lblError.Content = "";
                txtPlot.BorderBrush = new SolidColorBrush(Colors.Black);
            }

            //Validating Year Textbox field - Values (1000-9999 only)
            if (String.IsNullOrEmpty(txtYear.Text) || !Int32.TryParse(txtYear.Text, out _year) || _year < 1000 || _year >= 9999)
            {
                txtYear.BorderBrush = new SolidColorBrush(Colors.Red);
                lblError.Content = "ERR: Invalid Year Input!";
                return false;
            }
            else
            {
                lblError.Content = "";
                txtYear.BorderBrush = new SolidColorBrush(Colors.Black);
            }

            return true;
        }

        //Method Button: Clears All of the Control Values
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //5 Form controls
            txtName.Text = "";
            cboGenres.SelectedIndex = 0;
            txtPlot.Text = "";
            cboRating.SelectedIndex = 0;
            txtYear.Text = "";

            //misc control
            lblError.Content = "";
        }
    }//end of class
}
