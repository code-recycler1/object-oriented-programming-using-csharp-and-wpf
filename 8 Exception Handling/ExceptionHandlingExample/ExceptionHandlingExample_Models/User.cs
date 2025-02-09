using System;

namespace ExceptionHandlingExample_Models
{
    public class User
    {
        // Properties for user details
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Read-only property for full name
        public string FullName
        {
            get { return $"{this.GetType().Name}: {FirstName} {LastName}"; }
        }

        // Constructor to initialize user details
        public User(int number, string firstName, string lastName)
        {
            // Validate number
            if (number < 0)
            {
                throw new CustomException("Number may not be lower than 0!");
            }

            this.Number = number;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // Override ToString to display user data
        public override string ToString()
        {
            return ShowData(Environment.NewLine);
        }

        // Virtual method to display user data
        public virtual string ShowData(string separator)
        {
            return $"{Number}{separator}" +
                   $"{FirstName}{separator}" +
                   $"{LastName}{separator}";
        }

        // Override Equals to compare users by number and type
        public override bool Equals(object obj)
        {
            if (obj is User user)
            {
                return user.Number == this.Number && this.GetType() == user.GetType();
            }
            return false;
        }

        // Override GetHashCode to support Equals
        public override int GetHashCode()
        {
            return -1472680747 + Number.GetHashCode();
        }
    }
}