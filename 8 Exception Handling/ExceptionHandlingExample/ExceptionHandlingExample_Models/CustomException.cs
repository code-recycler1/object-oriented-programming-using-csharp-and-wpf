using System;

namespace ExceptionHandlingExample_Models
{
    public class CustomException : Exception
    {
        // Default constructor
        public CustomException() : base() { }

        // Constructor with message
        public CustomException(string message) : base(message) { }
    }
}