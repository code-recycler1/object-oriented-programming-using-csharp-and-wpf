using System.Windows;
using UnitTestingExercises_Models;

namespace UnitTestingExercises_WPF
{
    /// <summary>
    /// Interaction logic for Exercise_3_Tamagotchi.xaml
    /// </summary>
    public partial class Exercise_3_Tamagotchi : Window
    {
        // Declare a Tamagotchi object to hold the Tamagotchi data
        Tamagotchi Tamagotchi = null;

        public Exercise_3_Tamagotchi()
        {
            InitializeComponent(); // Initialize the UI components defined in XAML
        }

        // Event handler for the Create button
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)) // Validate the name field
            {
                MessageBox.Show("Enter a name please."); // Show error if name is empty
                txtName.Focus(); // Set focus to the name textbox
            }
            else
            {
                // Create a new Tamagotchi with the provided name
                Tamagotchi = new Tamagotchi(txtName.Text);
                MessageBox.Show("Tamagotchi " + Tamagotchi.Name + " is born!"); // Show confirmation message
                lblTamagotchiName.Content = Tamagotchi.Name; // Display the Tamagotchi's name
            }
        }

        // Event handler for the Pet button
        private void btnPet_Click(object sender, RoutedEventArgs e)
        {
            Tamagotchi?.Pet(); // Pet the Tamagotchi if it exists
        }

        // Event handler for the Feed button
        private void btnFeed_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtFoodUnits.Text, out int units)) // Validate the input
            {
                Tamagotchi?.Feed(units); // Feed the Tamagotchi if it exists
                txtFoodUnits.Text = ""; // Clear the food units textbox
            }
            else
            {
                MessageBox.Show("Food units is not numeric"); // Show error for invalid input
            }
        }

        // Event handler for the Punish button
        private void btnPunish_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtPunishUnits.Text, out int units)) // Validate the input
            {
                Tamagotchi?.Punish(units); // Punish the Tamagotchi if it exists
                txtPunishUnits.Text = ""; // Clear the punish units textbox
            }
            else
            {
                MessageBox.Show("Punish units is not numeric"); // Show error for invalid input
            }
        }

        // Event handler for the Feeling button
        private void btnFeeling_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = Tamagotchi?.Feeling(); // Display the Tamagotchi's feeling if it exists
        }
    }
}
