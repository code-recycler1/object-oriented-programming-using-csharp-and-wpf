using System.Windows;
using OO_Example_Models;

namespace OO_Example_WPF
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

        // Create two User objects
        User user1 = new User();
        User user2 = new User();

        // Event handler for the Save button
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Validate the input fields
            if (int.TryParse(txtNumber.Text, out int number) &&
                !string.IsNullOrEmpty(txtFirstName.Text) &&
                !string.IsNullOrEmpty(txtLastName.Text))
            {
                // Save the data to user1
                user1.Number = number;
                user1.FirstName = txtFirstName.Text;
                user1.LastName = txtLastName.Text;

                // Display the user data in the result label
                lblResult.Content = user1.ShowData();
            }
            else
            {
                // Show an error message if the input is invalid
                MessageBox.Show("Please fill in all fields correctly.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for the Second Object button
        private void btnSecondObject_Click(object sender, RoutedEventArgs e)
        {
            // Set default data for user2
            user2.Number = 2;
            user2.FirstName = "Jane";
            user2.LastName = "Doe";

            // Append the user2 data to the result label
            lblResult.Content += user2.ShowData();
        }

        // Event handler for the Clear button
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            // Clear the data of both user objects
            user1.Clear();
            user2.Clear();

            // Clear the result label
            lblResult.Content = "";
        }
    }
}