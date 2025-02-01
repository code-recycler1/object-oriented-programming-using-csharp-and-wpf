using System;

namespace InheritancePart2Exercises_Models.Exercise_2
{
    public class Parrot : Animal
    {
        // Constructor to initialize the parrot's name
        public Parrot(string name) : base(name) { }

        // Override property to display parrot-specific data
        public override string Data
        {
            get { return $"{base.Data} Krrr Krrr!"; }
        }

        // Override method for the parrot to talk
        public override string Talk(string sentence)
        {
            Random random = new Random();
            if (random.Next(1, 6) == 1)
                return "Koko wants a cracker";
            else
                return sentence;
        }

        // Override method for the parrot to be caressed
        public override string Caress()
        {
            return "Koko";
        }
    }
}