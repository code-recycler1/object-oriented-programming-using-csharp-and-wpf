using System;

namespace ExceptionHandlingExercises_Models.Exercise_1
{
    public class BankAccount
    {
        // Properties for IBAN, balance, and minimum balance
        public string IBAN { get; set; }

        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value < Minimum)
                {
                    _balance = Minimum;
                    throw new CustomException($"Balance cannot be below the minimum {Minimum}!");
                }
                else
                {
                    _balance = value;
                }
            }
        }
        public double Minimum { get; set; }

        // Read-only property for country code
        public string CountryCode => IBAN.Substring(0, 2);

        // Constructor to initialize the account
        public BankAccount(string IBAN, double balance)
        {
            this.IBAN = IBAN;
            this.Balance = balance;
            this.Minimum = 0; // Default minimum balance
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            Balance += Math.Abs(amount); // Ensure amount is positive
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            double newBalance = Balance - Math.Abs(amount); // Ensure amount is positive
            if (newBalance < Minimum)
            {
                throw new CustomException($"Withdrawal failed: Balance cannot be below the minimum {Minimum}!");
            }
            Balance = newBalance;
        }

        // Override ToString to display account details
        public override string ToString()
        {
            return $"{IBAN} with balance {Balance:0.00}";
        }

        // Override Equals to compare accounts by IBAN
        public override bool Equals(object obj)
        {
            if (obj is BankAccount bankAccount)
            {
                return this.IBAN.Trim().Equals(bankAccount.IBAN.Trim());
            }
            return false;
        }
    }
}