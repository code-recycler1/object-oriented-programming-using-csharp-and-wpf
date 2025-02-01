namespace InheritancePart1Exercises_Models.Exercise_2
{
    public class Cat : Animal
    {
        // Private field to count the number of times the cat talks
        private int _counter = 0;

        // Constructor to initialize the cat with a name
        public Cat(string name) : base(name) { }

        // Override property to display cat-specific data
        public override string Data
        {
            get { return $"{base.Data} Meow, Meow!"; }
        }

        // Override method for talking (cat-specific behavior)
        public override string Talk(string sentence)
        {
            _counter++;
            if (_counter == 3)
            {
                _counter = 0;
                return "meow meow";
            }
            else
            {
                return "";
            }
        }

        // Override method for caressing (cat-specific behavior)
        public override string Caress()
        {
            return "rrrrrrrrrrrr";
        }
    }
}
