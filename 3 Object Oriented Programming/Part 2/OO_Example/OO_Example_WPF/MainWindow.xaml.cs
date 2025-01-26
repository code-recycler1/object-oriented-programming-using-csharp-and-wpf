using System.Windows;
using OO_Example_Models;

namespace OO_Example_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Initialize the UI components defined in XAML
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Set the ComboBox to display the FullName property of User objects
            cmbUser.DisplayMemberPath = "FullName";
        }

        // Event handler for the Save button
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            User user1;

            // Validate input fields
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text))
            {
                // Check if the number is provided and valid
                if (int.TryParse(txtNumber.Text, out int i))
                {
                    // Create a User object with number, first name, and last name
                    user1 = new User(i, txtFirstName.Text, txtLastName.Text);
                }
                else
                {
                    // Create a User object without a number
                    user1 = new User(txtFirstName.Text, txtLastName.Text);
                }

                // Add the user to the ComboBox
                cmbUser.Items.Add(user1);
            }
            else
            {
                // Show an error message if input is invalid
                MessageBox.Show("Please enter valid data.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for the Show Data button
        private void btnShowData_Click(object sender, RoutedEventArgs e)
        {
            // Check if a user is selected in the ComboBox
            if (cmbUser.SelectedItem is User user)
            {
                // Display the user's data in the label
                lblResult.Content = user.ShowData(" ");
            }
        }

        // Event handler for the Clear button
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // Remove the selected user from the ComboBox
            cmbUser.Items.Remove(cmbUser.SelectedItem);
        }
    }
}