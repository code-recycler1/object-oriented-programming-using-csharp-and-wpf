using System.Windows;
using InheritancePart1Exercises_Models.Exercise_1;

namespace InheritancePart1Exercises_WPF
{
    public partial class Exercise_1_Bank_Account : Window
    {
        // Declare instances of BankAccount, SavingsAccount, and CheckingAccount
        private BankAccount myBankAccount;
        private SavingsAccount mySavingsAccount;
        private CheckingAccount myCheckingAccount;

        public Exercise_1_Bank_Account()
        {
            InitializeComponent();
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialize the accounts with specific IBAN and balance
            myBankAccount = new BankAccount("BE 82 1796 3107 6768", 1000);
            mySavingsAccount = new SavingsAccount { IBAN = "BE35 3630 8305 1137", Percentage = 2.5 };
            myCheckingAccount = new CheckingAccount("BE27 2100 0000 2173", 20);

            // Display the initial data for each account
            lblBankAccount.Content = myBankAccount.ShowData();
            lblSavingsAccount.Content = mySavingsAccount.ShowData();
            lblCheckingAccount.Content = myCheckingAccount.ShowData();
        }

        // Event handler for depositing into the Bank Account
        private void btnBankAccountDeposit_Click(object sender, RoutedEventArgs e)
        {
            lblBankAccount.Content = Deposit(myBankAccount, txtBankAccount.Text);
        }

        // Event handler for withdrawing from the Bank Account
        private void btnBankAccountWithdraw_Click(object sender, RoutedEventArgs e)
        {
            lblBankAccount.Content = Withdraw(myBankAccount, txtBankAccount.Text);
        }

        // Event handler for depositing into the Savings Account
        private void btnSavingsAccountDeposit_Click(object sender, RoutedEventArgs e)
        {
            lblSavingsAccount.Content = Deposit(mySavingsAccount, txtSavingsAccount.Text);
        }

        // Event handler for withdrawing from the Savings Account
        private void btnSavingsAccountWithdraw_Click(object sender, RoutedEventArgs e)
        {
            lblSavingsAccount.Content = Withdraw(mySavingsAccount, txtSavingsAccount.Text);
        }

        // Event handler for adding interest to the Savings Account
        private void btnAddInterestRate_Click(object sender, RoutedEventArgs e)
        {
            mySavingsAccount.AddInterest();
            lblSavingsAccount.Content = mySavingsAccount.ShowData();
        }

        // Event handler for depositing into the Checking Account
        private void btnCheckingAccountDeposit_Click(object sender, RoutedEventArgs e)
        {
            lblCheckingAccount.Content = Deposit(myCheckingAccount, txtCheckingAccount.Text);
        }

        // Event handler for withdrawing from the Checking Account
        private void btnCheckingAccountWithdraw_Click(object sender, RoutedEventArgs e)
        {
            lblCheckingAccount.Content = Withdraw(myCheckingAccount, txtCheckingAccount.Text);
        }

        // Helper method to deposit money into an account
        private string Deposit(BankAccount bankAccount, string input)
        {
            if (double.TryParse(input, out double amount) && amount > 0)
            {
                bankAccount.Deposit(amount);
            }
            else
            {
                MessageBox.Show("Amount must be a positive numeric value!", "Error");
            }
            return bankAccount.ShowData();
        }

        // Helper method to withdraw money from an account
        private string Withdraw(BankAccount bankAccount, string input)
        {
            if (double.TryParse(input, out double amount) && amount > 0)
            {
                bankAccount.Withdraw(amount);
            }
            else
            {
                MessageBox.Show("Amount must be a positive numeric value!", "Error");
            }
            return bankAccount.ShowData();
        }
    }
}