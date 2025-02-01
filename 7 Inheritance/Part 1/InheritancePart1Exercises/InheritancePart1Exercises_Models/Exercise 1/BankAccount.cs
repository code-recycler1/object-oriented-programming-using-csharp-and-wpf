using System;

namespace InheritancePart1Exercises_Models.Exercise_1
{
    public class BankAccount
    {
        // Private fields for IBAN, balance, and minimum balance
        private string _IBAN;
        private double _balance;
        private double _minimum;

        // Public properties for minimum balance, balance, and IBAN
        public double Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set
            {
                // Ensure the balance does not go below the minimum
                if (value < Minimum)
                {
                    _balance = Minimum;
                }
                else
                {
                    _balance = value;
                }
            }
        }

        public string IBAN
        {
            get { return _IBAN; }
            set { _IBAN = value; }
        }

        // Read-only property to get the country code from the IBAN
        public string CountryCode
        {
            get { return IBAN.Substring(0, 2); }
        }

        // Parameterized constructor
        public BankAccount(string IBAN, double balance)
        {
            this.IBAN = IBAN;
            this.Balance = balance;
            this.Minimum = 0;
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            Balance += Math.Abs(amount);
        }

        // Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            Balance -= Math.Abs(amount);
        }

        // Virtual method to display account data
        public virtual string ShowData()
        {
            return $"{IBAN} with balance {Balance}";
        }
    }
}
