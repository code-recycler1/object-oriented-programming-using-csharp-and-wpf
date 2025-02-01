using System;

namespace InheritancePart2Exercises_Models.Exercise_3
{
    public class Circle : Point
    {
        // Property for radius
        public double R { get; set; }

        // Override property to describe the circle
        public override string Description
        {
            get { return $"{base.Description}, radius = {R}"; }
        }

        // Default constructor
        public Circle() : this(0, 0, 0) { }

        // Parameterized constructor
        public Circle(double x, double y, double r) : base(x, y)
        {
            this.R = r;
        }

        // Method to calculate circumference
        public double Circumference()
        {
            return 2 * Math.PI * R;
        }

        // Virtual method to calculate area
        public virtual double Area()
        {
            return Math.PI * R * R;
        }

        // Override method to display circle data
        public override string ShowData()
        {
            return $"{this.Description} \n"
                 + $"Area: {Area():0.00}\n"
                 + $"Circumference: {Circumference():0.00}\n";
        }
    }
}