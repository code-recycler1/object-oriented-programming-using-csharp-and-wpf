using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CollectionsAndOOExample_Models;

namespace CollectionsAndOOExample_DAL
{
    public class FileReader
    {
        /// <summary>
        /// Reads student data from a file and returns a list of ResultStudent objects.
        /// </summary>
        /// <param name="filepath">The path to the file.</param>
        /// <returns>A list of ResultStudent objects.</returns>
        public List<ResultStudent> ReadFile(string filepath)
        {
            List<ResultStudent> list = new List<ResultStudent>();

            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();

                        // Split the line into name and grades
                        List<string> data = line.Split(';').ToList();

                        if (double.TryParse(data[1], out double number))
                        {
                            // Create a new ResultStudent object and add it to the list
                            ResultStudent rs = new ResultStudent(data[0], number);
                            list.Add(rs);
                        }
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