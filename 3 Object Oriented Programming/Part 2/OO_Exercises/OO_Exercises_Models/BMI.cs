namespace OO_Exercises_Models
{
    public class BMI
    {
        // Private fields to store the name, weight, and length
        private string _name;
        private double _weight;
        private double _length;

        // Public properties to access private fields
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        // Default constructor
        public BMI() : this("", 0, 0) { }

        // Constructor with parameters
        public BMI(string name, double weight, double length)
        {
            Name = name;
            Weight = weight;
            Length = length;
        }

        // Method to calculate the BMI
        public double CalculateBMI()
        {
            return Weight / (Length * Length);
        }

        // Method to provide a textual representation of the object
        public string ShowData()
        {
            return $"{Name} weighs {Weight} kg and is {Length} m tall.";
        }
    }
}