using System;

namespace InheritancePart2Example_Models
{
    public class Teacher : User
    {
        // Private field for salary
        private double _salary;

        // Public property for salary
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        // Parameterized constructor
        public Teacher(int number, string firstName, string lastName, double salary)
            : base(number, firstName, lastName)
        {
            this.Salary = salary;
        }

        // Override method to display teacher data
        public override string ShowData(string separator)
        {
            return base.ShowData(separator) + Salary + Environment.NewLine;
        }
    }
}
