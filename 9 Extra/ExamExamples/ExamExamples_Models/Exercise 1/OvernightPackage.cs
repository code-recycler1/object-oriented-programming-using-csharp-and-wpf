using System;

namespace ExamExamples_Models.Exercise_1
{
    public class OvernightPackage : Package
    {
        private double _surchargePerKg;
        public double SurchargePerKg
        {
            get => _surchargePerKg;
            set
            {
                if (value < 0)
                    throw new Exception("Surcharge per kg cannot be negative.");
                _surchargePerKg = value;
            }
        }

        // Constructor
        public OvernightPackage(string senderName, string senderAddress, string destinationName, string destinationAddress,
            double weight, double pricePerKg, double surchargePerKg) : base(senderName, senderAddress, destinationName,
                destinationAddress, weight, pricePerKg)
        {
            SurchargePerKg = surchargePerKg;
        }

        // Override ShippingCosts to include surcharge
        public override double ShippingCosts()
        {
            return (PricePerKg + SurchargePerKg) * Weight;
        }

        // Override CalculateShippingCosts to include surcharge
        public override string CalculateShippingCosts()
        {
            return $"({PricePerKg:0.00} + {SurchargePerKg:0.00}) x {Weight:0.00} = {ShippingCosts():0.00}";
        }
    }
}
