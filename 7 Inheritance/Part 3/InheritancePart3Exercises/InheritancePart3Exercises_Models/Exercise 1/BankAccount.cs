using System;

namespace InheritancePart3Exercises_Models.Exercise_1
{
    public class BankAccount
    {
        // Properties for IBAN, balance, and minimum balance
        public string IBAN { get; set; }
        public double Balance { get; set; }
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
            Balance -= Math.Abs(amount); // Ensure amount is positive
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