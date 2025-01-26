namespace OO_Exercises_Models
{
    public class Counter
    {
        // Private field to store the counter value
        private int _value;

        // Public property to get the counter value (set is private)
        public int Value
        {
            get
            {
                return _value;
            }
            private set
            {
                _value = value;
            }
        }

        // Constructor to initialize the counter to 0
        public Counter()
        {
            Value = 0;
        }

        // Method to increment the counter by 1
        public void Increment()
        {
            Value += 1;
        }

        // Method to decrement the counter by 1
        public void Decrement()
        {
            Value -= 1;
        }

        // Method to reset the counter to 0
        public void Reset()
        {
            Value = 0;
        }

        // Method to return a string representation of the counter value
        public string ShowData()
        {
            return $"Value of counter is {Value}";
        }
    }
}