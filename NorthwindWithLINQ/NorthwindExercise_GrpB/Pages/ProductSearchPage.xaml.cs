using Microsoft.EntityFrameworkCore;
using NorthwindExercise_GrpB.Data;
using NorthwindExercise_GrpB.Models;
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

namespace NorthwindExercise_GrpB.Pages
{
    /// <summary>
    /// Interaction logic for ProductSearchPage.xaml
    /// </summary>
    public partial class ProductSearchPage : Page
    {
        private NorthwindContext _context = new NorthwindContext();

        public ProductSearchPage()
        {
            InitializeComponent();

            _context.Products.Load();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            results.Items.Clear();

            var searchTerm = textSearch.Text;

            var searchResults = _context.Products.Where(product => product.ProductName.Contains(searchTerm)).ToList();
            results.ItemsSource = searchResults;
        }
    }
}
