using InheritancePart2Exercises_DAL;
using InheritancePart2Exercises_Models.Exercise_1;
using System;
using System.Windows;
using System.Windows.Controls;

namespace InheritancePart2Exercises_WPF
{
    public partial class Exercise_1_Bank_Account : Window
    {
        public Exercise_1_Bank_Account()
        {
            InitializeComponent();
        }

        // Event handler for window load
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Read bank accounts from file and populate the ComboBox
                cmbBankAccount.ItemsSource = new FileReader().ReadFile("doc\\bankAccounts.txt");
                cmbBankAccount.DisplayMemberPath = "IBAN";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bank accounts: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for ComboBox selection change
        private void cmbBankAccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbBankAccount.SelectedItem is BankAccount bankAccount)
            {
                // Display the selected account's details
                lblBankAccount.Content = bankAccount.ShowData();
            }
        }

        // Event handler for deposit button
        private void btnBankAccountDeposit_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBankAccount.SelectedItem is BankAccount bankAccount)
            {
                if (double.TryParse(txtBalance.Text, out double balance) && balance > 0)
                {
                    // Deposit the amount into the selected account
                    bankAccount.Deposit(balance);
                    lblBankAccount.Content = bankAccount.ShowData();
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive number for deposit.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        // Event handler for withdraw button
        private void btnBankAccountWithdraw_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBankAccount.SelectedItem is BankAccount bankAccount)
            {
                if (double.TryParse(txtBalance.Text, out double balance) && balance > 0)
                {
                    // Withdraw the amount from the selected account
                    bankAccount.Withdraw(balance);
                    lblBankAccount.Content = bankAccount.ShowData();
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive number for withdrawal.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        // Event handler for interest button
        private void btnAddInterestRate_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBankAccount.SelectedItem is SavingsAccount savingsAccount)
            {
                // Add interest to the selected savings account
                savingsAccount.AddInterest();
                lblBankAccount.Content = savingsAccount.ShowData();
            }
            else
            {
                MessageBox.Show("Please select a savings account to add interest.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}