using System;
using System.Windows;

namespace WPF_Start_exercises
{
    /// <summary>
    /// Interaction logic for Exercise_1_Dice.xaml
    /// </summary>
    public partial class Exercise_1_Dice : Window
    {
        public Exercise_1_Dice()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the "Roll" button
        private void btnRoll_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random(); // Creates a new Random object to generate random numbers
            int number1, number2;

            // Generate random numbers between 1 and 6 (simulating a dice roll)
            number1 = random.Next(1, 7); // First die
            number2 = random.Next(1, 7); // Second die

            // Display the results in the labels
            lblDie1.Content = number1.ToString(); // Set the content of the first label
            lblDie2.Content = number2.ToString(); // Set the content of the second label
        }
    }
}
