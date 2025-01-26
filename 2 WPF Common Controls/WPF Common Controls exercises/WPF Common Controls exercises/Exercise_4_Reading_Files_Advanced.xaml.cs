using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace WPF_Common_Controls_exercises
{
    /// <summary>
    /// Interaction logic for Exercise_4_Reading_Files_Advanced.xaml
    /// </summary>
    public partial class Exercise_4_Reading_Files_Advanced : Window
    {
        public Exercise_4_Reading_Files_Advanced()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the Print button
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            // Filename
            string filename = "Records (exercise 4).txt";

            // Clear the labels before displaying new results
            lblInvalidRecords.Content = "";
            lblValidRecords.Content = "";

            try
            {
                // Use a StreamReader to read the file
                using (StreamReader reader = new StreamReader($"doc\\{filename}"))
                {
                    int totalAge = 0; // Variable to store the sum of ages
                    int validRecordCount = 0, invalidRecordCount = 0; // Counters for valid and invalid records

                    // Read the file line by line
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        // Validate the record using the dataValidation method
                        int age = dataValidation(line, out string errorMessage, out string result);

                        if (age != -1) // If the record is valid
                        {
                            // If the "Valid Records" checkbox is checked, display the result
                            if (cbValidRecords.IsChecked == true)
                            {
                                lblValidRecords.Content += result;
                            }

                            totalAge += age; // Add the age to the total
                            validRecordCount++; // Increment the valid record counter
                        }
                        else // If the record is invalid
                        {
                            // If the "Invalid Records" checkbox is checked, display the error message
                            if (cbInvalidRecords.IsChecked == true)
                            {
                                lblInvalidRecords.Content += errorMessage;
                            }

                            invalidRecordCount++; // Increment the invalid record counter
                        }
                    }

                    // Display the average age if there are valid records
                    if (validRecordCount != 0)
                    {
                        double averageAge = (double)totalAge / validRecordCount;
                        lblValidRecords.Content += $"The average age is: {averageAge:0.00}";
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Validates a line of data containing multiple fields separated by semicolons (';').
        /// </summary>
        /// <param name="line">The input line to validate. Fields are expected to be separated by semicolons.</param>
        /// <param name="errorMessage">Output parameter containing error messages if validation fails.</param>
        /// <param name="result">Output parameter containing the formatted result if validation succeeds.</param>
        /// <returns>
        /// Returns the age as an integer if the line is valid.
        /// Returns -1 if the line is invalid, and <paramref name="errorMessage"/> will contain the validation errors.
        /// </returns>
        private int dataValidation(string line, out string errorMessage, out string result)
        {
            string[] records = line.Split(';'); // Split the line into individual fields
            errorMessage = ""; // Initialize the error message
            result = ""; // Initialize the result

            // Validate the number (must be numeric)
            if (!int.TryParse(records[0], out int number))
            {
                errorMessage += "- Number must be numeric." + Environment.NewLine;
            }

            // Validate the name (must not be numeric)
            if (int.TryParse(records[1], out _))
            {
                errorMessage += "- Name must not be numeric." + Environment.NewLine;
            }

            // Validate the gender (must be 'M' or 'F')
            if (records[2] != "M" && records[2] != "F")
            {
                errorMessage += "- Gender must be 'M' or 'F'." + Environment.NewLine;
            }

            // Validate the email (must contain '@' and '.')
            if (!records[3].Contains('@') || !records[3].Contains('.'))
            {
                errorMessage += "- Email must contain '@' and '.'." + Environment.NewLine;
            }

            // Validate the age (must be numeric and greater than 0)
            if (!int.TryParse(records[4], out int age) || age <= 0)
            {
                errorMessage += "- Age must be numeric and greater than 0." + Environment.NewLine;
            }

            // If there are errors, the record is invalid
            if (errorMessage != "")
            {
                errorMessage = line + Environment.NewLine + errorMessage;
                return -1;
            }
            else
            {
                // If no errors, format the result and return the age
                result = records[0].PadLeft(3) + " " + records[1].PadRight(10) + records[2].PadRight(3)
                    + records[3].PadRight(20) + records[4].PadLeft(5) + Environment.NewLine;
                return age;
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
