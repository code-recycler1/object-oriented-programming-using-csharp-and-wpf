using ExceptionHandlingExercises_DAL;
using ExceptionHandlingExercises_Models.Exercise_2;
using System;
using System.Windows;

namespace ExceptionHandlingExercises_WPF
{
    /// <summary>
    /// Interaction logic for Exercise_2_Customer.xaml
    /// </summary>
    public partial class Exercise_2_Customer : Window
    {
        public Exercise_2_Customer()
        {
            InitializeComponent();
        }

        // Event handler for the "Search" button
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validate if the input is a valid integer
                if (int.TryParse(txtCustomerNumber.Text, out int number))
                {
                    // Create an instance of FileOperations to interact with the file
                    FileOperations fileOperations = new FileOperations();

                    // Find the customer by number and display the result
                    Customer customer = fileOperations.FindCustomerByNumber(number);
                    lblResult.Content = customer.ToString();
                }
                else
                {
                    // Display error message if the input is not a valid number
                    lblResult.Content = "Please enter a valid numeric customer number!";
                }
            }
            catch (CustomerNotFoundException ex)
            {
                // Handle customer not found exception
                lblResult.Content = ex.Message;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                lblResult.Content = $"An error occurred: {ex.Message}";
            }
        }

        // Event handler for the "Close" button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}