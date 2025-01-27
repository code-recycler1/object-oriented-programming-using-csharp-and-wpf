using System.Windows;
using OO_Exercises_Models;

namespace OO_Exercises_WPF
{
    public partial class Exercise_4_Train : Window
    {
        // Declare a Train object to hold the train data
        Train train;

        public Exercise_4_Train()
        {
            InitializeComponent(); // Initialize the UI components defined in XAML
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            train = new Train(); // Initialize the train object
        }

        // Event handler for the Embark button
        private void btnEmbark_Click(object sender, RoutedEventArgs e)
        {
            txtSummary.Text = ""; // Clear the summary text
            if (int.TryParse(txtEmbark.Text, out int number)) // Validate the input
            {
                if (!train.Embark(number)) // Attempt to embark passengers
                {
                    txtSummary.Text = "The doors are closed, nobody could embark!\n"; // Display error if doors are closed
                }
                txtSummary.Text += train.Status(); // Update the summary with the train's status
            }
            else
            {
                MessageBox.Show("Input is not a number."); // Show error for invalid input
            }
        }

        // Event handler for the Disembark button
        private void btnDisembark_Click(object sender, RoutedEventArgs e)
        {
            txtSummary.Text = ""; // Clear the summary text
            if (int.TryParse(txtDisembark.Text, out int number)) // Validate the input
            {
                if (!train.Disembark(number)) // Attempt to disembark passengers
                {
                    txtSummary.Text = "The doors are closed, nobody could disembark!\n"; // Display error if doors are closed
                }
                txtSummary.Text += train.Status(); // Update the summary with the train's status
            }
            else
            {
                MessageBox.Show("Input is not a number."); // Show error for invalid input
            }
        }

        // Event handler for the Accelerate button
        private void btnAccelerate_Click(object sender, RoutedEventArgs e)
        {
            txtSummary.Text = ""; // Clear the summary text
            if (int.TryParse(txtAccelerate.Text, out int acceleration)) // Validate the input
            {
                if (!train.Accelerate(acceleration)) // Attempt to accelerate the train
                {
                    txtSummary.Text = "The doors are open, the train may not accelerate!\n"; // Display error if doors are open
                }
                txtSummary.Text += train.Status(); // Update the summary with the train's status
            }
            else
            {
                MessageBox.Show("Input is not a number."); // Show error for invalid input
            }
        }

        // Event handler for the Decelerate button
        private void btnDecelerate_Click(object sender, RoutedEventArgs e)
        {
            txtSummary.Text = ""; // Clear the summary text
            if (int.TryParse(txtDecelerate.Text, out int deceleration)) // Validate the input
            {
                train.Decelerate(deceleration); // Decelerate the train
                txtSummary.Text += train.Status(); // Update the summary with the train's status
            }
            else
            {
                MessageBox.Show("Input is not a number."); // Show error for invalid input
            }
        }

        // Event handler for the Stop button
        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            train.Stop(); // Stop the train
            txtSummary.Text = train.Status(); // Update the summary with the train's status
        }

        // Event handler for the Close Doors button
        private void btnCloseDoors_Click(object sender, RoutedEventArgs e)
        {
            train.CloseDoors(); // Close the train doors
            txtSummary.Text = train.Status(); // Update the summary with the train's status
        }
    }
}