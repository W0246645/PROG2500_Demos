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

namespace UserControlsDemo
{
    /// <summary>
    /// Interaction logic for ClickerControl.xaml
    /// </summary>
    public partial class ClickerControl : UserControl
    {
        public string theText;
        public ClickerControl()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = theText;
        }
    }
}
