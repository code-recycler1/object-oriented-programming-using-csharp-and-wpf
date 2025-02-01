using System;

namespace InheritancePart2Example_Models
{
    public class User
    {
        // Private fields for user properties
        private int _number;
        private string _firstName;
        private string _lastName;

        // Public properties for user properties
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

        // Read-only property to get the full name of the user
        public string FullName
        {
            get { return $"{this.GetType().Name}: {this.FirstName} {this.LastName}"; }
        }

        // Parameterized constructor
        public User(int number, string firstName, string lastName)
        {
            this.Number = number;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // Method overloading to display user data
        public string ShowData()
        {
            return ShowData(Environment.NewLine);
        }

        // Virtual method to display user data with a custom separator
        public virtual string ShowData(string separator)
        {
            return $"{Number}{separator}{FirstName}{separator}{LastName}{separator}";
        }
    }
}
