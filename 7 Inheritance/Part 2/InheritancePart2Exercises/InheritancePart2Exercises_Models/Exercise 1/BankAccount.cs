using System;

namespace InheritancePart2Exercises_Models.Exercise_1
{
    public class BankAccount
    {
        // Properties
        public string IBAN { get; set; }
        public double Balance { get; set; }
        public double Minimum { get; set; }

        // Read-only property for country code
        public string CountryCode => IBAN.Substring(0, 2);

        // Constructor
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

        // Method to display account details
        public virtual string ShowData()
        {
            return $"{IBAN} with balance {Balance:0.00}";
        }
    }
}