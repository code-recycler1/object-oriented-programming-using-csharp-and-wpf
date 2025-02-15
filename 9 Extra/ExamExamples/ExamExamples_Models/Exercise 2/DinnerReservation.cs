namespace ExamExamples_Models.Exercise_2
{
    public class DinnerReservation
    {
        private string _name;
        private int _numberOfPeople;

        // Properties
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "")
                {
                    throw new CustomException("Name is not filled in!");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public int NumberOfPeople
        {
            get { return _numberOfPeople; }
            set
            {
                if (value < 0)
                {
                    throw new CustomException("Number of people must be a positive number!");
                }
                else
                {
                    _numberOfPeople = value;
                }
            }
        }
        public string MainCourse { get; set; }
        public double MainCoursePrice { get; set; }

        // Constructor
        public DinnerReservation(string name, int numberOfPeople, string mainCourse, double mainCoursePrice)
        {
            Name = name;
            NumberOfPeople = numberOfPeople;
            MainCourse = mainCourse;
            MainCoursePrice = mainCoursePrice;
        }

        // Method to calculate total cost
        public virtual double TotalCost()
        {
            return NumberOfPeople * MainCoursePrice;
        }

        // Override ToString to display reservation details
        public override string ToString()
        {
            string type = this.GetType().Name.Replace("Reservation", "");
            return $"{type,-15} {Name,-15} €{TotalCost():0.00}\n";
        }

        // Override Equals to compare reservations by name
        public override bool Equals(object obj)
        {
            if (obj is DinnerReservation reservation)
            {
                return this.Name == reservation.Name;
            }
            return false;
        }
    }

}
