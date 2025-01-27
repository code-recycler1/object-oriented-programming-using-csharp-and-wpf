using System;

namespace OO_Exercises_Models
{
    public class Tamagotchi
    {
        // Private fields to store Tamagotchi data
        private int _wellBeing;
        private int _hunger;
        private DateTime _lastMeal;
        private string _name;

        // Property for Name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Property for WellBeing with validation
        private int WellBeing
        {
            get { return _wellBeing; }
            set
            {
                if (value > 10)
                {
                    _wellBeing = 10; // Ensure WellBeing does not exceed 10
                }
                else if (value < -10)
                {
                    _wellBeing = -10; // Ensure WellBeing does not go below -10
                }
                else
                {
                    _wellBeing = value;
                }
            }
        }

        // Property for Hunger with validation
        private int Hunger
        {
            get { return _hunger; }
            set
            {
                if (value > 20)
                {
                    _hunger = 20; // Ensure Hunger does not exceed 20
                }
                else if (value < -5)
                {
                    _hunger = -5; // Ensure Hunger does not go below -5
                }
                else
                {
                    _hunger = value;
                }
            }
        }

        // Property for LastMeal
        private DateTime LastMeal
        {
            get { return _lastMeal; }
            set { _lastMeal = value; }
        }

        // Default constructor
        public Tamagotchi(string name) : this(name, 5, 5) { }

        // Constructor with parameters
        public Tamagotchi(string name, int hunger, int feeling)
        {
            Name = name;
            WellBeing = feeling;
            Hunger = hunger;
            LastMeal = DateTime.Now; // Set the last meal time to the current time
        }

        // Method to feed the Tamagotchi
        public void Feed(int units)
        {
            if (units > 3)
            {
                Hunger += 3; // Tamagotchi can only absorb 3 units at a time
            }
            else
            {
                Hunger += units; // Add the provided units to Hunger
            }

            LastMeal = DateTime.Now; // Update the last meal time
        }

        // Method to pet the Tamagotchi
        public void Pet()
        {
            WellBeing += 1; // Increase WellBeing by 1
        }

        // Method to punish the Tamagotchi
        public void Punish(int units)
        {
            WellBeing -= units; // Decrease WellBeing by the provided units
        }

        // Method to get the Tamagotchi's feeling
        public string Feeling()
        {
            string feeling = "";
            TimeSpan time;
            DateTime now;

            int seconds;
            int hungerUnits;

            if (WellBeing > 0)
            {
                WellBeing -= 1; // Decrease WellBeing by 1 (misses affection)
            }

            now = DateTime.Now;
            time = now.Subtract(LastMeal);
            seconds = time.Hours * 3600 + time.Minutes * 60 + time.Seconds;
            hungerUnits = seconds / 30; // Calculate hunger units based on time since last meal

            if (hungerUnits > 0)
            {
                Hunger -= hungerUnits; // Decrease Hunger by the calculated units
                LastMeal = now; // Update the last meal time
            }

            feeling = "Feeling = " + WellBeing + " - hunger = " + Hunger; // Create the feeling string
            return feeling;
        }
    }
}