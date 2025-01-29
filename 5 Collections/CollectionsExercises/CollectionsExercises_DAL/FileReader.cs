using System;
using System.Collections.Generic;
using System.IO;

namespace CollectionsExercises_DAL
{
    public class FileReader
    {
        /// <summary>
        /// Reads lines from a file and returns them as a list of strings.
        /// </summary>
        /// <param name="filepath">The path to the file.</param>
        /// <returns>A list of strings read from the file.</returns>
        /// <exception cref="Exception">Thrown if an error occurs.</exception>
        public List<string> ReadFileAsString(string filepath)
        {
            List<string> list = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    while (!reader.EndOfStream)
                    {
                        list.Add(reader.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading file: {ex.Message}", ex);
            }

            return list;
        }

        /// <summary>
        /// Reads lines from a file and returns them as a list of integers.
        /// </summary>
        /// <param name="filepath">The path to the file.</param>
        /// <returns>A list of integers read from the file.</returns>
        /// <exception cref="Exception">Thrown if an error occurs.</exception>
        public List<int> ReadFileAsInt(string filepath)
        {
            List<int> list = new List<int>();

            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    while (!reader.EndOfStream)
                    {
                        if (int.TryParse(reader.ReadLine(), out int number))
                        {
                            list.Add(number);
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