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

namespace EventsDemo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageTextBlock.Text += "\n" + sender.GetType().Name + " was clicked.";
        }

        private void SecondButton_Click(object sender, RoutedEventArgs e)
        {
            MessageTextBlock.Text += "\n" + "Second button was clicked.";
        }

        private void ClickMeButton_MouseMove(object sender, MouseEventArgs e)
        {
            //
            double x = e.GetPosition(this).X;
            double y = e.GetPosition(this).Y;
            MessageTextBlock.Text = "Current position in " + sender.GetType().Name + ": " + x + " : " + y;
        }
    }
}
