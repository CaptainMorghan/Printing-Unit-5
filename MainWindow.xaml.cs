//Morghan Kiverago 27/05/2019
//Printing
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

namespace Printing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            double NumberOfCopies;
            double Cost1 = 0.30;
            double Cost2 = 0.28;
            double Cost3 = 0.27;
            double Cost4 = 0.26;
            double Cost5 = 0.25;
            double TotalCost;
            double.TryParse(txtinput.Text, out NumberOfCopies);
            if (NumberOfCopies > 0 && NumberOfCopies < 100)
            {
                lblPricePerCopy.Content = "Price per Copy is $0.30";
                TotalCost = NumberOfCopies * Cost1;
                lblTotalCost.Content = TotalCost;
            }
            else if (NumberOfCopies >= 100 && NumberOfCopies < 500)
            {
                lblPricePerCopy.Content = "Price Per Copy is $0.28";
                TotalCost = NumberOfCopies * Cost2;
                lblTotalCost.Content = TotalCost;
            }
            else if (NumberOfCopies >= 500 && NumberOfCopies < 750)
            {
                lblPricePerCopy.Content = "Price Per Copy is $0.27";
                TotalCost = NumberOfCopies * Cost3;
                lblTotalCost.Content = TotalCost;
            }
            else if (NumberOfCopies >= 750 && NumberOfCopies < 1000)
            {
                lblPricePerCopy.Content = "Price Per Copy is $0.26";
                TotalCost = NumberOfCopies * Cost4;
                lblTotalCost.Content = TotalCost;
            }
            else if (NumberOfCopies >= 1000)
            {
                lblPricePerCopy.Content = "Price Per copy is $0.25";
                TotalCost = NumberOfCopies * Cost5;
                lblTotalCost.Content = TotalCost;
            }
        
    }
    }
}
