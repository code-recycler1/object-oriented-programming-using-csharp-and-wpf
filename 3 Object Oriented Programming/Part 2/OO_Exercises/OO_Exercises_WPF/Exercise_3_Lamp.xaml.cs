using OO_Exercises_Models;
using System.Windows;

namespace OO_Exercises_WPF
{
    public partial class Exercise_3_Lamp : Window
    {
        // Declare a Lamp object to hold the lamp data
        Lamp lamp = new Lamp(125, 125, 125);

        public Exercise_3_Lamp()
        {
            InitializeComponent(); // Initialize the UI components defined in XAML
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshLamp(); // Update the lamp display
        }

        // Event handler for the Random Color button
        private void btnRandomColor_Click(object sender, RoutedEventArgs e)
        {
            lamp.RandomColor(); // Set random RGB values
            RefreshLamp(); // Update the lamp display
        }

        // Event handlers for adjusting Red, Green, and Blue values
        private void btnMoreRed_Click(object sender, RoutedEventArgs e)
        {
            lamp.MoreRed(); // Increase Red value by 10
            RefreshLamp(); // Update the lamp display
        }

        private void btnLessRed_Click(object sender, RoutedEventArgs e)
        {
            lamp.LessRed(); // Decrease Red value by 10
            RefreshLamp(); // Update the lamp display
        }

        private void btnMoreGreen_Click(object sender, RoutedEventArgs e)
        {
            lamp.MoreGreen(); // Increase Green value by 10
            RefreshLamp(); // Update the lamp display
        }

        private void btnLessGreen_Click(object sender, RoutedEventArgs e)
        {
            lamp.LessGreen(); // Decrease Green value by 10
            RefreshLamp(); // Update the lamp display
        }

        private void btnMoreBlue_Click(object sender, RoutedEventArgs e)
        {
            lamp.MoreBlue(); // Increase Blue value by 10
            RefreshLamp(); // Update the lamp display
        }

        private void btnLessBlue_Click(object sender, RoutedEventArgs e)
        {
            lamp.LessBlue(); // Decrease Blue value by 10
            RefreshLamp(); // Update the lamp display
        }

        // Method to refresh the lamp display
        private void RefreshLamp()
        {
            lblLamp.Background = lamp.GetLampColor(); // Update the lamp color
            lblLampValues.Content = lamp.ShowRgbValues(); // Update the RGB values label
        }
    }
}