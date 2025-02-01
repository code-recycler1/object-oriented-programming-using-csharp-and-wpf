namespace InheritancePart2Exercises_Models.Exercise_1
{
    public class SavingsAccount : BankAccount
    {
        // Property for interest rate
        public double Percentage { get; set; }

        // Constructor
        public SavingsAccount() : base("", 0)
        {
            Percentage = 0; // Default interest rate
        }

        // Method to add interest
        public void AddInterest()
        {
            double interestRate = Balance * Percentage / 100;
            Balance += interestRate;
        }

        // Override method to display account details
        public override string ShowData()
        {
            return $"{base.ShowData()} (Interest rate: {Percentage}%)";
        }
    }
}