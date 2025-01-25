using System;
using System.Windows;

namespace WPF_Start_exercises
{
    /// <summary>
    /// Interaction logic for Exercise_2_Circle.xaml
    /// </summary>
    public partial class Exercise_2_Circle : Window
    {
        public Exercise_2_Circle()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the "Calculate" button
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double circumference, area;
            string message;

            const double PI = 3.1415926535897931; // Constant value for Pi

            // Check if the input is a valid number
            if (double.TryParse(txtRadius.Text, out double radius))
            {
                // Calculate the circumference and area of the circle
                circumference = 2 * radius * PI;
                area = radius * radius * PI;

                // Format the results into a message
                message = $"Circumference: {circumference,10:0.00}" + Environment.NewLine +
                          $"Area: {area,19:0.00}";
            }
            else
            {
                // Display an error message if the input is invalid
                message = "Please enter a valid numeric value for the radius!";
            }

            // Display the message in the notification label
            lblMessage.Content = message;
        }
    }
}
