using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace WPF_Common_Controls_exercises
{
    /// <summary>
    /// Interaction logic for Exercise_3_Reading_Files_Basic.xaml
    /// </summary>
    public partial class Exercise_3_Reading_Files_Basic : Window
    {
        public Exercise_3_Reading_Files_Basic()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the Print button
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            // Filename
            string filename = "Records (exercise 2).txt";

            // Clear the labels before displaying new results
            lblInvalidRecords.Content = "";
            lblValidRecords.Content = "";

            try
            {
                // Use a StreamReader to read the file
                using (StreamReader reader = new StreamReader($"doc\\{filename}"))
                {
                    int validRecordCount = 0, invalidRecordCount = 0; // Counters for valid and invalid records

                    // Read the file line by line
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        // Validate the record using the dataValidation method
                        bool isValid = dataValidation(line, out string errorMessage, out string result);

                        if (isValid)
                        {
                            // If the record is valid and the "Valid Records" checkbox is checked, display it
                            if (cbValidRecords.IsChecked == true)
                            {
                                lblValidRecords.Content += result;
                            }

                            validRecordCount++; // Increment the valid record counter
                        }
                        else
                        {
                            // If the record is invalid and the "Invalid Records" checkbox is checked, display it
                            if (cbInvalidRecords.IsChecked == true)
                            {
                                lblInvalidRecords.Content += errorMessage;
                            }

                            invalidRecordCount++; // Increment the invalid record counter
                        }
                    }

                    // Display the total number of valid records
                    if (validRecordCount != 0)
                    {
                        lblValidRecords.Content += $"Number of valid records: {validRecordCount}\n";
                    }

                    // Display the total number of invalid records
                    if (invalidRecordCount != 0)
                    {
                        lblInvalidRecords.Content += $"Number of invalid records: {invalidRecordCount}\n";
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Method to validate a record (email address)
        private bool dataValidation(string line, out string errorMessage, out string result)
        {
            errorMessage = ""; // Initialize the error message
            result = ""; // Initialize the result

            // Check if the email contains an '@' and a '.'
            if (!line.Contains('@'))
            {
                errorMessage += "- Email must contain @." + Environment.NewLine;
            }
            if (!line.Contains('.'))
            {
                errorMessage += "- Email must contain ." + Environment.NewLine;
            }

            // If there are errors, the record is invalid
            if (errorMessage != "")
            {
                errorMessage = line + Environment.NewLine + errorMessage;
                return false;
            }
            else
            {
                // If no errors, the record is valid
                result = line + Environment.NewLine;
                return true;
            }
        }

        // Event handler for the Reset button
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            lblValidRecords.Content = ""; // Clear the valid records label
            lblInvalidRecords.Content = ""; // Clear the invalid records label
            cbValidRecords.IsChecked = false; // Uncheck the "Valid Records" checkbox
            cbInvalidRecords.IsChecked = false; // Uncheck the "Invalid Records" checkbox
        }
    }
}