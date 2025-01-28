using System;

namespace UnitTestingExercises_Models
{
    /// <summary>
    /// Represents a train with properties like speed, passengers, and door status.
    /// </summary>
    public class Train
    {
        // Private fields to store train data
        private bool _doorsOpen;
        private int _passengers;
        private int _speed;

        /// <summary>
        /// Gets the number of passengers on the train. Value cannot be negative.
        /// </summary>
        public int Passengers
        {
            get { return _passengers; }
            private set { _passengers = Math.Max(0, value); } // Ensure passengers cannot be negative
        }

        /// <summary>
        /// Gets the speed of the train. Value is clamped between 0 and 120.
        /// </summary>
        public int Speed
        {
            get { return _speed; }
            private set { _speed = Math.Max(0, Math.Min(120, value)); } // Ensure speed stays within bounds
        }

        /// <summary>
        /// Gets whether the train doors are open.
        /// </summary>
        public bool DoorsOpen
        {
            get { return _doorsOpen; }
            private set { _doorsOpen = value; }
        }

        /// <summary>
        /// Initializes a new instance of the Train class with default values.
        /// </summary>
        public Train()
        {
            Passengers = 0; // Initialize passengers to 0
            DoorsOpen = true; // Initialize doors to open
        }

        /// <summary>
        /// Disembarks passengers from the train. Only works if doors are open.
        /// </summary>
        /// <param name="numberOfPersons">The number of passengers to disembark.</param>
        /// <returns>True if passengers were disembarked, otherwise false.</returns>
        public bool Disembark(int numberOfPersons)
        {
            if (DoorsOpen) // Check if doors are open
            {
                Passengers -= Math.Abs(numberOfPersons); // Decrease passengers
                return true;
            }
            return false; // Return false if doors are closed
        }

        /// <summary>
        /// Boards passengers onto the train. Only works if doors are open.
        /// </summary>
        /// <param name="numberOfPersons">The number of passengers to board.</param>
        /// <returns>True if passengers were boarded, otherwise false.</returns>
        public bool Embark(int numberOfPersons)
        {
            if (DoorsOpen) // Check if doors are open
            {
                Passengers += Math.Abs(numberOfPersons); // Increase passengers
                return true;
            }
            return false; // Return false if doors are closed
        }

        /// <summary>
        /// Decelerates the train by the specified amount.
        /// </summary>
        /// <param name="deceleration">The amount to decelerate.</param>
        public void Decelerate(int deceleration)
        {
            ChangeSpeed(-Math.Abs(deceleration)); // Decrease speed
        }

        /// <summary>
        /// Accelerates the train by the specified amount. Only works if doors are closed.
        /// </summary>
        /// <param name="acceleration">The amount to accelerate.</param>
        /// <returns>True if acceleration was successful, otherwise false.</returns>
        public bool Accelerate(int acceleration)
        {
            if (!DoorsOpen) // Check if doors are closed
            {
                ChangeSpeed(Math.Abs(acceleration)); // Increase speed
                return true;
            }
            return false; // Return false if doors are open
        }

        /// <summary>
        /// Stops the train and opens the doors.
        /// </summary>
        public void Stop()
        {
            ChangeSpeed(-Speed); // Set speed to 0
            DoorsOpen = true; // Open the doors
        }

        /// <summary>
        /// Closes the train doors.
        /// </summary>
        public void CloseDoors()
        {
            DoorsOpen = false; // Close the doors
        }

        /// <summary>
        /// Returns a string representation of the train's status.
        /// </summary>
        /// <returns>A formatted string containing speed, passengers, and door status.</returns>
        public string Status()
        {
            string doorsStatus = DoorsOpen ? "Open" : "Closed"; // Determine door status
            return $"Speed: {Speed}\nPassengers: {Passengers}\nDoors: {doorsStatus}";
        }

        /// <summary>
        /// Internal method to change the speed of the train.
        /// </summary>
        /// <param name="speedChange">The amount to change the speed by.</param>
        private void ChangeSpeed(int speedChange)
        {
            Speed += speedChange; // Adjust the speed
        }
    }
}