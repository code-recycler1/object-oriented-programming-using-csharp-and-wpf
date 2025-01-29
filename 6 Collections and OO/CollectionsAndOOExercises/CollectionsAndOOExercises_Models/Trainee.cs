namespace CollectionsAndOOExercises_Models
{
    public class Trainee
    {
        // Private fields for first name and last name
        private string _firstName;
        private string _lastName;

        // Public properties for first name and last name
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        // Read-only property to get the full name
        public string FullName
        {
            get { return $"{_firstName} {_lastName}"; }
        }

        // Default constructor
        public Trainee() : this("", "") { }

        // Parameterized constructor
        public Trainee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}