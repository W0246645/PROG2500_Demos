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
    /// Interaction logic for ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        private NorthwindContext _context = new NorthwindContext();
        private CollectionViewSource productsViewSource;

        public ProductsPage()
        {
            InitializeComponent();
            productsViewSource = (CollectionViewSource)FindResource(nameof(productsViewSource));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Products.Load();
            productsViewSource.Source = _context.Products.Local.ToObservableCollection();
        }
    }
}
