using System.Windows;
using OO_Exercises_Models;

namespace OO_Exercises_WPF
{
    public partial class Exercise_2_BMI : Window
    {
        public Exercise_2_BMI()
        {
            InitializeComponent(); // Initialize the UI components defined in XAML
        }

        // Event handler for the Calculate button
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            BMI bmi;

            // Validate the name field
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                // Validate the weight and length fields
                if (double.TryParse(txtWeight.Text, out double weight) && double.TryParse(txtLength.Text, out double length))
                {
                    // Create a BMI object with the provided data
                    bmi = new BMI(txtName.Text, weight, length);

                    // Display the user's data in the result label
                    lblResult.Content = bmi.ShowData();

                    // Display the calculated BMI in the BMI label (formatted to 1 decimal place)
                    lblBMI.Content = $"Your BMI is {bmi.CalculateBMI():0.0}";
                }
                else
                {
                    // Show an error message if weight or length is not numeric
                    MessageBox.Show("Weight or length is not numeric", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                // Show an error message if the name field is empty
                MessageBox.Show("No name given", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}