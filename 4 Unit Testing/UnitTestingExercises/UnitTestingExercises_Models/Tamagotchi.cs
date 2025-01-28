using System;

namespace UnitTestingExercises_Models
{
    /// <summary>
    /// Represents a Tamagotchi pet with properties like WellBeing, Hunger, and LastMeal.
    /// </summary>
    public class Tamagotchi
    {
        // Private fields to store Tamagotchi data
        private int _wellBeing;
        private int _hunger;
        private DateTime _lastMeal;
        private string _name;

        /// <summary>
        /// Gets or sets the name of the Tamagotchi.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets the WellBeing of the Tamagotchi. Value is between -10 and 10.
        /// </summary>
        public int WellBeing
        {
            get { return _wellBeing; }
            private set
            {
                _wellBeing = Math.Max(-10, Math.Min(10, value)); // Ensure WellBeing stays within bounds
            }
        }

        /// <summary>
        /// Gets the Hunger level of the Tamagotchi. Value is between -5 and 20.
        /// </summary>
        public int Hunger
        {
            get { return _hunger; }
            private set
            {
                _hunger = Math.Max(-5, Math.Min(20, value)); // Ensure Hunger stays within bounds
            }
        }

        /// <summary>
        /// Gets the time of the last meal.
        /// </summary>
        public DateTime LastMeal
        {
            get { return _lastMeal; }
            private set { _lastMeal = value; }
        }

        /// <summary>
        /// Initializes a new instance of the Tamagotchi class with default values.
        /// </summary>
        /// <param name="name">The name of the Tamagotchi.</param>
        public Tamagotchi(string name) : this(name, 5, 5) { }

        /// <summary>
        /// Initializes a new instance of the Tamagotchi class with specified values.
        /// </summary>
        /// <param name="name">The name of the Tamagotchi.</param>
        /// <param name="hunger">The initial hunger level.</param>
        /// <param name="feeling">The initial WellBeing level.</param>
        public Tamagotchi(string name, int hunger, int feeling)
        {
            Name = name;
            WellBeing = feeling;
            Hunger = hunger;
            LastMeal = DateTime.Now; // Set the last meal time to the current time
        }

        /// <summary>
        /// Feeds the Tamagotchi. Hunger increases by the provided units, but cannot exceed 3 units per feed.
        /// </summary>
        /// <param name="units">The amount of food to feed the Tamagotchi.</param>
        public void Feed(int units)
        {
            int effectiveUnits = Math.Min(Math.Abs(units), 3); // Tamagotchi can only absorb up to 3 units at a time
            Hunger += effectiveUnits;
            LastMeal = DateTime.Now; // Update the last meal time
        }

        /// <summary>
        /// Pets the Tamagotchi, increasing its WellBeing by 1.
        /// </summary>
        public void Pet()
        {
            WellBeing += 1; // Increase WellBeing by 1
        }

        /// <summary>
        /// Punishes the Tamagotchi, decreasing its WellBeing by the provided units.
        /// </summary>
        /// <param name="units">The amount of punishment to apply.</param>
        public void Punish(int units)
        {
            WellBeing -= Math.Abs(units); // Decrease WellBeing by the absolute value of units
        }

        /// <summary>
        /// Calculates the Tamagotchi's current feeling based on WellBeing and Hunger.
        /// </summary>
        /// <returns>A string describing the Tamagotchi's feeling.</returns>
        public string Feeling()
        {
            // Decrease WellBeing by 1 if it's positive (Tamagotchi misses affection)
            if (WellBeing > 0)
            {
                WellBeing -= 1;
            }

            // Calculate hunger based on time since last meal
            TimeSpan timeSinceLastMeal = DateTime.Now - LastMeal;
            int hungerUnits = (int)timeSinceLastMeal.TotalSeconds / 30; // Hunger increases every 30 seconds

            if (hungerUnits > 0)
            {
                Hunger -= hungerUnits;
                LastMeal = DateTime.Now; // Update the last meal time
            }

            // Return a string describing the Tamagotchi's feeling
            return $"Feeling = {WellBeing} - Hunger = {Hunger}";
        }
    }
}
