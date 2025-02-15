using RepetitionExercisePokemon_DAL;
using RepetitionExercisePokemon_Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace RepetitionExercisePokemon_WPF
{
    /// <summary>
    /// Interaction logic for Exercise_3_OO_and_OO_List.xaml
    /// </summary>
    public partial class Exercise_3_OO_and_OO_List : Window
    {
        // Lists to store Pokémon objects for Player 1 and Player 2
        private List<Pokemon> pokemoncardsPlayer1 = null;
        private List<Pokemon> pokemoncardsPlayer2 = null;

        public Exercise_3_OO_and_OO_List()
        {
            InitializeComponent();
        }

        // Event handler for when the window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialize FileReader to read Pokémon data from files
            FileReader fileReader = new FileReader();
            pokemoncardsPlayer1 = fileReader.ReadFileExercise3("doc\\Exercise 3\\pokemoncards1.txt");
            pokemoncardsPlayer2 = fileReader.ReadFileExercise3("doc\\Exercise 3\\pokemoncards2.txt");

            // Bind ComboBoxes to the lists of Pokémon objects
            cmbPokemonPlayer1.ItemsSource = pokemoncardsPlayer1;
            cmbPokemonPlayer1.DisplayMemberPath = "Name"; // Display Pokémon names in the ComboBox
            cmbPokemonPlayer2.ItemsSource = pokemoncardsPlayer2;
            cmbPokemonPlayer2.DisplayMemberPath = "Name"; // Display Pokémon names in the ComboBox
        }

        // Event handler for Player 1's ComboBox selection change
        private void cmbPokemonPlayer1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Disable ComboBox after selection
            cmbPokemonPlayer1.IsEnabled = false;

            // Get the selected Pokémon object
            if (cmbPokemonPlayer1.SelectedItem is Pokemon pokemonPlayer1)
            {
                // Set Pokémon image and display info
                imgPokemonPlayer1.Source = new BitmapImage(new Uri(@"img\Exercise 3\" + pokemonPlayer1.Image, UriKind.Relative));
                lblPokemonPlayer1.Content = pokemonPlayer1.ShowInfo();
            }
        }

        // Event handler for Player 2's ComboBox selection change
        private void cmbPokemonPlayer2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Disable ComboBox after selection
            cmbPokemonPlayer2.IsEnabled = false;

            // Get the selected Pokémon object
            if (cmbPokemonPlayer2.SelectedItem is Pokemon pokemonPlayer2)
            {
                // Set Pokémon image and display info
                imgPokemonPlayer2.Source = new BitmapImage(new Uri(@"img\Exercise 3\" + pokemonPlayer2.Image, UriKind.Relative));
                lblPokemonPlayer2.Content = pokemonPlayer2.ShowInfo();
            }
        }

        // Event handler for Player 1's attack button
        private void btnAttackPlayer1_Click(object sender, RoutedEventArgs e)
        {
            if (cmbPokemonPlayer1.SelectedItem is Pokemon pokemonPlayer1 && cmbPokemonPlayer2.SelectedItem is Pokemon pokemonPlayer2)
            {
                // Player 1 attacks Player 2
                pokemonPlayer2.Defend(pokemonPlayer1.Type, pokemonPlayer1.Attack());
                lblPokemonPlayer2.Content = pokemonPlayer2.ShowInfo();

                // Check if Player 2 is dead
                if (!pokemonPlayer2.IsAlive)
                {
                    pokemoncardsPlayer2.Remove(pokemonPlayer2);
                    cmbPokemonPlayer2.Items.Refresh();
                    cmbPokemonPlayer2.IsEnabled = true;

                    CheckGameOver();
                }
            }
        }

        // Event handler for Player 2's attack button
        private void btnAttackPlayer2_Click(object sender, RoutedEventArgs e)
        {
            if (cmbPokemonPlayer1.SelectedItem is Pokemon pokemonPlayer1 && cmbPokemonPlayer2.SelectedItem is Pokemon pokemonPlayer2)
            {
                // Player 2 attacks Player 1
                pokemonPlayer1.Defend(pokemonPlayer2.Type, pokemonPlayer2.Attack());
                lblPokemonPlayer1.Content = pokemonPlayer1.ShowInfo();

                // Check if Player 1 is dead
                if (!pokemonPlayer1.IsAlive)
                {
                    pokemoncardsPlayer1.Remove(pokemonPlayer1);
                    cmbPokemonPlayer1.Items.Refresh();
                    cmbPokemonPlayer1.IsEnabled = true;

                    CheckGameOver();
                }
            }
        }

        // Method to check if the game is over
        private void CheckGameOver()
        {
            if (pokemoncardsPlayer1.Count <= 0)
            {
                MessageBox.Show("Game over! Player 2 has won!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (pokemoncardsPlayer2.Count <= 0)
            {
                MessageBox.Show("Game over! Player 1 has won!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}