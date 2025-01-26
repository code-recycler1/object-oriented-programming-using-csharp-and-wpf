using System.Windows;
using OO_Exercises_Models;

namespace OO_Exercises_WPF
{
    /// <summary>
    /// Interaction logic for Exercise_1_Counter.xaml
    /// </summary>
    public partial class Exercise_1_Counter : Window
    {
        public Exercise_1_Counter()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Create an instance of the Counter class
        Counter counter = new Counter();

        // Event handler for the "Show count value" button
        private void btnShowCountValue_Click(object sender, RoutedEventArgs e)
        {
            // Display the current counter value in a MessageBox
            MessageBox.Show(counter.ShowData(), "Count value", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Event handler for the "Increment count by 1" button
        private void btnIncrementCount_Click(object sender, RoutedEventArgs e)
        {
            counter.Increment(); // Increment the counter by 1
        }

        // Event handler for the "Decrement count by 1" button
        private void btnDecrementCount_Click(object sender, RoutedEventArgs e)
        {
            counter.Decrement(); // Decrement the counter by 1
        }

        // Event handler for the "Reset count to 0" button
        private void btnResetCounter_Click(object sender, RoutedEventArgs e)
        {
            counter.Reset(); // Reset the counter to 0
        }

        // Event handler for the "Close" button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Close the window
        }
    }
}