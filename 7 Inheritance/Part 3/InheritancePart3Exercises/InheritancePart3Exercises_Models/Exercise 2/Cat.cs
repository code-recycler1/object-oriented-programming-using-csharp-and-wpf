namespace InheritancePart3Exercises_Models.Exercise_2
{
    public class Cat : Animal
    {
        private int _counter = 0;

        // Constructor to initialize the cat's name
        public Cat(string name) : base(name) { }

        // Override property to display cat-specific data
        public override string Data
        {
            get { return $"{base.Data} Meow, Meow!"; }
        }

        // Override method for the cat to talk
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

        // Override method for the cat to be caressed
        public override string Caress()
        {
            return "rrrrrrrrrrrr";
        }
    }
}