using System.Windows;

namespace WPF_Start_exercises
{
    /// <summary>
    /// Interaction logic for Exercise_5_Multiplication_Tables.xaml
    /// </summary>
    public partial class Exercise_5_Multiplication_Tables : Window
    {
        public Exercise_5_Multiplication_Tables()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the "Calculate" button
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int multiplicationTable, number;
            string result = ""; // Variable to store the multiplication table

            // Check if the input is a valid integer
            if (int.TryParse(txtNumber.Text, out number))
            {
                // Generate the multiplication table from 0 to 10
                for (int i = 0; i <= 10; i++)
                {
                    multiplicationTable = number * i;

                    // Append the result of each multiplication to the result string
                    result += $"{i} x {number} = {multiplicationTable}\n";
                }
            }
            else
            {
                // Display an error message if the input is invalid
                result = "Please enter a valid numeric value for the multiplication table!";
            }

            // Display the result in the label
            lblResult.Content = result;
        }
    }
}
