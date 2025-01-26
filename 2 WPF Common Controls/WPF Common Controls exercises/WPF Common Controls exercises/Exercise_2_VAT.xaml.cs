using System.Windows;

namespace WPF_Common_Controls_exercises
{
    /// <summary>
    /// Interaction logic for Exercise_2_VAT.xaml
    /// </summary>
    public partial class Exercise_2_VAT : Window
    {
        public Exercise_2_VAT()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rb21.IsChecked = true; // Set the 21% VAT option as default
        }

        // Event handler for the Reset button
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtAmount.Text = ""; // Clear the amount input
            txtAmountIncludingVAT.Text = ""; // Clear the result
            rb21.IsChecked = true; // Reset VAT percentage to 21%
        }

        // Event handler for the Calculate button
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double amountIncludingVAT = 0;

            // Check if the amount input is a valid number
            if (double.TryParse(txtAmount.Text, out double amount))
            {
                amountIncludingVAT = amount; // Initialize with the base amount

                // Calculate the amount including VAT based on the selected VAT percentage
                if (rb6.IsChecked == true)
                {
                    amountIncludingVAT *= 1.06; // Add 6% VAT
                }
                else if (rb12.IsChecked == true)
                {
                    amountIncludingVAT *= 1.12; // Add 12% VAT
                }
                else if (rb0.IsChecked == true)
                {
                    amountIncludingVAT *= 1.00; // Add 0% VAT
                }
                else
                {
                    amountIncludingVAT *= 1.21; // Default to 21% VAT
                }

                // Display the result with 2 decimal places
                txtAmountIncludingVAT.Text = amountIncludingVAT.ToString("n2");
            }
            else
            {
                // Clear the result and show an error message if the input is invalid
                txtAmountIncludingVAT.Text = "";
                MessageBox.Show("Amount must be a numeric value!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for the Close button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Close the window
        }
    }
}