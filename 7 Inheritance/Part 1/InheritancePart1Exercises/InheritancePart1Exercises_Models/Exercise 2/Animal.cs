namespace InheritancePart1Exercises_Models.Exercise_2
{
    public class Animal
    {
        // Private field for the animal's name
        private string _name;

        // Protected property to access the name
        protected string Name
        {
            get { return _name; }
        }

        // Virtual property to display animal data
        public virtual string Data
        {
            get { return $"My name is {this.Name} and I am a {this.GetType().Name}."; }
        }

        // Protected constructor to set the name
        protected Animal(string name)
        {
            this._name = name;
        }

        // Virtual method for talking (default implementation)
        public virtual string Talk(string sentence)
        {
            return "";
        }

        // Virtual method for caressing (default implementation)
        public virtual string Caress()
        {
            return "";
        }

        // Virtual method for eating (default implementation)
        public virtual string Eat()
        {
            return "";
        }
    }
}
