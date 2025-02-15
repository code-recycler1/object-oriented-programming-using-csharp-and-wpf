using System;

namespace ExamExamples_Models.Exercise_1
{
    public class Package
    {
        // Properties
        public string SenderName { get; set; }
        public string SenderAddress { get; set; }
        public string DestinationName { get; set; }
        public string DestinationAddress { get; set; }

        private double _weight;
        public double Weight
        {
            get => _weight;
            set
            {
                if (value < 0)
                    throw new Exception("Weight cannot be negative.");
                _weight = value;
            }
        }

        private double _pricePerKg;
        public double PricePerKg
        {
            get => _pricePerKg;
            set
            {
                if (value < 0)
                    throw new Exception("Price per kg cannot be negative.");
                _pricePerKg = value;
            }
        }

        // Constructor
        public Package(string senderName, string senderAddress, string destinationName, string destinationAddress,
            double weight, double pricePerKg)
        {
            SenderName = senderName;
            SenderAddress = senderAddress;
            DestinationName = destinationName;
            DestinationAddress = destinationAddress;
            Weight = weight;
            PricePerKg = pricePerKg;
        }

        // Method to calculate shipping costs
        public virtual double ShippingCosts()
        {
            return Weight * PricePerKg;
        }

        // Method to display shipping cost calculation
        public virtual string CalculateShippingCosts()
        {
            return $"{Weight:0.00} x {PricePerKg:0.00} = {ShippingCosts():0.00}";
        }

        // Override ToString to display package details
        public override string ToString()
        {
            return $"Shipment Details:\n" +
                   $"Sender: {SenderName}, {SenderAddress}\n" +
                   $"Destination: {DestinationName}, {DestinationAddress}\n" +
                   $"Weight: {Weight:0.00} kg\n" +
                   $"Total Cost: {CalculateShippingCosts()}";
        }
    }
}
