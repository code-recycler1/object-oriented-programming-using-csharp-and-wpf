using System;

namespace UnitTestingExercises_Models
{
    /// <summary>
    /// Represents a swimming pool with dimensions like depth, length, width, and edge distance.
    /// </summary>
    public class SwimmingPool
    {
        // Private fields to store the swimming pool dimensions
        private double _depth;
        private double _length;
        private double _width;
        private double _edgeDistance;

        /// <summary>
        /// Gets or sets the depth of the swimming pool. Value must be non-negative.
        /// </summary>
        public double Depth
        {
            get { return _depth; }
            set { _depth = Math.Max(0, value); } // Ensure depth is not negative
        }

        /// <summary>
        /// Gets or sets the length of the swimming pool. Value must be non-negative.
        /// </summary>
        public double Length
        {
            get { return _length; }
            set { _length = Math.Max(0, value); } // Ensure length is not negative
        }

        /// <summary>
        /// Gets or sets the width of the swimming pool. Value must be non-negative.
        /// </summary>
        public double Width
        {
            get { return _width; }
            set { _width = Math.Max(0, value); } // Ensure width is not negative
        }

        /// <summary>
        /// Gets or sets the edge distance of the swimming pool. Value must be non-negative and less than depth.
        /// </summary>
        public double EdgeDistance
        {
            get { return _edgeDistance; }
            set
            {
                // Ensure edge distance is not negative and less than depth
                if (value < 0 || value >= Depth)
                {
                    _edgeDistance = 0;
                }
                else
                {
                    _edgeDistance = value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the SwimmingPool class with default values.
        /// </summary>
        public SwimmingPool()
        {
            Depth = 0;
            Length = 0;
            Width = 0;
            EdgeDistance = 0;
        }

        /// <summary>
        /// Calculates the volume of water in the swimming pool in liters.
        /// </summary>
        /// <returns>The volume of water in liters.</returns>
        public double CalculateVolume()
        {
            double volume;
            volume = Width * (Depth - EdgeDistance) * Length * 1000;
            return volume;
        }

        /// <summary>
        /// Returns a string representation of the swimming pool data.
        /// </summary>
        /// <returns>A formatted string containing the pool dimensions and water volume.</returns>
        public string ShowData()
        {
            return $"Depth = {Depth} \n"
                 + $"Width = {Width} \n"
                 + $"Length = {Length} \n"
                 + $"Edge distance = {EdgeDistance} \n\n"
                 + $"Liters Water = {CalculateVolume()} \n";
        }
    }
}
