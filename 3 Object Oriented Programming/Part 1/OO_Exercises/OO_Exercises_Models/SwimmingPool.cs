using System;

namespace OO_Exercises_Models
{
    public class SwimmingPool
    {
        // Private fields to store the swimming pool dimensions
        private double _depth;
        private double _length;
        private double _width;
        private double _edgeDistance;

        // Property for depth with validation
        public double Depth
        {
            get
            {
                return _depth;
            }
            set
            {
                // Ensure depth is not negative
                if (value < 0)
                {
                    _depth = 0;
                }
                else
                {
                    _depth = value;
                }
            }
        }

        // Property for length with validation
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                // Ensure length is not negative
                if (value < 0)
                {
                    _length = 0;
                }
                else
                {
                    _length = value;
                }
            }
        }

        // Property for width with validation
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                // Ensure width is not negative
                if (value < 0)
                {
                    _width = 0;
                }
                else
                {
                    _width = value;
                }
            }
        }

        // Property for edge distance with validation
        public double EdgeDistance
        {
            get
            {
                return _edgeDistance;
            }
            set
            {
                // Ensure edge distance is not negative and less than depth
                if (value < 0 || Depth <= value)
                {
                    _edgeDistance = 0;
                }
                else
                {
                    _edgeDistance = value;
                }
            }
        }

        // Constructor to initialize the swimming pool with default values
        public SwimmingPool()
        {
            Depth = 0;
            Length = 0;
            Width = 0;
            EdgeDistance = 0;
        }

        // Method to calculate the volume of water in liters
        public double CalculateVolume()
        {
            double volume;
            volume = Width * (Depth - EdgeDistance) * Length * 1000;
            return volume;
        }

        // Method to return a string representation of the swimming pool data
        public string ShowData()
        {
            return $"Depth = {Depth} {Environment.NewLine}"
               + $"Width = {Width} {Environment.NewLine}"
               + $"Length = {Length} {Environment.NewLine}"
               + $"Edge distance = {EdgeDistance} {Environment.NewLine}{Environment.NewLine}"
               + $"Liters Water = {CalculateVolume()} {Environment.NewLine}";
        }
    }
}