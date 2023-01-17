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
using System.Windows.Shapes;

namespace FirstWPFDemo
{
    /// <summary>
    /// Interaction logic for CommandingDemo.xaml
    /// </summary>
    public partial class CommandingDemo : Window
    {
        public CommandingDemo()
        {
            InitializeComponent();
        }

        private void Cut_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (SourceTextbox != null) && (SourceTextbox.SelectionLength > 0);
        }

        private void Cut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SourceTextbox.Cut();
        }

        private void Copy_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (SourceTextbox != null) && (SourceTextbox.SelectionLength > 0);
        }

        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SourceTextbox.Copy();
        }

        private void Paste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }

        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TargetTextbox.Paste();
        }
    }
}
