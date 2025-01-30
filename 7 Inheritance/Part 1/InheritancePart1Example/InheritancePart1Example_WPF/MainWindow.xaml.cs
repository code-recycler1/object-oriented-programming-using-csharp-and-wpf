using InheritancePart1Example_Models;
using System.Collections.Generic;
using System.Windows;

namespace InheritancePart1Example_WPF
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
        }

        // Event handler for "User" radio button
        private void rbUser_Checked(object sender, RoutedEventArgs e)
        {
            // Hide hasScholarship checkbox and salary fields
            ControlsVisibility(
                controlCheckBoxHasScholarship: Visibility.Hidden,
                controlLabelSalary: Visibility.Hidden,
                controlTextBoxSalary: Visibility.Hidden
            );
        }

        // Event handler for "Teacher" radio button
        private void rbTeacher_Checked(object sender, RoutedEventArgs e)
        {
            // Show salary fields and hide hasScholarship checkbox
            ControlsVisibility(
                controlCheckBoxHasScholarship: Visibility.Hidden,
                controlLabelSalary: Visibility.Visible,
                controlTextBoxSalary: Visibility.Visible
            );
        }

        // Event handler for "Student" radio button
        private void rbStudent_Checked(object sender, RoutedEventArgs e)
        {
            // Show hasScholarship checkbox and hide salary fields
            ControlsVisibility(
                controlCheckBoxHasScholarship: Visibility.Visible,
                controlLabelSalary: Visibility.Hidden,
                controlTextBoxSalary: Visibility.Hidden
            );
        }

        // Event handler for "Add" button
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs
            if (IsInputValid())
            {
                // Parse number and create the appropriate user type
                int number = int.Parse(txtNumber.Text);

                if (rbUser.IsChecked == true)
                {
                    // Create a User object
                    User user = new User(number, txtFirstName.Text, txtLastName.Text);
                    listOfUsers.Add(user);
                    lblResult.Content = user.ShowData("-");
                }
                else if (rbTeacher.IsChecked == true)
                {
                    // Create a Teacher object
                    double salary = double.Parse(txtSalary.Text);
                    Teacher teacher = new Teacher(number, txtFirstName.Text, txtLastName.Text, salary);
                    listOfUsers.Add(teacher);
                    lblResult.Content = teacher.ShowData("-");
                }
                else if (rbStudent.IsChecked == true)
                {
                    // Create a Student object
                    bool hasScholarship = cbHasScholarship.IsChecked.Value;
                    Student student = new Student(number, txtFirstName.Text, txtLastName.Text, hasScholarship);
                    listOfUsers.Add(student);
                    lblResult.Content = student.ShowData("-");
                }

                // Clear input fields
                ClearInputFields();
            }
            else
            {
                // Show error message if validation fails
                MessageBox.Show("Please ensure all fields are filled correctly:\n" +
                                "- Number must be a positive integer\n" +
                                "- First and last name cannot be empty\n" +
                                "- Salary must be a positive number (for Teacher)", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for "Show All" button
        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            // Clear the result display
            lblResult.Content = "";

            // Loop through all users and display their data
            foreach (User user in listOfUsers)
            {
                lblResult.Content += user.ShowData("-");
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

        // Method to validate user inputs
        private bool IsInputValid()
        {
            return int.TryParse(txtNumber.Text, out int number) && number > 0 &&
                   !string.IsNullOrEmpty(txtFirstName.Text) &&
                   !string.IsNullOrEmpty(txtLastName.Text) ||
                   (rbTeacher.IsChecked == true && double.TryParse(txtSalary.Text, out double salary) && salary > 0);
        }

        // Method to clear input fields
        private void ClearInputFields()
        {
            txtNumber.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSalary.Text = "";
            cbHasScholarship.IsChecked = false;
        }
    }
}