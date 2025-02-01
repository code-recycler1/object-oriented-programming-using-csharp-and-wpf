namespace InheritancePart2Exercises_Models.Exercise_3
{
    public class Cylinder : Circle
    {
        // Property for height
        public double H { get; set; }

        // Override property to describe the cylinder
        public override string Description
        {
            get { return $"{base.Description}, height = {H}"; }
        }

        // Default constructor
        public Cylinder() : this(0, 0, 0, 0) { }

        // Parameterized constructor
        public Cylinder(double x, double y, double r, double h) : base(x, y, r)
        {
            this.H = h;
        }

        // Override method to calculate surface area
        public override double Area()
        {
            return base.Area() * 2 + base.Circumference() * H;
        }

        // Method to calculate volume
        public double Volume()
        {
            return base.Area() * H;
        }

        // Override method to display cylinder data
        public override string ShowData()
        {
            return $"{this.Description}\n" +
                   $"Area: {Area():0.00}\n" +
                   $"Volume: {Volume():0.00}\n";
        }
    }
}