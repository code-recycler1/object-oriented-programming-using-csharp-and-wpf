using System;
using System.Windows;

namespace WPF_Start_exercises
{
    /// <summary>
    /// Interaction logic for Exercise_4_Employee.xaml
    /// </summary>
    public partial class Exercise_4_Employee : Window
    {
        public Exercise_4_Employee()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the "Add" button
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double earnings;
            string error = ""; // Variable to store error messages

            // Validate the input fields
            if (!double.TryParse(txtEarnings.Text, out earnings) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtFirstName.Text))
            {
                // Check if Last Name is empty
                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    error += "Last name is required!" + Environment.NewLine;
                }

                // Check if First Name is empty
                if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    error += "First name is required!" + Environment.NewLine;
                }

                // Check if Earnings is a valid number
                if (!double.TryParse(txtEarnings.Text, out earnings))
                {
                    error += "Earnings must be a numeric value!";
                }

                // Display error messages in a MessageBox
                MessageBox.Show(error, "Errors", MessageBoxButton.OK);
            }
            else
            {
                // Add the employee's details to the summary label
                lblSummary.Content += $"{txtLastName.Text.PadRight(30)}{txtFirstName.Text.PadLeft(15)}{earnings,25:0.00} €{Environment.NewLine}";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            // Clear the summary and input fields
            lblSummary.Content = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtEarnings.Text = "";
        }
    }
}
