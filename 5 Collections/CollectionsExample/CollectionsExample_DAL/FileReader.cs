using System;
using System.Collections.Generic;
using System.IO;

namespace CollectionsExample_DAL
{
    public class FileReader
    {
        /// <summary>
        /// Reads integers from a file and returns them as a list.
        /// </summary>
        /// <param name="filePath">The path to the file to read.</param>
        /// <returns>A list of integers read from the file.</returns>
        /// <exception cref="Exception">Thrown if an error occurs.</exception>
        public List<int> ReadFile(string filePath)
        {
            List<int> numbers = new List<int>();

            try
            {
                // Read the file line by line
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Try to parse each line as an integer
                        if (int.TryParse(line, out int number))
                        {
                            numbers.Add(number);
                        }
                        else
                        {
                            // Log or handle invalid lines (optional)
                            Console.WriteLine($"Skipping invalid line: {line}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle I/O errors or other exceptions
                throw new Exception($"An error occurred while reading the file: {ex.Message}", ex);
            }

            return numbers;
        }
    }
}