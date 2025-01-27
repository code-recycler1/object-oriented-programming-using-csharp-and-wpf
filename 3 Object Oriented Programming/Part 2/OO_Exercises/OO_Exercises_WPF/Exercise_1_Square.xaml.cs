using System.Windows;
using OO_Exercises_Models;

namespace OO_Exercises_WPF
{
    public partial class Exercise_1_Square : Window
    {
        // Declare a Square object to hold the square data
        Square square = null;

        public Exercise_1_Square()
        {
            InitializeComponent(); // Initialize the UI components defined in XAML
        }

        // Event handler for the Initialize button
        private void btnInitialize_Click(object sender, RoutedEventArgs e)
        {
            // Validate the input and create a Square object
            if (int.TryParse(txtSide.Text, out int length))
            {
                square = new Square(length); // Create a new Square with the specified side length
            }
            else
            {
                // Show an error message if the input is not a valid number
                MessageBox.Show("Side must be a numeric value!", "Error");
            }
        }

        // Event handler for the Draw button
        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            if (square != null)
            {
                // Display the drawn square in the label
                lblResult.Content = square.Draw();
            }
            else
            {
                MessageBox.Show("Please initialize the square first!", "Error");
            }
        }

        // Event handler for the Perimeter button
        private void btnPerimeter_Click(object sender, RoutedEventArgs e)
        {
            if (square != null)
            {
                // Display the perimeter in a MessageBox
                MessageBox.Show($"The perimeter is {square.Perimeter()}", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please initialize the square first!", "Error");
            }
        }

        // Event handler for the Area button
        private void btnArea_Click(object sender, RoutedEventArgs e)
        {
            if (square != null)
            {
                // Display the area in a MessageBox
                MessageBox.Show($"The area is {square.Area()}", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please initialize the square first!", "Error");
            }
        }

        // Event handler for the Diagonal button
        private void btnDiagonal_Click(object sender, RoutedEventArgs e)
        {
            if (square != null)
            {
                // Display the diagonal length in a MessageBox (formatted to 2 decimal places)
                MessageBox.Show($"The diagonal is {square.Diagonal():n2}", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please initialize the square first!", "Error");
            }
        }

        // Event handler for the Close button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Close the window
        }
    }
}