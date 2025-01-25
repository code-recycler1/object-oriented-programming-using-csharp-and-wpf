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
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the Red RadioButton
        private void rbRed_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.Background = Brushes.Red; // Set background to Red
            lblResult.Foreground = Brushes.White; // Set text color to White for better contrast
        }

        // Event handler for the Blue RadioButton
        private void rbBlue_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.Background = Brushes.Blue; // Set background to Blue
            lblResult.Foreground = Brushes.White; // Set text color to White for better contrast
        }

        // Event handler for the Green RadioButton
        private void rbGreen_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.Background = Brushes.Green; // Set background to Green
            lblResult.Foreground = Brushes.White; // Set text color to White for better contrast
        }

        // Event handler for the White RadioButton
        private void rbWhite_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.Background = Brushes.White; // Set background to White
            lblResult.Foreground = Brushes.Black; // Set text color to Black for better contrast
        }

        // Event handler for the Bold CheckBox (checked)
        private void cbBold_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.FontWeight = FontWeights.Bold; // Set font weight to Bold
        }

        // Event handler for the Bold CheckBox (unchecked)
        private void cbBold_Unchecked(object sender, RoutedEventArgs e)
        {
            lblResult.FontWeight = FontWeights.Normal; // Set font weight back to Normal
        }

        // Event handler for the Italic CheckBox (checked)
        private void cbItalic_Checked(object sender, RoutedEventArgs e)
        {
            lblResult.FontStyle = FontStyles.Italic; // Set font style to Italic
        }

        // Event handler for the Italic CheckBox (unchecked)
        private void cbItalic_Unchecked(object sender, RoutedEventArgs e)
        {
            lblResult.FontStyle = FontStyles.Normal; // Set font style back to Normal
        }
    }
}