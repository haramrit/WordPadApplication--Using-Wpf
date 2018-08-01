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

namespace WordPadApplication
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

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            statBarText.Text = "Exit the Application";
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            statBarText.Text = "Ready";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Use to add exit functionality
            this.Close();
        }

        private void MenuItem_MouseEnter_1(object sender, MouseEventArgs e)
        {
            statBarText.Text = "Show Spelling Suggestions";
        }

        private void MenuItem_MouseLeave_1(object sender, MouseEventArgs e)
        {
            statBarText.Text = "Ready";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            string spellingHints = string.Empty;

            //try to  get a spelling error at the current caret location
            SpellingError error = txtData.GetSpellingError(txtData.CaretIndex);
            if (error != null)
            {
                foreach (string s in error.Suggestions)
                {
                    spellingHints += $"{s}\n";
                }
                lblSpellingHints.Content = spellingHints;
                expanderSpelling.IsExpanded = true;
            }
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {

        }

        private void Button_MouseLeave_1(object sender, MouseEventArgs e)
        {

        }
    }
}
