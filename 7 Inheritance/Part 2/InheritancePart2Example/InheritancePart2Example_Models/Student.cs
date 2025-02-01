using System;

namespace InheritancePart2Example_Models
{
    public class Student : User
    {
        // Private field for scholarship status
        private bool _scholarship;

        // Public property for scholarship status
        public bool Scholarship
        {
            get { return _scholarship; }
            set { _scholarship = value; }
        }

        // Parameterized constructor
        public Student(int number, string firstName, string lastName, bool scholarship)
            : base(number, firstName, lastName)
        {
            this.Scholarship = scholarship;
        }

        // Override method to display student data
        public override string ShowData(string separator)
        {
            if (Scholarship)
            {
                return base.ShowData(separator) + "(Scholarship)\n";
            }
            else
            {
                return base.ShowData(separator) + Environment.NewLine;
            }
        }
    }
}
