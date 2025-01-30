namespace InheritancePart1Example_Models
{
    public class Teacher : User
    {
        // Property for salary
        public double Salary { get; set; }

        // Constructor
        public Teacher(int number, string firstName, string lastName, double salary)
            : base(number, firstName, lastName)
        {
            Salary = salary;
        }

        // Override method to display teacher data
        public override string ShowData(string separator)
        {
            return $"{base.ShowData(separator)}{Salary}\n";
        }
    }
}