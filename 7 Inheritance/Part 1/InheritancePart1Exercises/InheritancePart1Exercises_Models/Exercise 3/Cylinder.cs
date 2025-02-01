namespace InheritancePart1Exercises_Models.Exercise_3
{
    public class Cylinder : Circle
    {
        // Private field for the height
        private double _h;

        // Public property for the height
        public double H
        {
            get { return _h; }
            set { _h = value; }
        }

        // Override property to display the description of the cylinder
        public override string Description
        {
            get
            {
                return $"{base.Description}, height = {H}";
            }
        }

        // Default constructor
        public Cylinder() : this(0, 0, 0, 0) { }

        // Parameterized constructor
        public Cylinder(double x, double y, double r, double h)
            : base(x, y, r)
        {
            H = h;
        }

        // Override method to calculate the surface area of the cylinder
        public override double Area()
        {
            return base.Area() * 2 + base.Circumference() * H;
        }

        // Method to calculate the volume of the cylinder
        public double Volume()
        {
            return base.Area() * H;
        }

        // Override method to display the cylinder's data
        public override string ShowData()
        {
            return $"{this.Description}\n" +
                   $"Area: {Area():0.00}\n" +
                   $"Volume: {Volume():0.00}\n";
        }
    }
}
