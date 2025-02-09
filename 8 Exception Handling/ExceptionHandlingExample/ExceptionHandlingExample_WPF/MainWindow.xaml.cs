using ExceptionHandlingExample_DAL;
using ExceptionHandlingExample_Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ExceptionHandlingExample_WPF
{
    public partial class MainWindow : Window
    {
        // File operations handler
        private FileOperations fileOperations = new FileOperations();

        // List to store all users
        private List<User> listOfUsers = new List<User>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for window load
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Set the default radio button to "User"
            rbUser.IsChecked = true;

            // Load users from file and bind to ComboBox
            listOfUsers = fileOperations.ReadFile("doc\\users.txt");
            cmbUsers.ItemsSource = listOfUsers;
        }

        // Event handler for "User" radio button
        private void rbUser_Checked(object sender, RoutedEventArgs e)
        {
            // Hide scholarship checkbox and salary fields
            ControlsVisibility(
                controlCheckBoxHasScholarship: Visibility.Hidden,
                controlLabelSalary: Visibility.Hidden,
                controlTextBoxSalary: Visibility.Hidden
            );
        }

        // Event handler for "Teacher" radio button
        private void rbTeacher_Checked(object sender, RoutedEventArgs e)
        {
            // Show salary fields and hide scholarship checkbox
            ControlsVisibility(
                controlCheckBoxHasScholarship: Visibility.Hidden,
                controlLabelSalary: Visibility.Visible,
                controlTextBoxSalary: Visibility.Visible
            );
        }

        // Event handler for "Student" radio button
        private void rbStudent_Checked(object sender, RoutedEventArgs e)
        {
            // Show scholarship checkbox and hide salary fields
            ControlsVisibility(
                controlCheckBoxHasScholarship: Visibility.Visible,
                controlLabelSalary: Visibility.Hidden,
                controlTextBoxSalary: Visibility.Hidden
            );
        }

        // Event handler for "Add" button
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validate inputs
                if (int.TryParse(txtNumber.Text, out int number) && !string.IsNullOrWhiteSpace(txtFirstName.Text)
                    && !string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    User user = null;

                    // Create the appropriate user based on the selected radio button
                    if (rbUser.IsChecked == true)
                    {
                        user = new User(number, txtFirstName.Text, txtLastName.Text);
                    }
                    else if (rbStudent.IsChecked == true)
                    {
                        user = new Student(number, txtFirstName.Text, txtLastName.Text, cbHasScholarship.IsChecked.Value);
                    }
                    else if (double.TryParse(txtSalary.Text, out double salary))
                    {
                        user = new Teacher(number, txtFirstName.Text, txtLastName.Text, salary);
                    }
                    else
                    {
                        MessageBox.Show("Salary must be a numeric value.", "Error");
                        return;
                    }

                    // Check if the user already exists in the list
                    if (!listOfUsers.Contains(user))
                    {
                        // Add the user to the list and refresh the ComboBox
                        listOfUsers.Add(user);
                        lblResult.Content = user.ToString();
                        cmbUsers.Items.Refresh();
                    }
                    else
                    {
                        MessageBox.Show($"This record already exists: {user}", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("First and last name must be filled in, and number must be a numeric value.", "Error");
                }
            }
            catch (CustomException ex)
            {
                // Log the error and show a message to the user
                fileOperations.LogError(ex);
                MessageBox.Show($"This record cannot be created: {ex.Message}", "Error");
            }
        }

        // Event handler for ComboBox selection change
        private void cmbUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Display the selected user's details in the label
            if (cmbUsers.SelectedItem is User user)
            {
                lblResult.Content = user.ToString();
            }
        }

        // Method to control visibility of UI elements
        private void ControlsVisibility(Visibility controlCheckBoxHasScholarship,
                                        Visibility controlLabelSalary,
                                        Visibility controlTextBoxSalary)
        {
            cbHasScholarship.Visibility = controlCheckBoxHasScholarship;
            lblSalary.Visibility = controlLabelSalary;
            txtSalary.Visibility = controlTextBoxSalary;
        }
    }
}