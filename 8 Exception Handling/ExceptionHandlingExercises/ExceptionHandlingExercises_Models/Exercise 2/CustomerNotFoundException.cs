using System;

namespace ExceptionHandlingExercises_Models.Exercise_2
{
    // Custom exception for customer not found
    public class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException(int customerNumber) : base($"The customer number {customerNumber} does not exist.") { }
    }
}