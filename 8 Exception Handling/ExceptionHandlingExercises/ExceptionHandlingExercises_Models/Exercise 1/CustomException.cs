using System;

namespace ExceptionHandlingExercises_Models.Exercise_1
{
    public class CustomException : Exception
    {
        // Default constructor
        public CustomException() : base() { }

        // Constructor with message
        public CustomException(string message) : base(message) { }
    }
}