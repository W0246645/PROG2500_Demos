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

namespace DataBindingInWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private VideoGame game;
        //public VideoGameDataContext Context { get; set; }

        private VideoGameDataContext _context = new VideoGameDataContext();
        private CollectionViewSource gamesViewSource;
        public MainWindow()
        {
            InitializeComponent();
            gamesViewSource = (CollectionViewSource)FindResource(nameof(gamesViewSource));
            //_context = new VideoGameDataContext();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gamesViewSource.Source = _context.Games.ToList();
        }
    }
}
