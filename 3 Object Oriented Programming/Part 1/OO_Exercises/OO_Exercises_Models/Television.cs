namespace OO_Exercises_Models
{
    public class Television
    {
        // Private fields to store the channel and volume
        private int _channel;
        private int _volume;

        // Property for the channel with validation
        private int Channel
        {
            get { return _channel; }
            set
            {
                // Ensure the channel is within the valid range (0 to 30)
                if (value >= 0 && value <= 30)
                {
                    _channel = value;
                }
            }
        }

        // Property for the volume with validation
        private int Volume
        {
            get { return _volume; }
            set
            {
                // Ensure the volume is within the valid range (0 to 10)
                if (value >= 0 && value <= 10)
                {
                    _volume = value;
                }
            }
        }

        // Constructor to initialize the TV with default values
        public Television()
        {
            Channel = 0;
            Volume = 0;
        }

        // Method to increase the channel by 1
        public void ChangeChannelUp()
        {
            Channel += 1;
        }

        // Method to decrease the channel by 1
        public void ChangeChannelDown()
        {
            Channel -= 1;
        }

        // Method to increase the volume by 1
        public void IncreaseVolume()
        {
            Volume += 1;
        }

        // Method to decrease the volume by 1
        public void DecreaseVolume()
        {
            Volume -= 1;
        }

        // Method to return a string representation of the TV status
        public string ShowData()
        {
            return $"Channel: {Channel} - Volume: {Volume}";
        }
    }
}