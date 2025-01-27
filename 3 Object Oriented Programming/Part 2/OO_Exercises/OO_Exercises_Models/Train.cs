using System;

namespace OO_Exercises_Models
{
    public class Train
    {
        // Private fields to store train data
        private bool _doorsOpen;
        private int _passengers;
        private int _speed;

        // Property for Passengers with validation
        public int Passengers
        {
            get { return _passengers; }
            private set
            {
                if (value < 0)
                {
                    _passengers = 0; // Ensure passengers cannot be negative
                }
                else
                {
                    _passengers = value;
                }
            }
        }

        // Property for Speed with validation
        public int Speed
        {
            get { return _speed; }
            private set
            {
                if (value > 120)
                {
                    _speed = 120; // Ensure speed does not exceed 120
                }
                else if (value < 0)
                {
                    _speed = 0; // Ensure speed cannot be negative
                }
                else
                {
                    _speed = value;
                }
            }
        }

        // Property for DoorsOpen
        public bool DoorsOpen
        {
            get { return _doorsOpen; }
            private set { _doorsOpen = value; }
        }

        // Default constructor
        public Train()
        {
            Passengers = 0; // Initialize passengers to 0
            DoorsOpen = true; // Initialize doors to open
        }

        // Method to disembark passengers
        public bool Disembark(int numberOfPersons)
        {
            if (DoorsOpen) // Check if doors are open
            {
                Passengers -= Math.Abs(numberOfPersons); // Decrease passengers
                return true;
            }
            return false; // Return false if doors are closed
        }

        // Method to embark passengers
        public bool Embark(int numberOfPersons)
        {
            if (DoorsOpen) // Check if doors are open
            {
                Passengers += Math.Abs(numberOfPersons); // Increase passengers
                return true;
            }
            return false; // Return false if doors are closed
        }

        // Method to decelerate the train
        public void Decelerate(int deceleration)
        {
            ChangeSpeed(Math.Abs(deceleration) * -1); // Decrease speed
        }

        // Method to accelerate the train
        public bool Accelerate(int acceleration)
        {
            if (!DoorsOpen) // Check if doors are closed
            {
                ChangeSpeed(Math.Abs(acceleration)); // Increase speed
                return true;
            }
            return false; // Return false if doors are open
        }

        // Method to stop the train
        public void Stop()
        {
            ChangeSpeed(Speed * -1); // Set speed to 0
            DoorsOpen = true; // Open the doors
        }

        // Method to close the doors
        public void CloseDoors()
        {
            DoorsOpen = false; // Close the doors
        }

        // Method to get the train's status as a string
        public string Status()
        {
            string doorsStatus = DoorsOpen ? "Open" : "Closed"; // Determine door status
            return $"Speed: {Speed:0.00}\nPassengers: {Passengers}\nDoors: {doorsStatus}";
        }

        // Internal method to change the speed
        private void ChangeSpeed(int speedChange)
        {
            Speed += speedChange; // Adjust the speed
        }
    }
}