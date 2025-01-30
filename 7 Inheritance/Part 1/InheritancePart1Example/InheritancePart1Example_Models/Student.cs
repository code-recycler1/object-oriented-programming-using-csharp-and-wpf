namespace InheritancePart1Example_Models
{
    public class Student : User
    {
        // Property for HasScholarship status
        public bool HasScholarship { get; set; }

        // Constructor
        public Student(int number, string firstName, string lastName, bool hasScholarship)
            : base(number, firstName, lastName)
        {
            HasScholarship = hasScholarship;
        }

        // Override method to display student data
        public override string ShowData(string separator)
        {
            return $"{base.ShowData(separator)}{(HasScholarship ? "(Scholarship)" : "")}\n";
        }
    }
}