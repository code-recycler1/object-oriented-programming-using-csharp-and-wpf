using System.Windows;
using UnitTestingExercises_Models;

namespace UnitTestingExercises_WPF
{
    /// <summary>
    /// Interaction logic for Exercise_1_Swimming_Pool.xaml
    /// </summary>
    public partial class Exercise_1_Swimming_Pool : Window
    {
        public Exercise_1_Swimming_Pool()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the Calculate button
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Create a new SwimmingPool object
            SwimmingPool pool = new SwimmingPool();

            // Validate and parse the input values
            if (double.TryParse(txtDepth.Text, out double depth) &&
                double.TryParse(txtLength.Text, out double length) &&
                double.TryParse(txtWidth.Text, out double width) &&
                double.TryParse(txtEdgeDistance.Text, out double edgeDistance))
            {
                // Set the properties of the SwimmingPool object
                pool.Depth = depth;
                pool.Length = length;
                pool.Width = width;
                pool.EdgeDistance = edgeDistance;

                // Display the result using the ShowData method
                txtResult.Text = pool.ShowData();
            }
            else
            {
                // Show an error message if the input is invalid
                MessageBox.Show("Please enter valid numbers for all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
