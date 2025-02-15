namespace ExamExamples_Models.Exercise_2
{
    public class Dish
    {
        // Properties
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

        // Constructor
        public Dish(string type, string name, double price)
        {
            Type = type;
            Name = name;
            Price = price;
        }

        // Override ToString to display dish details
        public override string ToString()
        {
            return $"{Name} - €{Price:0.00}";
        }
    }

}
