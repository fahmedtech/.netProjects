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

using Proj3_Ahmed;

namespace Proj3_Ahmed_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VendingMachine vm;

        public MainWindow()
        {
            vm = new VendingMachine();
            InitializeComponent();
        }

        private void btnInsertQuarters_Click(object sender, RoutedEventArgs e)
        {
            vm.DepositQuarter();
            lblQuartersInserted.Content = vm.NumQuarters;
        }

        private void btnCandy1_Click(object sender, RoutedEventArgs e)
        {
            vm.SelectCandy(0);
            imgCandyPicture.Source = new BitmapImage(new Uri("/images/h.jpg", UriKind.Relative));
            lblCandysCount.Content = vm.NumCandyBars(0) + " Candy Bars Remaining";

        }

        private void btnCandy2_Click(object sender, RoutedEventArgs e)
        {
            vm.SelectCandy(1);
            imgCandyPicture.Source = new BitmapImage(new Uri("/images/mk.jpg", UriKind.Relative));
            lblCandysCount.Content = vm.NumCandyBars(1) + " Candy Bars Remaining";
        }

        private void btnCandy3_Click(object sender, RoutedEventArgs e)
        {
            vm.SelectCandy(2);
            imgCandyPicture.Source = new BitmapImage(new Uri("/images/mm.jpg", UriKind.Relative));
            lblCandysCount.Content = vm.NumCandyBars(2) + " Candy Bars Remaining";
        }
    }
}
