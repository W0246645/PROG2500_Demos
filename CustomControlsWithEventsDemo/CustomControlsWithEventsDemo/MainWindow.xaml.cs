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

namespace CustomControlsWithEventsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            firstIncr.IncrementMe += IncrementMe;
            secondIncr.IncrementMe += IncrementMe;
        }

        private void IncrementMe(object? sender, EventArgs e)
        {
            int i = int.Parse(DisplayBox.Text);
            DisplayBox.Text = (i+1).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid.SetColumn(firstIncr, 0);
        }
    }
}
