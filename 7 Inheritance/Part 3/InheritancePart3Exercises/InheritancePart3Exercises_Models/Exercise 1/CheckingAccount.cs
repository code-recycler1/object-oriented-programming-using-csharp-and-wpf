namespace InheritancePart3Exercises_Models.Exercise_1
{
    public class CheckingAccount : BankAccount
    {
        // Constructor to initialize the checking account
        public CheckingAccount(string IBAN, double balance) : base(IBAN, balance)
        {
            this.Minimum = -100; // Override minimum balance for checking accounts
        }

        // Override ToString to display checking account details
        public override string ToString()
        {
            return $"{base.ToString()} (Minimum {Minimum})";
        }
    }
}