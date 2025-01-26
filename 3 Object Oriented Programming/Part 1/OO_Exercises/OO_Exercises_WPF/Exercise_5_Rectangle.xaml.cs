using System.Windows;
using OO_Exercises_Models;

namespace OO_Exercises_WPF
{
    /// <summary>
    /// Interaction logic for Exercise_5_Rectangle.xaml
    /// </summary>
    public partial class Exercise_5_Rectangle : Window
    {
        public Exercise_5_Rectangle()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the Calculate button
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Validate and parse the input values
            if (double.TryParse(txtHeight.Text, out double height) &&
                double.TryParse(txtWidth.Text, out double width))
            {
                // Create a new Rectangle object
                Rectangle rectangle = new Rectangle();

                // Set the properties of the Rectangle object
                rectangle.Height = height;
                rectangle.Width = width;

                // Display the result using the ShowData method
                lblResult.Content = rectangle.ShowData();
            }
            else
            {
                // Show an error message if the input is invalid
                MessageBox.Show("Please enter valid numeric values for height and width.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
