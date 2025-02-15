using RepetitionExercisePokemon_Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RepetitionExercisePokemon_DAL
{
    public class FileReader
    {
        // Method to read Pokémon names from a file
        public List<string> ReadFileExercise2(string filePath)
        {
            List<string> pokemons = new List<string>();

            // Read the file line by line
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    pokemons.Add(line);
                }
            }

            return pokemons;
        }

        // Method to read Pokémon data from a file
        public List<Pokemon> ReadFileExercise3(string filePath)
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            // Read the file line by line
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    List<string> data = line.Split(';').ToList();

                    // Parse data and create Pokémon object
                    int.TryParse(data[2], out int hp);
                    int.TryParse(data[4], out int attackPower1);
                    int.TryParse(data[6], out int attackPower2);
                    int.TryParse(data[8], out int weaknessMultiplier);
                    int.TryParse(data[10], out int resistanceReduction);

                    Pokemon pokemon = new Pokemon(
                        data[0], // Name
                        hp, // HP
                        data[1], // Type
                        data[3], // AttackDescription1
                        attackPower1, // AttackPower1
                        data[5], // AttackDescription2
                        attackPower2, // AttackPower2
                        data[7], // Weakness
                        weaknessMultiplier, // WeaknessMultiplier
                        data[9], // Resistance
                        resistanceReduction, // ResistanceReduction
                        data[11] // Image
                    );

                    pokemons.Add(pokemon);
                }
            }

            return pokemons;
        }
    }
}
