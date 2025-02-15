using ExceptionHandlingExercises_DAL;
using ExceptionHandlingExercises_Models.Exercise_1;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ExceptionHandlingExercises_WPF
{
    public partial class Exercise_1_Bank_Account : Window
    {
        // List to store all bank accounts
        private List<BankAccount> listOfBankAccounts = new List<BankAccount>();

        public Exercise_1_Bank_Account()
        {
            InitializeComponent();
        }

        // Event handler for window load
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Load bank accounts from file and bind to ComboBox
            listOfBankAccounts = new FileOperations().ReadBankAccountsFile("doc\\bankAccounts.txt");
            cmbBankAccount.ItemsSource = listOfBankAccounts;

            // Set the default radio button to "Bank Account"
            rbBankAccount.IsChecked = true;
        }

        // Event handler for "Add Account" button
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validate IBAN input
                if (!string.IsNullOrWhiteSpace(txtIBAN.Text))
                {
                    BankAccount bankAccount = null;

                    // Create the appropriate account based on the selected radio button
                    if (rbBankAccount.IsChecked == true)
                    {
                        bankAccount = new BankAccount(txtIBAN.Text, 0);
                    }
                    else if (rbSavingsAccount.IsChecked == true)
                    {
                        bankAccount = new SavingsAccount { IBAN = txtIBAN.Text };
                    }
                    else
                    {
                        bankAccount = new CheckingAccount(txtIBAN.Text, 0);
                    }

                    // Check if the account already exists in the list
                    if (!listOfBankAccounts.Contains(bankAccount))
                    {
                        // Add the account to the list and refresh the ComboBox
                        listOfBankAccounts.Add(bankAccount);
                        cmbBankAccount.Items.Refresh();
                    }
                    else
                    {
                        MessageBox.Show($"This IBAN already exists: {bankAccount.IBAN}", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an IBAN.", "Error");
                }
            }
            catch (CustomException ex)
            {
                // Log the error and show a message to the user
                MessageBox.Show($"This account cannot be created: {ex.Message}", "Error");
            }
        }

        // Event handler for ComboBox selection change
        private void cmbBankAccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Display the selected account's details in the label
            if (cmbBankAccount.SelectedItem is BankAccount bankAccount)
            {
                lblBankAccount.Content = bankAccount.ToString();
            }
        }

        // Event handler for "Deposit" button
        private void btnBankAccountDeposit_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBankAccount.SelectedItem is BankAccount bankAccount)
            {
                if (double.TryParse(txtBalance.Text, out double balance) && balance > 0)
                {
                    // Deposit the amount into the selected account
                    bankAccount.Deposit(balance);
                    lblBankAccount.Content = bankAccount.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive number for deposit.", "Error");
                }
            }
        }

        // Event handler for "Withdraw" button
        private void btnBankAccountWithdraw_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbBankAccount.SelectedItem is BankAccount bankAccount)
                {
                    if (double.TryParse(txtBalance.Text, out double balance) && balance > 0)
                    {
                        // Withdraw the amount from the selected account
                        bankAccount.Withdraw(balance);
                        lblBankAccount.Content = bankAccount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid positive number for withdrawal.", "Error");
                    }
                }
            }
            catch (CustomException ex)
            {
                // Show an error message if the withdrawal is not allowed
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Event handler for "Interest" button
        private void btnAddInterestRate_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBankAccount.SelectedItem is SavingsAccount savingsAccount)
            {
                // Add interest to the selected savings account
                savingsAccount.AddInterest();
                lblBankAccount.Content = savingsAccount.ToString();
            }
            else
            {
                MessageBox.Show("Please select a savings account to add interest.", "Error");
            }
        }
    }
}