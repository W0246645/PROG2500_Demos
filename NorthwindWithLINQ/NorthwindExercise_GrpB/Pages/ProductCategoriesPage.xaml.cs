using Microsoft.EntityFrameworkCore;
using NorthwindExercise_GrpB.Data;
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
    /// Interaction logic for ProductCategoriesPage.xaml
    /// </summary>
    public partial class ProductCategoriesPage : Page
    {
        private readonly NorthwindContext _context = new NorthwindContext();
        private CollectionViewSource categoriesViewSource;
        public ProductCategoriesPage()
        {
            InitializeComponent();
            categoriesViewSource = (CollectionViewSource)FindResource(nameof(categoriesViewSource));

            _context.Categories.Load();
            _context.Products.Load();

            categoriesViewSource.Source = _context.Categories.Local.ToObservableCollection();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            var query = _context.Categories
                .Where(c => c.CategoryName.Contains(txtSearch.Text))
                .GroupBy(c => c.CategoryName.ToUpper().Substring(0,1))
                .Select(g => new {
                    Index = g.Key,
                    CatCount = g.Count().ToString(), 
                    Cat = g.ToList()
                }).ToList();

            categoriesListView.ItemsSource = query;
        }
    }
}
