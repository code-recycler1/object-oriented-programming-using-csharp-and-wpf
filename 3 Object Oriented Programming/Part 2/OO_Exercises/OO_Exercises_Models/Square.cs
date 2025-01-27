using System;

namespace OO_Exercises_Models
{
    public class Square
    {
        // Private field to store the side length
        private int _side;

        // Property for Side with validation
        public int Side
        {
            get { return _side; }
            set
            {
                // Ensure the side is between 0 and 25
                if (value < 0)
                {
                    _side = 0;
                }
                else if (value > 25)
                {
                    _side = 25;
                }
                else
                {
                    _side = value;
                }
            }
        }

        // Default constructor
        public Square() : this(0) { }

        // Constructor with side length parameter
        public Square(int length)
        {
            Side = length; // Set the side length using the property
        }

        // Method to calculate the perimeter
        public int Perimeter()
        {
            return Side * 4;
        }

        // Method to calculate the area
        public int Area()
        {
            return Side * Side;
        }

        // Method to calculate the diagonal length
        public double Diagonal()
        {
            return Side * Math.Sqrt(2);
        }

        // Method to draw the square as a star matrix
        public string Draw()
        {
            string output = "";
            for (int row = 0; row < Side; row++)
            {
                for (int column = 0; column < Side; column++)
                {
                    output += "*  "; // Add a star for each cell
                }
                output += Environment.NewLine; // Move to the next line after each row
            }
            return output;
        }
    }
}