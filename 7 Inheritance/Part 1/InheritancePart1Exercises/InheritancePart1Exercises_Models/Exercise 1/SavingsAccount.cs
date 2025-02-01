namespace InheritancePart1Exercises_Models.Exercise_1
{
    public class SavingsAccount : BankAccount
    {
        // Private field for interest rate percentage
        private double _percentage;

        // Public property for interest rate percentage
        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        // Default constructor
        public SavingsAccount() : base("", 0)
        {
            Percentage = 0;
        }

        // Method to add interest to the balance
        public void AddInterest()
        {
            double interestRate = Balance * Percentage / 100;
            Balance += interestRate;
        }

        // Override method to display savings account data
        public override string ShowData()
        {
            return $"{base.ShowData()} (Interest rate: {Percentage}%)";
        }
    }
}
