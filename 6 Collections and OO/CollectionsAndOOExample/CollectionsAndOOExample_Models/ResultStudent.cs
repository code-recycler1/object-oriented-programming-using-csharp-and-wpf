namespace CollectionsAndOOExample_Models
{
    public class ResultStudent
    {
        // Private fields for name and grades
        private string _name;
        private double _grades;

        // Public properties for name and grades
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

        // Read-only property to determine the result (Passed or Failed)
        public string Result
        {
            get
            {
                return (Grades < 50) ? "Failed" : "Passed";
            }
        }

        // Default constructor
        public ResultStudent() : this("", 0) { }

        // Parameterized constructor
        public ResultStudent(string name, double grades)
        {
            this.Name = name;
            this.Grades = grades;
        }

        // Override ToString method to display student details
        public override string ToString()
        {
            return Name.PadRight(20) + Grades.ToString().PadRight(5) + Result;
        }
    }
}
