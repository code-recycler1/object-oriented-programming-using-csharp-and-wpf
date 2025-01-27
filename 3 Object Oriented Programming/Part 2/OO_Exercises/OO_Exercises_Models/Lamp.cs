using System;
using System.Windows.Media;

namespace OO_Exercises_Models
{
    public class Lamp
    {
        // Private fields to store RGB values and a Random object
        private Random _random;
        private byte _red;
        private byte _green;
        private byte _blue;

        // Properties for Red, Green, and Blue with validation
        public byte Red
        {
            get { return _red; }
            set
            {
                // Ensure the value is between 0 and 255
                _red = (value < 0) ? (byte)0 : (value > 255) ? (byte)255 : value;
            }
        }
        public byte Green
        {
            get { return _green; }
            set
            {
                // Ensure the value is between 0 and 255
                _green = (value < 0) ? (byte)0 : (value > 255) ? (byte)255 : value;
            }
        }
        public byte Blue
        {
            get { return _blue; }
            set
            {
                // Ensure the value is between 0 and 255
                _blue = (value < 0) ? (byte)0 : (value > 255) ? (byte)255 : value;
            }
        }

        // Property for the Random object
        private Random Random
        {
            get { return _random; }
            set { _random = value; }
        }

        // Default constructor
        public Lamp() : this(0, 0, 0) { }

        // Constructor with parameters
        public Lamp(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Random = new Random(); // Initialize the Random object
        }

        // Method to set random RGB values
        public void RandomColor()
        {
            Red = (byte)Random.Next(0, 256);
            Green = (byte)Random.Next(0, 256);
            Blue = (byte)Random.Next(0, 256);
        }

        // Methods to adjust RGB values
        public void MoreRed() { Red += 10; }
        public void LessRed() { Red -= 10; }
        public void MoreGreen() { Green += 10; }
        public void LessGreen() { Green -= 10; }
        public void MoreBlue() { Blue += 10; }
        public void LessBlue() { Blue -= 10; }

        // Method to get the lamp color as a SolidColorBrush
        public SolidColorBrush GetLampColor()
        {
            return new SolidColorBrush(Color.FromRgb(Red, Green, Blue));
        }

        // Method to display RGB values as a string
        public string ShowRgbValues()
        {
            return $"Red = {Red}    Green = {Green}    Blue = {Blue}";
        }
    }
}