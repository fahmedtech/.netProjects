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
IT330 - Project 3 (Console Application)
Vending Machine Class File
Date: 4/20/2016
*/
using Proj3_Ahmed;

namespace Proj3_Ahmed_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Instantiating VendingMachine Class Object
        private VendingMachine _vm;

        public MainWindow()
        {
            InitializeComponent();
            _vm = new VendingMachine();

            //Initializing Quarter Label Content values
            lblCountQuarter.Content = _vm.NumQuarters;

            //Initializing Candy bars count Label Content values
            lblCountTwix.Content = _vm.NumCandyBars(0);
            lblCountSnickers.Content = _vm.NumCandyBars(1);
            lblCountKitkat.Content = _vm.NumCandyBars(2);
        }

        //Button Method: Depositing Quarters
        private void btnDepositQuarter_Click(object sender, RoutedEventArgs e)
        {
            _vm.DepositQuarter();  //_numQuarters++;
            lblCountQuarter.Content = _vm.NumQuarters;
        }

        //Button Method: Twix Candybar
        private void btnTwix_Click(object sender, RoutedEventArgs e)
        {
            //check for validation | display candy image | select the candy at index[0]
            WarnIfEmpty();
            imgDisplay.Source = new BitmapImage(new Uri("/Images/twix.jpg", UriKind.Relative));
            _vm.SelectCandy(0);

            //Displaying number of Candybars and Quarters left
            lblCountCandies.Content = _vm.NumCandyBars(0);
            lblCountTwix.Content = _vm.NumCandyBars(0);
            lblCountQuarter.Content = _vm.NumQuarters;
        }

        //Button Method: Snickers Candybar
        private void btnSnickers_Click(object sender, RoutedEventArgs e)
        {
            //check for validation | display candy image | select the candy at index[1]
            WarnIfEmpty();
            imgDisplay.Source = new BitmapImage(new Uri("/Images/snickers.jpg", UriKind.Relative));
            _vm.SelectCandy(1);

            //Displaying number of Candybars and Quarters left
            lblCountCandies.Content = _vm.NumCandyBars(1);
            lblCountSnickers.Content = _vm.NumCandyBars(1);
            lblCountQuarter.Content = _vm.NumQuarters;
        }

        //Button Method: KitKat Candybar
        private void btnKitKat_Click(object sender, RoutedEventArgs e)
        {
            //check for validation | display candy image | select the candy at index[2]
            WarnIfEmpty();
            imgDisplay.Source = new BitmapImage(new Uri("/Images/kitkat.png", UriKind.Relative));
            _vm.SelectCandy(2);

            //Displaying number of Candybars and Quarters left
            lblCountCandies.Content = _vm.NumCandyBars(2);
            lblCountKitkat.Content = _vm.NumCandyBars(2);
            lblCountQuarter.Content = _vm.NumQuarters;
        }

        //Method WarnIfEmpty() - disable buttons or pop-up  MessageboxsCandybars
        private void WarnIfEmpty()
        {
            //disable the button if the number of candy is less than 1
            if (_vm.NumCandyBars(0) < 1)
                btnTwix.IsEnabled = false;
            if (_vm.NumCandyBars(1) < 1)
                btnSnickers.IsEnabled = false;
            if (_vm.NumCandyBars(2) < 1)
                btnKitKat.IsEnabled = false;

            //shows Messagebox if number of quarters equals 0 or less than 3
            if (_vm.NumQuarters == 0)
                MessageBox.Show("No Quarters Inserted. Please deposit Quarters to purchase!");
            else if (_vm.NumQuarters > 0 && _vm.NumQuarters < 3)
                MessageBox.Show("Insufficient Quarters to purchase this Candybar!");
        }

    } //end-of-class
}
