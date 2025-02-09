namespace InheritancePart3Exercises_Models.Exercise_1
{
    public class SavingsAccount : BankAccount
    {
        // Property for interest rate
        public double Percentage { get; set; }

        // Constructor to initialize the savings account
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

        // Override ToString to display savings account details
        public override string ToString()
        {
            return $"{base.ToString()} (Interest rate: {Percentage}%)";
        }
    }
}