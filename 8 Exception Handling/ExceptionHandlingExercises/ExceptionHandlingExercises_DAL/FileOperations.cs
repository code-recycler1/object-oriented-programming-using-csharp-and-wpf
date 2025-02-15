using ExceptionHandlingExercises_Models.Exercise_1;
using ExceptionHandlingExercises_Models.Exercise_2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExceptionHandlingExercises_DAL
{
    public class FileOperations
    {
        // Method to read bank accounts from a file
        public List<BankAccount> ReadBankAccountsFile(string filePath)
        {
            List<BankAccount> list = new List<BankAccount>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        try
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

                                // Add the account to the list if it doesn't already exist
                                if (bankAccount != null && !list.Contains(bankAccount))
                                {
                                    list.Add(bankAccount);
                                }
                            }
                        }
                        catch (CustomException ex)
                        {
                            LogError(ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                return null;
            }

            return list;
        }

        // Method to read customer data from a file
        public List<Customer> ReadCustomersFile(string filePath)
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                // Read the file line by line
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        // Split each line into parts
                        string[] data = reader.ReadLine().Split(';');
                        if (int.TryParse(data[0], out int customerNumber))
                        {
                            // Create a new Customer object and add it to the list
                            Customer customer = new Customer(customerNumber, data[1], data[2], data[3], data[4]);
                            if (!customers.Contains(customer))
                            {
                                customers.Add(customer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                return null;
            }

            return customers;
        }

        // Method to log errors to a file
        public void LogError(Exception error)
        {
            using (StreamWriter writer = new StreamWriter("errorlog.txt", true))
            {
                writer.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));
                writer.WriteLine(error.GetType().Name);
                writer.WriteLine(error.Message);
                writer.WriteLine(error.StackTrace);
                writer.WriteLine(new String('-', 80));
                writer.WriteLine();
            }
        }

        // Method to find a customer by their number
        public Customer FindCustomerByNumber(int customerNumber)
        {
            // Read the customer data from the file
            List<Customer> customers = ReadCustomersFile("doc\\customers.txt");

            // Search for the customer by number
            foreach (Customer customer in customers)
            {
                if (customer.CustomerNumber == customerNumber)
                {
                    return customer;
                }
            }

            // Throw an exception if the customer is not found
            throw new CustomerNotFoundException(customerNumber);
        }
    }
}