using System.Windows;

namespace WPF_Start_exercises
{
    /// <summary>
    /// Interaction logic for Exercise_3_Cash_Register.xaml
    /// </summary>
    public partial class Exercise_3_Cash_Register : Window
    {
        public Exercise_3_Cash_Register()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the "Clear" button
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            // Clear the input fields and the bill label
            txtPrice.Text = "";
            txtNumber.Text = "";
            lblBill.Content = "";
        }

        // Event handler for the "Calculate" button
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double bill;

            // Check if the input values are valid
            if (double.TryParse(txtPrice.Text, out double price) && int.TryParse(txtNumber.Text, out int number))
            {
                // Calculate the total bill
                bill = price * number;

                // Display the total bill with 2 decimal places and the Euro symbol
                lblBill.Content = $"{bill:0.00} €";
            }
            else
            {
                // Display an error message if the input is invalid
                MessageBox.Show("Please enter valid numeric values for price and quantity.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for the "Close" button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Closes the current window
        }
    }
}
