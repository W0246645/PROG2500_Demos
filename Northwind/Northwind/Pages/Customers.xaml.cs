using Microsoft.EntityFrameworkCore;
using Northwind.Data;
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

namespace Northwind.Pages
{
    /// <summary>
    /// Interaction logic for Customers.xaml
    /// </summary>
    public partial class Customers : Page
    {

        private readonly NorthwindContext _context = new NorthwindContext();
        private CollectionViewSource customerViewSource;
        public Customers()
        {
            InitializeComponent();
            customerViewSource = (CollectionViewSource)FindResource(nameof(customerViewSource));
            
        }

        private void Page_Loaded(Object sender, RoutedEventArgs e)
        {
            _context.Customers.Load();

            customerViewSource.Source = _context.Customers.Local.ToObservableCollection();
        }
    }
}
