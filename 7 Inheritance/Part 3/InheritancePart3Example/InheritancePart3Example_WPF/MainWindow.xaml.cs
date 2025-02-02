using InheritancePart3Example_Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace InheritancePart3Example_WPF
{
    public partial class MainWindow : Window
    {
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

            // Bind the list of users to the ComboBox
            cmbUsers.ItemsSource = listOfUsers;
            cmbUsers.DisplayMemberPath = "FullName";
        }

        // Event handler for "User" radio button
        private void rbUser_Checked(object sender, RoutedEventArgs e)
        {
            // Hide scholarship checkbox and salary fields
            ControlsVisibility(
                controlCheckBoxScholarship: Visibility.Hidden,
                controlLabelSalary: Visibility.Hidden,
                controlTextBoxSalary: Visibility.Hidden
            );
        }

        // Event handler for "Teacher" radio button
        private void rbTeacher_Checked(object sender, RoutedEventArgs e)
        {
            // Show salary fields and hide scholarship checkbox
            ControlsVisibility(
                controlCheckBoxScholarship: Visibility.Hidden,
                controlLabelSalary: Visibility.Visible,
                controlTextBoxSalary: Visibility.Visible
            );
        }

        // Event handler for "Student" radio button
        private void rbStudent_Checked(object sender, RoutedEventArgs e)
        {
            // Show scholarship checkbox and hide salary fields
            ControlsVisibility(
                controlCheckBoxScholarship: Visibility.Visible,
                controlLabelSalary: Visibility.Hidden,
                controlTextBoxSalary: Visibility.Hidden
            );
        }

        // Event handler for "Add" button
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs
            if (int.TryParse(txtNumber.Text, out int nr) &&
                !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                !string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                User user = null;

                // Create the appropriate user based on the selected radio button
                if (rbUser.IsChecked == true)
                {
                    user = new User(nr, txtFirstName.Text, txtLastName.Text);
                }
                else if (rbStudent.IsChecked == true)
                {
                    user = new Student(nr, txtFirstName.Text, txtLastName.Text, cbScholarship.IsChecked.Value);
                }
                else if (double.TryParse(txtSalary.Text, out double salary) && salary > 0)
                {
                    user = new Teacher(nr, txtFirstName.Text, txtLastName.Text, salary);
                }
                else
                {
                    MessageBox.Show("Salary must be a positive number.", "Error");
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
                    MessageBox.Show("User already exists.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields correctly.", "Error");
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
        private void ControlsVisibility(
            Visibility controlCheckBoxScholarship,
            Visibility controlLabelSalary,
            Visibility controlTextBoxSalary)
        {
            cbScholarship.Visibility = controlCheckBoxScholarship;
            lblSalary.Visibility = controlLabelSalary;
            txtSalary.Visibility = controlTextBoxSalary;
        }
    }
}