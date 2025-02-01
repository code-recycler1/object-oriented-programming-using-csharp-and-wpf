using System;

namespace InheritancePart1Exercises_Models.Exercise_3
{
    public class Circle : Point
    {
        // Private field for the radius
        private double _r;

        // Public property for the radius
        public double R
        {
            get { return _r; }
            set
            {
                if (value > 0)
                {
                    _r = value;
                }
            }
        }

        // Override property to display the description of the circle
        public override string Description
        {
            get
            {
                return $"{base.Description}, radius = {R}";
            }
        }

        // Default constructor
        public Circle() : this(0, 0, 0) { }

        // Parameterized constructor
        public Circle(double x, double y, double r) : base(x, y)
        {
            this.R = r;
        }

        // Method to calculate the circumference of the circle
        public double Circumference()
        {
            return 2 * Math.PI * R;
        }

        // Virtual method to calculate the area of the circle
        public virtual double Area()
        {
            return Math.PI * R * R;
        }

        // Override method to display the circle's data
        public override string ShowData()
        {
            return $"{this.Description} \n"
                + $"Area: {Area():0.00}\n"
                + $"Circumference: {Circumference():0.00}\n";
        }
    }
}
