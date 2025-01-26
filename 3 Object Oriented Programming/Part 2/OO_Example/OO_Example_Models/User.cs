using System;

namespace OO_Example_Models
{
    public class User
    {
        // Private fields for user data
        private int _number;
        private string _firstName;
        private string _lastName;

        // Public properties to access private fields
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
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

        // Constructors for creating User objects
        public User() : this(0, "", "") { } // Default constructor

        public User(string firstName, string lastName) : this(0, firstName, lastName) { } // Constructor without number

        public User(int number, string firstName, string lastName) // Full constructor
        {
            this.Number = number;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // Method to clear user data
        public void Clear()
        {
            this.Number = 0;
            this.FirstName = "";
            this.LastName = "";
        }

        // Property to get the full name of the user
        public string FullName
        {
            get { return this.FirstName + " " + this.LastName; }
        }

        // Method to display user data with a default separator (newline)
        public string ShowData()
        {
            return ShowData(Environment.NewLine);
        }

        // Method to display user data with a custom separator
        public string ShowData(string separator)
        {
            return Number.ToString() + separator + FirstName + separator + LastName + separator;
        }

        // Override ToString() to display user data with a hyphen separator
        public override string ToString()
        {
            return ShowData("-");
        }
    }
}