namespace InheritancePart1Exercises_Models.Exercise_1
{
    public class CheckingAccount : BankAccount
    {
        // Parameterized constructor with a minimum balance of -100
        public CheckingAccount(string IBAN, double balance) : base(IBAN, balance)
        {
            this.Minimum = -100;
        }

        // Override method to display checking account data
        public override string ShowData()
        {
            return $"{base.ShowData()} (Minimum: {Minimum})";
        }
    }
}
