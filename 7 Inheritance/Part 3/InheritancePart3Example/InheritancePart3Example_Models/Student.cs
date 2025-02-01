using System;

namespace InheritancePart3Example_Models
{
    public class Student : User
    {
        // Property for scholarship status
        public bool Scholarship { get; set; }

        // Constructor to initialize student details
        public Student(int number, string firstName, string lastName, bool scholarship)
            : base(number, firstName, lastName)
        {
            this.Scholarship = scholarship;
        }

        // Override method to display student data
        public override string ShowData(string separator)
        {
            return base.ShowData(separator) + (Scholarship ? "(Scholarship)\n" : Environment.NewLine);
        }
    }
}