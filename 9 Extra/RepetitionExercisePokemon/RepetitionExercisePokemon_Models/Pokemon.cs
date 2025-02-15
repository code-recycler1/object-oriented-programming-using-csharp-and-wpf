using System;

namespace RepetitionExercisePokemon_Models
{
    public class Pokemon
    {
        // Fields for Pokémon properties
        private readonly Random _random = new Random(); // Single Random instance for attack logic

        // Properties
        public string Name { get; set; }
        public int Hp { get; private set; }
        public string Type { get; set; }
        public string AttackDescription1 { get; set; }
        public int AttackPower1 { get; set; }
        public string AttackDescription2 { get; set; }
        public int AttackPower2 { get; set; }
        public string Weakness { get; set; }
        public int WeaknessMultiplier { get; set; }
        public string Resistance { get; set; }
        public int ResistanceReduction { get; set; }
        public string Image { get; set; }

        // Property to check if the Pokémon is alive
        public bool IsAlive => Hp > 0;

        // Constructor to initialize a Pokémon
        public Pokemon(string name, int hp, string type, string attackDescription1, int attackPower1, string attackDescription2, int attackPower2, string weakness, int weaknessMultiplier, string resistance, int resistanceReduction, string image)
        {
            Name = name;
            Hp = hp >= 0 ? hp : throw new ArgumentException("HP cannot be negative.", nameof(hp));
            Type = type;
            AttackDescription1 = attackDescription1;
            AttackPower1 = attackPower1;
            AttackDescription2 = attackDescription2;
            AttackPower2 = attackPower2;
            Weakness = weakness;
            WeaknessMultiplier = weaknessMultiplier;
            Resistance = resistance;
            ResistanceReduction = resistanceReduction;
            Image = image;
        }

        // Method to calculate attack power
        public int Attack()
        {
            // Randomly choose between AttackPower1 and AttackPower2
            int attackPower = _random.Next(0, 2) == 1 ? AttackPower1 : AttackPower2;

            // 1 in 5 chance to double the attack power
            return _random.Next(0, 5) == 0 ? attackPower * 2 : attackPower;
        }

        // Method to defend against an attack
        public void Defend(string attackType, int attackPower)
        {
            if (attackType == Weakness)
            {
                Hp -= WeaknessMultiplier * attackPower;
            }
            else if (attackType == Resistance)
            {
                Hp -= Math.Max(attackPower - ResistanceReduction, 0);
            }
            else
            {
                Hp -= attackPower;
            }

            // Ensure HP doesn't go below 0
            Hp = Math.Max(Hp, 0);
        }

        // Method to display Pokémon info
        public string ShowInfo()
        {
            return $"{Name} is {(IsAlive ? "still alive" : "dead")}.\nRemaining HP: {Hp}";
        }
    }
}