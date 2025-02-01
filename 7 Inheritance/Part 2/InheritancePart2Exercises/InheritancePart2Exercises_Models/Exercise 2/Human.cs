namespace InheritancePart2Exercises_Models.Exercise_2
{
    public class Human : Animal
    {
        // Constructor to initialize the human's name
        public Human(string name) : base(name) { }

        // Override property to display human-specific data
        public override string Data
        {
            get { return $"{base.Data} Hahahaha!"; }
        }

        // Override method for the human to eat
        public override string Eat()
        {
            return "Yummy!";
        }

        // Override method for the human to be caressed
        public override string Caress()
        {
            return "Get your hands off me!";
        }

        // Override method for the human to talk
        public override string Talk(string sentence)
        {
            switch (sentence)
            {
                case "Hello": return $"Hey, I am {Name}";
                case "Good morning": return "A good morning to you too!";
                case "How are you?": return "Seemingly well";
                case "Who are you?": return Name;
                case "What's the time?": return "I don't have the time on me";
                case "Are you hungry?": return "Only craving";
                case "Polly wants a.... ?": return "I don't know";
                case "What is the State fish of Hawaii?": return "I don't know";
                case "What is 10 + 12?": return "22, I think";
                case "What color is your hair?": return "Brown";
            }
            return "Silence is a fine virtue";
        }
    }
}