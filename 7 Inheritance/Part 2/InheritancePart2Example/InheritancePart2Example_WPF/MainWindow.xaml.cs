using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using InheritancePart2Example_Models;

namespace InheritancePart2Example_WPF
{
    public partial class MainWindow : Window
    {
        // List to store the users
        private List<User> listOfUsers = new List<User>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Set the default selected user type to User
            rbUser.IsChecked = true;

            // Bind the list of users to the ComboBox
            cmbUsers.ItemsSource = listOfUsers;

            // Set the display path to show the full name of the user
            cmbUsers.DisplayMemberPath = "FullName";
        }

        // Event handler for when the User radio button is checked
        private void rbUser_Checked(object sender, RoutedEventArgs e)
        {
            // Hide scholarship and salary controls
            ControlsVisibility(
                controlCheckBoxScholarship: Visibility.Hidden,
                controlLabelSalary: Visibility.Hidden,
                controlTextBoxSalary: Visibility.Hidden
            );
        }

        // Event handler for when the Teacher radio button is checked
        private void rbTeacher_Checked(object sender, RoutedEventArgs e)
        {
            // Show salary controls and hide scholarship control
            ControlsVisibility(
                controlCheckBoxScholarship: Visibility.Hidden,
                controlLabelSalary: Visibility.Visible,
                controlTextBoxSalary: Visibility.Visible
            );
        }

        // Event handler for when the Student radio button is checked
        private void rbStudent_Checked(object sender, RoutedEventArgs e)
        {
            // Show scholarship control and hide salary controls
            ControlsVisibility(
                controlCheckBoxScholarship: Visibility.Visible,
                controlLabelSalary: Visibility.Hidden,
                controlTextBoxSalary: Visibility.Hidden
            );
        }

        // Event handler for the "Add" button
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Validate input fields
            if (int.TryParse(txtNumber.Text, out int nr) &&
                !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                !string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                User user = null;

                // Create the appropriate user type based on the selected radio button
                if (rbUser.IsChecked == true)
                {
                    user = new User(nr, txtFirstName.Text, txtLastName.Text);
                }
                else if (rbStudent.IsChecked == true)
                {
                    user = new Student(nr, txtFirstName.Text, txtLastName.Text, cbScholarship.IsChecked.Value);
                }
                else if (double.TryParse(txtSalary.Text, out double salary))
                {
                    user = new Teacher(nr, txtFirstName.Text, txtLastName.Text, salary);
                }
                else
                {
                    MessageBox.Show("Salary must be a numerical value.", "Error");
                    return;
                }

                // Add the user to the list and display their data
                listOfUsers.Add(user);
                lblResult.Content = user.ShowData("-");

                // Refresh the ComboBox
                cmbUsers.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Please fill in all fields correctly.", "Error");
            }
        }

        // Event handler for when the selection in the ComboBox changes
        private void cmbUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbUsers.SelectedItem is User user)
            {
                // Display the selected user's data
                lblResult.Content = user.ShowData();
            }
        }

        // Helper method to control the visibility of scholarship and salary controls
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