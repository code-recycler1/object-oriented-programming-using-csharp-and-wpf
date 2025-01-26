using System.Windows;
using OO_Exercises_Models;

namespace OO_Exercises_WPF
{
    /// <summary>
    /// Interaction logic for Exercise_2_Television.xaml
    /// </summary>
    public partial class Exercise_2_Television : Window
    {
        public Exercise_2_Television()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Create an instance of the Television class
        Television tv = new Television();

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Display the initial TV status
            lblResult.Content = tv.ShowData();
        }

        // Event handler for the "Increase" button
        private void btnIncrease_Click(object sender, RoutedEventArgs e)
        {
            // Increase the channel and volume
            tv.ChangeChannelUp();
            tv.IncreaseVolume();

            // Update the TV status display
            lblResult.Content = tv.ShowData();
        }

        // Event handler for the "Decrease" button
        private void btnDecrease_Click(object sender, RoutedEventArgs e)
        {
            // Decrease the channel and volume
            tv.ChangeChannelDown();
            tv.DecreaseVolume();

            // Update the TV status display
            lblResult.Content = tv.ShowData();
        }
    }
}