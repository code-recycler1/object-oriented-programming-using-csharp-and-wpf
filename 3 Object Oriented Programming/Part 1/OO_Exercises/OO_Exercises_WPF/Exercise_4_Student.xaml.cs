using OO_Exercises_Models;
using System.Windows;

namespace OO_Exercises_WPF
{
    /// <summary>
    /// Interaction logic for Exercise_4_Student.xaml
    /// </summary>
    public partial class Exercise_4_Student : Window
    {
        public Exercise_4_Student()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the Show button
        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            // Validate and parse the input values
            if (int.TryParse(txtMathematics.Text, out int mathGrade) &&
                int.TryParse(txtComputerScience.Text, out int computerScienceGrade))
            {
                // Create a new Student object
                Student student = new Student();

                // Set the properties of the Student object
                student.Name = txtName.Text;
                student.Mathematics = mathGrade;
                student.ComputerScience = computerScienceGrade;

                // Display the result using the ShowData method
                lblResult.Content = student.ShowData();
            }
            else
            {
                // Show an error message if the input is invalid
                MessageBox.Show("Please enter valid numeric values for grades.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}