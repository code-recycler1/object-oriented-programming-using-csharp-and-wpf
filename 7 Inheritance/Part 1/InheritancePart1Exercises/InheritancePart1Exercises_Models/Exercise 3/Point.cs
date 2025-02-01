namespace InheritancePart1Exercises_Models.Exercise_3
{
    public class Point
    {
        // Private fields for X and Y coordinates
        private double _x;
        private double _y;

        // Public properties for X and Y coordinates
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        // Virtual property to display the description of the point
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

        // Virtual method to display the point's data
        public virtual string ShowData()
        {
            return this.Description;
        }
    }
}
