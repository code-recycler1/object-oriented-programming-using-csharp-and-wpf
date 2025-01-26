using System.Windows;

namespace WPF_Common_Controls_exercises
{
    /// <summary>
    /// Interaction logic for Exercise_1_Ideal_Weight.xaml
    /// </summary>
    public partial class Exercise_1_Ideal_Weight : Window
    {
        public Exercise_1_Ideal_Weight()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rbMale.IsChecked = true; // Set the Male RadioButton as default
        }

        // Event handler for the Male RadioButton (checked)
        private void rbMale_Checked(object sender, RoutedEventArgs e)
        {
            txtWristCircumference.IsEnabled = false; // Disable wrist circumference input for males
            txtWristCircumference.Text = ""; // Clear the wrist circumference field
        }

        // Event handler for the Female RadioButton (checked)
        private void rbFemale_Checked(object sender, RoutedEventArgs e)
        {
            txtWristCircumference.IsEnabled = true; // Enable wrist circumference input for females
        }

        // Event handler for the Reset button
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtLength.Text = ""; // Clear length input
            txtWristCircumference.Text = ""; // Clear wrist circumference input
            txtIdealWeight.Text = ""; // Clear ideal weight result
            rbMale.IsChecked = true; // Reset gender selection to Male
        }

        // Event handler for the Calculate button
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double idealWeight;

            // Check if the length input is a valid number
            if (double.TryParse(txtLength.Text, out double length))
            {
                // Calculate ideal weight based on gender
                if (rbMale.IsChecked == true)
                {
                    // Formula for males: 0.9 * (length - 100)
                    idealWeight = 0.9 * (length - 100);
                    txtIdealWeight.Text = idealWeight.ToString("n1"); // Display the result with 1 decimal place
                }
                else
                {
                    // Check if the wrist circumference input is a valid number for females
                    if (double.TryParse(txtWristCircumference.Text, out double wristCircumference))
                    {
                        // Formula for females: (length + (4 * wristCircumference) - 100) / 2
                        idealWeight = (length + (4 * wristCircumference) - 100) / 2;
                        txtIdealWeight.Text = idealWeight.ToString("n1"); // Display the result with 1 decimal place
                    }
                    else
                    {
                        // Show an error message if wrist circumference is invalid
                        MessageBox.Show("Wrist circumference must be a numeric value!", "Error");
                    }
                }
            }
            else
            {
                // Show an error message if length is invalid
                MessageBox.Show("Length must be a numeric value!", "Error");
            }
        }

        // Event handler for the Close button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Close the window
        }
    }
}
