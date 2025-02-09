using System;

namespace InheritancePart3Exercises_Models.Exercise_3
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

        // Override ToString to display circle data
        public override string ToString()
        {
            return $"{this.Description} \n"
                 + $"Area: {Area():0.00}\n"
                 + $"Circumference: {Circumference():0.00}\n";
        }

        // Override Equals to compare circles by X, Y, R, and type
        public override bool Equals(object obj)
        {
            if (obj is Circle circle)
            {
                return base.Equals(obj) && this.R == circle.R;
            }
            return false;
        }
    }
}