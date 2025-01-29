namespace CollectionsAndOOExercises_Models
{
    public class TelevisionChannel
    {
        // Private fields for channel number and description
        private int _number;
        private string _description;

        // Public properties for channel number and description
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        // Default constructor
        public TelevisionChannel() : this(0, "") { }

        // Parameterized constructor
        public TelevisionChannel(int number, string description)
        {
            this.Number = number;
            this.Description = description;
        }

        // Override ToString method to display channel details
        public override string ToString()
        {
            return $"{Number} - {Description}";
        }
    }
}