using System.Windows;
using System.Windows.Media;

namespace WPF_Common_Controls_examples
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

        private void rbRed_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.Background = Brushes.Red;
            lblResult.Foreground = Brushes.White;
        }

        private void rbBlue_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.Background = Brushes.Blue;
            lblResult.Foreground = Brushes.White;
        }

        private void rbGreen_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.Background = Brushes.Green;
            lblResult.Foreground = Brushes.White;
        }
        private void rbWhite_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.Background = Brushes.White;
            lblResult.Foreground = Brushes.Black;
        }

        private void cbBold_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.FontWeight = FontWeights.Bold;
        }

        private void cbBold_Unchecked(object sender, RoutedEventArgs e)
        {
            lblResult.FontWeight = FontWeights.Normal;
        }

        private void cbItalic_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.FontStyle = FontStyles.Italic;
        }

        private void cbItalic_Unchecked(object sender, RoutedEventArgs e)
        {
            lblResult.FontStyle = FontStyles.Normal;
        }

    }
}
