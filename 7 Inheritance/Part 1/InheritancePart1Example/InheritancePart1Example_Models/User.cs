using System;

namespace InheritancePart1Example_Models
{
    public class User
    {
        // Properties
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Read-only property for full name
        public string FullName => $"{FirstName} {LastName}";

        // Default constructor
        protected User() : this(0, "", "") { }

        // Parameterized constructor
        public User(int number, string firstName, string lastName)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
        }

        // Method overloading
        public string ShowData()
        {
            return ShowData(Environment.NewLine);
        }

        // Method to display user data
        public virtual string ShowData(string separator)
        {
            return $"{Number}{separator}" +
                   $"{FirstName}{separator}" +
                   $"{LastName}{separator}";
        }
    }
}