using RepetitionExercisePokemon_Models;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace RepetitionExercisePokemon_WPF
{
    /// <summary>
    /// Interaction logic for Exercise_1_OO.xaml
    /// </summary>
    public partial class Exercise_1_OO : Window
    {
        // Pokémon instances for Player 1 and Player 2
        private Pokemon pokemonPlayer1 = null;
        private Pokemon pokemonPlayer2 = null;

        public Exercise_1_OO()
        {
            InitializeComponent();
        }

        // Event handler for when the window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialize Pokémon for Player 1 and Player 2
            pokemonPlayer1 = new Pokemon("Raichu", 90, "Electric", "Thunder Struck", 30, "Electro Ball", 80, "Fighting", 2, "Metal", 20, "raichu.png");
            pokemonPlayer2 = new Pokemon("Eevee", 50, "Colorless", "Smash Kick", 10, "Tail Whap", 20, "Fighting", 2, "None", 0, "eevee.png");

            // Set Pokémon images and display their info
            SetImage();
            UpdatePokemonInfo();
        }

        // Event handler for Player 1's attack button
        private void btnAttackPlayer1_Click(object sender, RoutedEventArgs e)
        {
            // Player 1 attacks Player 2
            pokemonPlayer2.Defend(pokemonPlayer1.Type, pokemonPlayer1.Attack());
            UpdatePokemonInfo();

            // Check if Player 2 is dead
            if (!pokemonPlayer2.IsAlive)
            {
                MessageBox.Show($"{pokemonPlayer1.Name} has won!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
                DisableAttackButtons();
            }
        }

        // Event handler for Player 2's attack button
        private void btnAttackPlayer2_Click(object sender, RoutedEventArgs e)
        {
            // Player 2 attacks Player 1
            pokemonPlayer1.Defend(pokemonPlayer2.Type, pokemonPlayer2.Attack());
            UpdatePokemonInfo();

            // Check if Player 1 is dead
            if (!pokemonPlayer1.IsAlive)
            {
                MessageBox.Show($"{pokemonPlayer2.Name} has won!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
                DisableAttackButtons();
            }
        }

        // Method to set Pokémon images
        private void SetImage()
        {
            imgPokemonPlayer1.Source = new BitmapImage(new Uri(@"img\Exercise 1\" + pokemonPlayer1.Image, UriKind.Relative));
            imgPokemonPlayer2.Source = new BitmapImage(new Uri(@"img\Exercise 1\" + pokemonPlayer2.Image, UriKind.Relative));
        }

        // Method to update Pokémon info labels
        private void UpdatePokemonInfo()
        {
            lblPokemonPlayer1.Content = pokemonPlayer1.ShowInfo();
            lblPokemonPlayer2.Content = pokemonPlayer2.ShowInfo();
        }

        // Method to disable attack buttons when the game ends
        private void DisableAttackButtons()
        {
            btnAttackPlayer1.IsEnabled = false;
            btnAttackPlayer2.IsEnabled = false;
        }
    }
}