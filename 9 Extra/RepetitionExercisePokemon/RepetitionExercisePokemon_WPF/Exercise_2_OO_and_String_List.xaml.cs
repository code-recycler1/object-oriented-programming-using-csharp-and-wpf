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
    /// Interaction logic for Exercise_2_OO_and_String_List.xaml
    /// </summary>
    public partial class Exercise_2_OO_and_String_List : Window
    {
        // Lists to store Pokémon names for Player 1 and Player 2
        private List<string> pokemoncardsPlayer1 = null;
        private List<string> pokemoncardsPlayer2 = null;

        // Pokémon instances for Player 1 and Player 2
        private Pokemon pokemonPlayer1 = null;
        private Pokemon pokemonPlayer2 = null;

        public Exercise_2_OO_and_String_List()
        {
            InitializeComponent();
        }

        // Event handler for when the window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialize FileReader to read Pokémon names from files
            FileReader fileReader = new FileReader();
            pokemoncardsPlayer1 = fileReader.ReadFileExercise2("doc\\Exercise 2\\pokemoncards1.txt");
            pokemoncardsPlayer2 = fileReader.ReadFileExercise2("doc\\Exercise 2\\pokemoncards2.txt");

            // Bind ComboBoxes to the lists of Pokémon names
            cmbPokemonPlayer1.ItemsSource = pokemoncardsPlayer1;
            cmbPokemonPlayer2.ItemsSource = pokemoncardsPlayer2;
        }

        // Event handler for Player 1's ComboBox selection change
        private void cmbPokemonPlayer1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Disable ComboBox after selection
            cmbPokemonPlayer1.IsEnabled = false;

            // Get the selected Pokémon name
            if (cmbPokemonPlayer1.SelectedItem is string name)
            {
                // Initialize Pokémon based on the selected name
                pokemonPlayer1 = InitializePokemon(name);

                // Set Pokémon image and display info
                imgPokemonPlayer1.Source = new BitmapImage(new Uri(@"img\Exercise 2\" + pokemonPlayer1.Image, UriKind.Relative));
                lblPokemonPlayer1.Content = pokemonPlayer1.ShowInfo();
            }
        }

        // Event handler for Player 2's ComboBox selection change
        private void cmbPokemonPlayer2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Disable ComboBox after selection
            cmbPokemonPlayer2.IsEnabled = false;

            // Get the selected Pokémon name
            if (cmbPokemonPlayer2.SelectedItem is string name)
            {
                // Initialize Pokémon based on the selected name
                pokemonPlayer2 = InitializePokemon(name);

                // Set Pokémon image and display info
                imgPokemonPlayer2.Source = new BitmapImage(new Uri(@"img\Exercise 2\" + pokemonPlayer2.Image, UriKind.Relative));
                lblPokemonPlayer2.Content = pokemonPlayer2.ShowInfo();
            }
        }

        // Method to initialize a Pokémon based on its name
        private Pokemon InitializePokemon(string name)
        {
            switch (name)
            {
                case "Alolan Raticate":
                    return new Pokemon("Alolan Raticate", 120, "Dark", "Evil Orders", 10, "Endeavor", 60, "Fighting", 2, "Psychic", 20, "alolan_raticate.png");
                case "Altaria":
                    return new Pokemon("Altaria", 90, "Colorless", "Draco Melody", 10, "Cotton Guard", 30, "Electric", 2, "Fighting", 20, "altaria.png");
                case "Charizard":
                    return new Pokemon("Charizard", 250, "Fire", "Flamethrower", 140, "Flare Blitz", 300, "Water", 2, "None", 0, "Charizard.jpg");
                case "Dragonite":
                    return new Pokemon("Dragonite", 180, "Dragon", "Bust In", 10, "Jet Sonic", 80, "Fairy", 2, "None", 0, "Dragonite.png");
                case "Eevee":
                    return new Pokemon("Eevee", 60, "Colorless", "Growl", 10, "Quick Attack", 10, "Fighting", 2, "None", 0, "Eevee.jpg");
                case "Glaceon":
                    return new Pokemon("Glaceon", 200, "Water", "Frost Bullet", 90, "Ploas Spear", 50, "Metal", 2, "None", 0, "glaceon.png");
                default:
                    throw new ArgumentException("Invalid Pokémon name.");
            }
        }

        // Event handler for Player 1's attack button
        private void btnAttackPlayer1_Click(object sender, RoutedEventArgs e)
        {
            if (pokemonPlayer1 != null && pokemonPlayer2 != null)
            {
                // Player 1 attacks Player 2
                pokemonPlayer2.Defend(pokemonPlayer1.Type, pokemonPlayer1.Attack());
                lblPokemonPlayer2.Content = pokemonPlayer2.ShowInfo();

                // Check if Player 2 is dead
                if (!pokemonPlayer2.IsAlive)
                {
                    pokemoncardsPlayer2.Remove(pokemonPlayer2.Name);
                    cmbPokemonPlayer2.Items.Refresh();
                    cmbPokemonPlayer2.IsEnabled = true;

                    CheckGameOver();
                }
            }
        }

        // Event handler for Player 2's attack button
        private void btnAttackPlayer2_Click(object sender, RoutedEventArgs e)
        {
            if (pokemonPlayer1 != null && pokemonPlayer2 != null)
            {
                // Player 2 attacks Player 1
                pokemonPlayer1.Defend(pokemonPlayer2.Type, pokemonPlayer2.Attack());
                lblPokemonPlayer1.Content = pokemonPlayer1.ShowInfo();

                // Check if Player 1 is dead
                if (!pokemonPlayer1.IsAlive)
                {
                    pokemoncardsPlayer1.Remove(pokemonPlayer1.Name);
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