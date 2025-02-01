namespace InheritancePart2Exercises_Models.Exercise_1
{
    public class CheckingAccount : BankAccount
    {
        // Constructor
        public CheckingAccount(string IBAN, double balance) : base(IBAN, balance)
        {
            this.Minimum = -100; // Override minimum balance for checking accounts
        }
    }
}