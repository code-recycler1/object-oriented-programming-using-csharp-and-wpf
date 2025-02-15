namespace ExamExamples_Models.Exercise_2
{
    public class ChristmasDinnerReservation : DinnerReservation
    {
        // Additional properties for dessert
        public string Dessert { get; set; }
        public double DessertPrice { get; set; }

        // Constructor
        public ChristmasDinnerReservation(string name, int numberOfPeople, string mainCourse, double mainCoursePrice, string dessert, double dessertPrice)
            : base(name, numberOfPeople, mainCourse, mainCoursePrice)
        {
            Dessert = dessert;
            DessertPrice = dessertPrice;
        }

        // Override TotalCost to include dessert price
        public override double TotalCost()
        {
            return base.TotalCost() + (NumberOfPeople * DessertPrice);
        }
    }
}
