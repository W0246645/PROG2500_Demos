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

namespace NorthwindExercise_GrpB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Pages.HomePage homePage { get; set; } 
        public Pages.ProductsPage productsPage { get; set; }
        public Pages.ProductSearchPage productSearchPage { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            homePage = new Pages.HomePage();
            productsPage = new Pages.ProductsPage();
            productSearchPage = new Pages.ProductSearchPage();

            mainFrame.NavigationService.Navigate(homePage);
        }

        private void ProductsButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(productsPage);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(homePage);
        }

        private void ProductSearchButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(productSearchPage);
        }
    }
}
