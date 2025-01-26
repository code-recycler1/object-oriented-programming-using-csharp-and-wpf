using System;

namespace OO_Exercises_Models
{
    public class Rectangle
    {
        // Private fields to store the rectangle's dimensions
        private double _height;
        private double _width;

        // Property for the height with validation
        public double Height
        {
            get { return _height; }
            set
            {
                // Ensure height is non-negative
                if (value < 0)
                {
                    _height = 0;
                }
                else
                {
                    _height = value;
                }
            }
        }

        // Property for the width with validation
        public double Width
        {
            get { return _width; }
            set
            {
                // Ensure width is non-negative
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

        // Constructor to initialize the Rectangle object with default values
        public Rectangle()
        {
            Height = 0;
            Width = 0;
        }

        // Method to calculate the area of the rectangle
        public double CalculateArea()
        {
            return Height * Width;
        }

        // Method to return a string representation of the rectangle's data
        public string ShowData()
        {
            return $"Height: {Height} {Environment.NewLine}"
                + $"Width: {Width} {Environment.NewLine}"
                + $"Area: {CalculateArea()} {Environment.NewLine}";
        }
    }
}