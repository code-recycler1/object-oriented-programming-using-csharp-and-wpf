namespace InheritancePart3Exercises_Models.Exercise_3
{
    public class Point
    {
        // Properties for X and Y coordinates
        public double X { get; set; }
        public double Y { get; set; }

        // Virtual property to describe the point
        public virtual string Description
        {
            get { return $"{this.GetType().Name}: coordinates = ({this.X}, {this.Y})"; }
        }

        // Default constructor
        public Point() : this(0, 0) { }

        // Parameterized constructor
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        // Override ToString to display point data
        public override string ToString()
        {
            return this.Description;
        }

        // Override Equals to compare points by X, Y, and type
        public override bool Equals(object obj)
        {
            if (obj is Point point)
            {
                return this.X == point.X && this.Y == point.Y && this.GetType() == point.GetType();
            }
            return false;
        }
    }
}