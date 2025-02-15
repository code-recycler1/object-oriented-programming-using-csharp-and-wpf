using System;

namespace ExamExamples_Models.Exercise_1
{
    public class TwodayPackage : Package
    {
        private double _fixedCost;
        public double FixedCost
        {
            get => _fixedCost;
            set
            {
                if (value < 0)
                    throw new Exception("Fixed cost cannot be negative.");
                _fixedCost = value;
            }
        }

        // Constructor
        public TwodayPackage(string senderName, string senderAddress, string destinationName, string destinationAddress,
            double weight, double pricePerKg, double fixedCost) : base(senderName, senderAddress, destinationName,
                destinationAddress, weight, pricePerKg)
        {
            FixedCost = fixedCost;
        }

        // Override ShippingCosts to include fixed cost
        public override double ShippingCosts()
        {
            return base.ShippingCosts() + FixedCost;
        }

        // Override CalculateShippingCosts to include fixed cost
        public override string CalculateShippingCosts()
        {
            return $"{Weight:0.00} x {PricePerKg:0.00} + {FixedCost:0.00} = {ShippingCosts():0.00}";
        }
    }
}
