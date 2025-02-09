using InheritancePart3Exercises_Models.Exercise_1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace InheritancePart3Exercises_DAL
{
    public class FileReader
    {
        // Method to read bank accounts from a file
        public List<BankAccount> ReadFile(string filePath)
        {
            List<BankAccount> list = new List<BankAccount>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        List<string> data = line.Split(';').ToList();

                        if (double.TryParse(data[2], out double balance))
                        {
                            BankAccount bankAccount = null;

                            // Create the appropriate account based on the type
                            switch (data[0])
                            {
                                case "bank account":
                                    bankAccount = new BankAccount(data[1], balance);
                                    break;
                                case "savings account":
                                    bankAccount = new SavingsAccount { IBAN = data[1], Balance = balance };
                                    if (double.TryParse(data[3], out double percent))
                                    {
                                        ((SavingsAccount)bankAccount).Percentage = percent;
                                    }
                                    break;
                                case "checking account":
                                    bankAccount = new CheckingAccount(data[1], balance);
                                    break;
                            }

                            if (bankAccount != null)
                            {
                                list.Add(bankAccount);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return list;
        }
    }
}