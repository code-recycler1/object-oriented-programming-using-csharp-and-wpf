namespace InheritancePart3Exercises_Models.Exercise_2
{
    public class Animal
    {
        private string _name;

        // Property to get the animal's name
        protected string Name
        {
            get { return _name; }
        }

        // Virtual property to display animal data
        public virtual string Data
        {
            get { return $"My name is {this.Name} and I am a {this.GetType().Name}."; }
        }

        // Constructor to initialize the animal's name
        protected Animal(string name)
        {
            this._name = name;
        }

        // Virtual method for the animal to talk
        public virtual string Talk(string sentence)
        {
            return "";
        }

        // Virtual method for the animal to be caressed
        public virtual string Caress()
        {
            return "";
        }

        // Virtual method for the animal to eat
        public virtual string Eat()
        {
            return "";
        }

        // Override ToString to display animal data
        public override string ToString()
        {
            return Data;
        }

        // Override Equals to compare animals by name and type
        public override bool Equals(object obj)
        {
            if (obj is Animal animal)
            {
                return this.Name.Equals(animal.Name) && this.GetType() == animal.GetType();
            }
            return false;
        }
    }
}