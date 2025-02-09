using System;

namespace ExceptionHandlingExample_Models
{
    public class Student : User
    {
        // Property for scholarship status
        public bool HasScholarship { get; set; }

        // Constructor to initialize student details
        public Student(int number, string firstName, string lastName, bool hasScholarship)
            : base(number, firstName, lastName)
        {
            this.HasScholarship = hasScholarship;
        }

        // Override method to display student data
        public override string ShowData(string separator)
        {
            return base.ShowData(separator) + (HasScholarship ? "(Scholarship)" : "") + Environment.NewLine;
        }
    }
}