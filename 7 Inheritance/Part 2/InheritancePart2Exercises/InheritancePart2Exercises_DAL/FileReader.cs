using InheritancePart2Exercises_Models.Exercise_1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InheritancePart2Exercises_DAL
{
    public class FileReader
    {
        /// <summary>
        /// Reads bank account data from a file and returns a list of BankAccount objects.
        /// </summary>
        /// <param name="filePath">The path to the file containing bank account data.</param>
        /// <returns>A list of BankAccount objects.</returns>
        /// <exception cref="Exception">Throws an exception if there is an error reading the file.</exception>
        public List<BankAccount> ReadFile(string filePath)
        {
            // Create a list to store the bank accounts
            List<BankAccount> list = new List<BankAccount>();

            try
            {
                // Open the file for reading using a StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read the file line by line until the end of the file
                    while (!reader.EndOfStream)
                    {
                        // Read the current line from the file
                        string line = reader.ReadLine();

                        // Split the line into parts using ';' as the delimiter
                        List<string> data = line.Split(';').ToList();

                        // Try to parse the balance (third field in the line) as a double
                        if (double.TryParse(data[2], out double balance))
                        {
                            // Create a variable to hold the bank account object
                            BankAccount bankAccount = null;

                            // Determine the type of account based on the first field in the line
                            switch (data[0])
                            {
                                case "bank account":
                                    // Create a basic BankAccount object
                                    bankAccount = new BankAccount(data[1], balance);
                                    break;

                                case "savings account":
                                    // Create a SavingsAccount object
                                    bankAccount = new SavingsAccount { IBAN = data[1], Balance = balance };

                                    // Try to parse the interest rate (fourth field in the line) as a double
                                    if (double.TryParse(data[3], out double percent))
                                    {
                                        // Set the interest rate for the savings account
                                        ((SavingsAccount)bankAccount).Percentage = percent;
                                    }
                                    break;

                                case "checking account":
                                    // Create a CheckingAccount object
                                    bankAccount = new CheckingAccount(data[1], balance);
                                    break;
                            }

                            // If a valid bank account object was created, add it to the list
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
                // If an error occurs, throw an exception with a descriptive message
                throw new Exception($"Error reading file: {ex.Message}", ex);
            }

            // Return the list of bank accounts
            return list;
        }
    }
}