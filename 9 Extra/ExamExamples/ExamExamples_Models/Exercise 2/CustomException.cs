using System;

namespace ExamExamples_Models.Exercise_2
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}
