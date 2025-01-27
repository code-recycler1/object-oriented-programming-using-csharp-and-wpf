using System;

namespace UnitTestingExample_Models
{
    public class User
    {
        // Private fields for user data
        private int _number;
        private string _firstName;
        private string _lastName;

        // Public properties to access the private fields
        public int Number
        {
            get { return _number; }
            set { _number = value < 0 ? 0 : value; }
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

        // Read-only property to get the full name
        public string FullName
        {
            get { return $"{_firstName} {_lastName}"; }
        }

        // Constructor to initialize the User object
        public User()
        {
            this.Number = 0;
            this.FirstName = "";
            this.LastName = "";
        }

        // Method to display the user data
        public string ShowData()
        {
            return this.Number.ToString() + Environment.NewLine
                + this.FirstName + Environment.NewLine
                + this.LastName + Environment.NewLine;
        }

        // Method to clear the user data
        public void Clear()
        {
            this.Number = 0;
            this.FirstName = "";
            this.LastName = "";
        }
    }
}
