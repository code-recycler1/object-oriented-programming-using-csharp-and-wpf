namespace OO_Exercises_Models
{
    public class Student
    {
        // Private fields to store the student's data
        private string _name;
        private double _mathematics;
        private double _computerScience;

        // Property for the name with validation
        public string Name
        {
            get { return _name; }
            set
            {
                // If the name is empty or numeric, set it to "..."
                if (string.IsNullOrEmpty(value) || int.TryParse(value, out _))
                {
                    _name = "...";
                }
                else
                {
                    // Convert the name to uppercase
                    _name = value.ToUpper();
                }
            }
        }

        // Property for the mathematics grade with validation
        public double Mathematics
        {
            get { return _mathematics; }
            set
            {
                // Ensure the grade is between 0 and 20
                if (value < 0 || value > 20)
                {
                    _mathematics = 0;
                }
                else
                {
                    _mathematics = value;
                }
            }
        }

        // Property for the computer science grade with validation
        public double ComputerScience
        {
            get { return _computerScience; }
            set
            {
                // Ensure the grade is between 0 and 20
                if (value < 0 || value > 20)
                {
                    _computerScience = 0;
                }
                else
                {
                    _computerScience = value;
                }
            }
        }

        // Constructor to initialize the Student object with default values
        public Student()
        {
            Name = "";
            Mathematics = 0;
            ComputerScience = 0;
        }

        // Method to return a string representation of the student's data
        public string ShowData()
        {
            return $"{Name} earned a {Mathematics} on mathematics and {ComputerScience} on computer science.";
        }
    }
}