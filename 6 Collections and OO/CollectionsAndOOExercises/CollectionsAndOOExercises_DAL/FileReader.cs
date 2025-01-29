using CollectionsAndOOExercises_Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace CollectionsAndOOExercises_DAL
{
    public class FileReader
    {
        /// <summary>
        /// Reads trainee data from a file and returns a list of Trainee objects.
        /// </summary>
        /// <param name="filepath">The path to the file.</param>
        /// <returns>A list of Trainee objects.</returns>
        /// <exception cref="Exception">Thrown for errors.</exception> 
        public List<Trainee> ReadFile(string filepath)
        {
            List<Trainee> list = new List<Trainee>();

            try
            {
                // Open the file for reading
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    // Read the file line by line
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        // Split the line into fields
                        string[] data = line.Split(';');

                        // Create a new Trainee object and add it to the list
                        Trainee trainee = new Trainee(data[0], data[1]);
                        list.Add(trainee);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading file: {ex.Message}", ex);
            }

            return list;
        }
    }
}