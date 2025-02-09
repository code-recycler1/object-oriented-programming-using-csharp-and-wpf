using ExceptionHandlingExample_Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExceptionHandlingExample_DAL
{
    public class FileOperations
    {
        // Method to read users from a file
        public List<User> ReadFile(string filePath)
        {
            List<User> listOfUsers = new List<User>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        List<string> data = line.Split(';').ToList();

                        try
                        {
                            if (int.TryParse(data[1], out int number))
                            {
                                User user = null;

                                // Create the appropriate user based on the type
                                switch (data[0].ToLower())
                                {
                                    case "user":
                                        user = new User(number, data[2], data[3]);
                                        break;
                                    case "teacher":
                                        double.TryParse(data[4], out double salary);
                                        user = new Teacher(number, data[2], data[3], salary);
                                        break;
                                    case "student":
                                        bool.TryParse(data[4], out bool hasScholarship);
                                        user = new Student(number, data[2], data[3], hasScholarship);
                                        break;
                                }

                                // Add the user to the list if it doesn't already exist
                                if (user != null && !listOfUsers.Contains(user))
                                {
                                    listOfUsers.Add(user);
                                }
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            LogError(ex);
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

            return listOfUsers;
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
    }
}