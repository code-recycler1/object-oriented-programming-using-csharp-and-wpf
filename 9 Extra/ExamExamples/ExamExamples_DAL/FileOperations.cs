using ExamExamples_Models.Exercise_1;
using ExamExamples_Models.Exercise_2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExamExamples_DAL
{
    public class FileOperations
    {
        // Method to read packages from a file
        public List<Package> ReadParcelService(string filePath)
        {
            List<Package> packageList = new List<Package>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        List<string> data = line.Split(';').ToList();

                        if (double.TryParse(data[5], out double weight) &&
                            double.TryParse(data[6], out double price) &&
                            double.TryParse(data[7], out double extra))
                        {
                            Package package = null;

                            if (data[0].ToLower() == "twoday")
                            {
                                package = new TwodayPackage(data[1], data[2], data[3], data[4], weight, price, extra);
                            }
                            else if (data[0].ToLower() == "overnight")
                            {
                                package = new OvernightPackage(data[1], data[2], data[3], data[4], weight, price, extra);
                            }

                            if (package != null)
                            {
                                packageList.Add(package);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                LogErrors(exception);
                throw new Exception("Error reading file.", exception);
            }

            return packageList;
        }

        // Method to read dishes from a file
        public List<Dish> ReadDishes(string filePath)
        {
            List<Dish> dishes = new List<Dish>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        List<string> data = line.Split(';').ToList();

                        if (double.TryParse(data[1], out double price))
                        {
                            Dish dish = new Dish(data[2], data[0], price);
                            dishes.Add(dish);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                LogErrors(exception);
                throw new Exception("Error reading file.", exception);
            }

            return dishes;
        }

        // Method to log errors to a file
        public void LogErrors(Exception error)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("errorlog.txt", true))
                {
                    writer.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));
                    writer.WriteLine(error.GetType().Name);
                    writer.WriteLine(error.Message);
                    writer.WriteLine(error.StackTrace);
                    writer.WriteLine(new string('-', 80));
                }
            }
            catch
            {
                // If logging fails, ignore to avoid crashing the application
            }
        }
    }
}
