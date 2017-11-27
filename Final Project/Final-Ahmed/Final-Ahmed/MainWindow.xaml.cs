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
Collaborated with Miguel Ramirez
IT330 Final Project
Video Game Library Application
*/

//importing Libraries
using Final_Ahmed.Models;

namespace Final_Ahmed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private instantiated variable
        private int _year;

        //MainWindow - initialized Image and 'Delete' Button Disabled
        public MainWindow()
        {
            InitializeComponent();
            imgPhoto.Source = new BitmapImage(new Uri("/Images/logo.jpg", UriKind.Relative));
            btnDelete.IsEnabled = false;
        }

        //Method Button: Save Game in Database 
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //using the SimpleFormContext for DB
            using (SimpleFormContext context = new SimpleFormContext())
            {
                //Complete Validations
                if (checkIfValidated())
                {
                    //creating new instance of VideoGame - assigning Values from WPF Controls to VideoGame Properties
                    VideoGame game = new VideoGame();
                    game.Title = txtTitle.Text;
                    game.Year = txtYear.Text;
                    game.Developers = txtDev.Text;
                    game.Rating = cboRating.SelectedValue.ToString();

                    if (radPS4.IsChecked.Value)
                        game.Platform = "PS4";
                    else if (radXbox1.IsChecked.Value)
                        game.Platform = "Xbox One";

                    game.Genre = cboGenre.SelectedValue.ToString();
                    game.ImageName = txtImage.Text;

                    //Adding Game to Context and saving Database file
                    context.VideoGames.Add(game);
                    context.SaveChanges();

                    //Displaying MessageBox after completion
                    MessageBox.Show("Video Game has been Successfully Saved!" + "\n" +
                                "Please Restart Application for Changes to be Applied.");

                    btnClear_Click(sender, e);
                }
            }
        }

        //Method Button: Clear the Controls form
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //clearing Label
            lblError.Content = "";

            //clearing Textbox fields and reset BorderBrush Color
            txtTitle.Text = "";
            txtTitle.BorderBrush = new SolidColorBrush(Colors.Black);

            txtYear.Text = "";
            txtYear.BorderBrush = new SolidColorBrush(Colors.Black);

            txtDev.Text = "";
            txtDev.BorderBrush = new SolidColorBrush(Colors.Black);

            txtImage.Text = "";
            txtImage.BorderBrush = new SolidColorBrush(Colors.Black);

            //resetting ComboBox - selecting First Item in List
            cboRating.SelectedIndex = 0;
            cboGenre.SelectedIndex = 0;

            //resetting RadioButtons - PS4 is selected by Default
            radXbox1.IsChecked = false;
            radPS4.IsChecked = true;

            //resetting Image Source to "logo.jpg"
            imgPhoto.Source = new BitmapImage(new Uri("/Images/logo.jpg", UriKind.Relative));
        }

        //Method ComboBox Rating: Loads the List of Ratings into ComboBox 
        private void cboRating_Loaded(object sender, RoutedEventArgs e)
        {
            //creating a List<String> and adding Ratings
            List<String> RatingsList = new List<String>();
            RatingsList.Add("A");
            RatingsList.Add("B");
            RatingsList.Add("C");
            RatingsList.Add("D");
            RatingsList.Add("F");

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = RatingsList; //Adding List to ComboBox ItemsSource
            comboBox.SelectedIndex = 0; //Selecting the First Item in List when Application is Started
        } 

        //Method ComboBox Genre: Loads the List of Genres into ComboBox
        private void cboGenre_Loaded(object sender, RoutedEventArgs e)
        {
            //creating a List<String> and adding Genres
            List<String> GenresList = new List<String>();
            GenresList.Add("Role Playing Game");
            GenresList.Add("Action Adventure");
            GenresList.Add("First Person Shooter");
            GenresList.Add("Fighting");
            GenresList.Add("Survival Horror");
            GenresList.Add("Puzzle");
            GenresList.Add("Sports");

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = GenresList; //Adding List to ComboBox ItemsSource
            comboBox.SelectedIndex = 0; //Selecting the First Item in List when Application is Started
        }

        //Method Boolean: Validating the Textboxes
        private Boolean checkIfValidated()
        {
            //Validating 'Title' textbox
            if (String.IsNullOrEmpty(txtTitle.Text))
            {
                txtTitle.BorderBrush = new SolidColorBrush(Colors.Red);
                lblError.Content = "'Title' Cannot be Empty!";
                return false;
            }
            else
            {
                txtTitle.BorderBrush = new SolidColorBrush(Colors.Black);
                lblError.Content = "";
            }

            //Validating 'Developers' textbox
            if (String.IsNullOrEmpty(txtDev.Text))
            {
                txtDev.BorderBrush = new SolidColorBrush(Colors.Red);
                lblError.Content = "'Developers' Cannot be Empty!";
                return false;
            }
            else
            {
                txtDev.BorderBrush = new SolidColorBrush(Colors.Black);
                lblError.Content = "";
            }

            //Validating 'Year' textbox - Checking if Numeric and Year <1995 or >Current Year
            if (String.IsNullOrEmpty(txtYear.Text) || !int.TryParse(txtYear.Text, out _year) || _year < 1995 || _year > DateTime.Today.Year)
            {
                txtYear.BorderBrush = new SolidColorBrush(Colors.Red);
                lblError.Content = "Invalid 'Year'. Range (1995-Today)!";
                return false;
            }
            else
            {
                txtYear.BorderBrush = new SolidColorBrush(Colors.Black);
                lblError.Content = "";
            }

            //Validating 'Image' field - Checking whether .jpg format filename only
            if (String.IsNullOrEmpty(txtImage.Text) || !txtImage.Text.ToString().EndsWith(".jpg"))
            {
                txtImage.BorderBrush = new SolidColorBrush(Colors.Red);
                lblError.Content = "Invalid 'Image' Format! name.jpg";
                return false;
            }
            else
            {
                txtImage.BorderBrush = new SolidColorBrush(Colors.Black);
                lblError.Content = "";
            }

            //after all Validations checked return True
            return true;
        }

        //ComboBox Method: Loads the List of VideoGame(s) into ComboBox
        private void cboGamesList_Loaded(object sender, RoutedEventArgs e)
        {
            //Using SimpleFormContext to access the VideoGame(s) as List
            using (SimpleFormContext context = new SimpleFormContext())
            {
                //creating List<VideoGame> and updating DB Count on Label
                var gamesList = context.VideoGames.ToList();
                lblDBCount.Content = "Games in Database: " + gamesList.Count;

                //New List<String> of just VideoGame(s) 'Title'
                List<String> gameTitlesList = new List<String>();

                //adding all Titles to List<String>
                foreach(VideoGame game in gamesList)
                {
                    gameTitlesList.Add(game.Title);
                }
              
                var comboBox = sender as ComboBox;
                comboBox.ItemsSource = gameTitlesList; //Adding List<String> to ComboBox ItemsSource
                //comboBox.SelectedIndex = 0; - No Value Selected by Default (When Not in 'View Game Mode')
            }
        }

        //ComboBox Method: SelectionChanged() for GamesList ComboBox
        private void cboGamesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //clearing Errors from Label
            lblError.Content = "";

            //changing Label Color and Weight to Signify the 'View Game Mode' Feature
            lblViewGame.Foreground = new SolidColorBrush(Colors.Red);
            lblViewGame.FontWeight = FontWeights.Bold;

            //ComboBox item as String
            string comboString = (sender as ComboBox).SelectedItem as string;
            //ComboBoxItem cbi = (ComboBoxItem)cboGamesList.SelectedItem;

            //When using 'View Game Mode' - Disable 'Clear' & 'Save' Buttons 
            btnClear.IsEnabled = false;
            btnSave.IsEnabled = false;
            btnDelete.IsEnabled = true;

            using (SimpleFormContext context = new SimpleFormContext())
            {
                //initializing VideoGame(s) as List
                var gamesList = context.VideoGames.ToList();

                foreach (VideoGame game in gamesList)
                {
                    //condition: if comboBox item matches the VideoGame 'Title' Property - Then Remove from DB
                    if (comboString.Equals(game.Title))
                    {
                        //Retrieving all VideoGame Properties values to WPF controls
                        //Disabling all WPF Controls for complete 'View Game Mode' Experience
                        txtTitle.Text = game.Title;
                        txtTitle.IsEnabled = false;

                        txtYear.Text = game.Year;
                        txtYear.IsEnabled = false;

                        txtDev.Text = game.Developers;
                        txtDev.IsEnabled = false;

                        cboRating.SelectedValue = game.Rating;
                        cboRating.IsEnabled = false;

                        if (game.Platform.Equals("PS4"))
                            radPS4.IsChecked = true;
                        else if (game.Platform.Equals("Xbox One"))
                            radXbox1.IsChecked = true;

                        radPS4.IsEnabled = false;
                        radXbox1.IsEnabled = false;

                        cboGenre.SelectedValue = game.Genre;
                        cboGenre.IsEnabled = false;

                        txtImage.Text = game.ImageName;
                        txtImage.IsEnabled = false;
                        imgPhoto.Source = new BitmapImage(new Uri("/Images/" + game.ImageName, UriKind.Relative));
                    }
                }
            }
           // lblDBCount.Content = cbi.
        }

        //Method Button: Remove the VideoGame from Database (Only when User is in 'View Mode')
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //ComboBox item as String
            string comboString = (cboGamesList as ComboBox).SelectedItem as string;

            using(SimpleFormContext context = new SimpleFormContext())
            {
                //initializing VideoGame(s) as List
                var gamesList = context.VideoGames.ToList();

                //New List<String> of just VideoGame(s) 'Title'
                List<String> gameTitlesList = new List<String>();

                foreach (VideoGame game in gamesList)
                {
                    //condition: if comboBox item matches the VideoGame 'Title' Property - Then Remove from DB
                    if (comboString.Equals(game.Title))
                    {
                        context.VideoGames.Remove(game);
                        context.SaveChanges();
                    }
                }
                //Display MessageBox after Completion
                MessageBox.Show("Game has been deleted from Database!" + "\n" +
                                "Please Restart Application for Changes to be Applied.");
            }
        }
    }//end of class
}
