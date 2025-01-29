using CollectionsExercises_DAL;
using System;
using System.Collections.Generic;
using System.Windows;

namespace CollectionsExercises_WPF
{
    public partial class Exercise_3_Students_with_Results : Window
    {
        // List to store student names
        private List<string> listOfStudents = new List<string>();

        // List to store student grades
        private List<int> listOfGrades = new List<int>();

        // List to display data in the ListBox
        private List<string> listView = new List<string>();

        public Exercise_3_Students_with_Results()
        {
            InitializeComponent();
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Bind the listView to the ListBox
            lbStudentsWithResult.ItemsSource = listView;
        }

        // Event handler for the "Read Students and Print" button
        private void btnReadStudents_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Clear the list of students and the display list
                listOfStudents.Clear();
                listView.Clear();

                // Read students from the file
                FileReader fileReader = new FileReader();
                listOfStudents = fileReader.ReadFileAsString("doc\\students.txt");

                // Add students to the display list
                listView.AddRange(listOfStudents);

                // Refresh the ListBox
                lbStudentsWithResult.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading students: {ex.Message}", "Error");
            }
        }

        // Event handler for the "Read Grades and Print" button
        private void btnReadGrades_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Clear the list of grades
                listOfGrades.Clear();

                // Read grades from the file
                FileReader fileReader = new FileReader();
                listOfGrades = fileReader.ReadFileAsInt("doc\\grades.txt");

                // Add grades to the display list
                listView.AddRange(listOfGrades.ConvertAll<string>(x => x.ToString()));

                // Refresh the ListBox
                lbStudentsWithResult.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading grades: {ex.Message}", "Error");
            }
        }

        // Event handler for the "Determine Results and Print" button
        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            // Check if both students and grades have been read
            if (listOfStudents.Count > 0 && listOfGrades.Count > 0 && listOfStudents.Count == listOfGrades.Count)
            {
                // Clear the display list
                listView.Clear();

                int numberPassed = 0;
                int numberFailed = 0;

                // Determine results for each student
                for (int i = 0; i < listOfStudents.Count; i++)
                {
                    string result = (listOfGrades[i] >= 50) ? "Passed" : "Failed";
                    if (result == "Passed") numberPassed++;
                    else numberFailed++;

                    // Add the result to the display list
                    listView.Add($"{listOfStudents[i].PadRight(15)}{listOfGrades[i].ToString().PadLeft(5)}{"".PadLeft(5)}{result}");
                }

                // Add summary to the display list
                listView.Add($"Number passed: {numberPassed}");
                listView.Add($"Number failed: {numberFailed}");

                // Refresh the ListBox
                lbStudentsWithResult.Items.Refresh();
            }
            else
            {
                MessageBox.Show("First read students and grades, and ensure they match in count!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for the "Clear" button
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            // Clear all lists
            listOfStudents.Clear();
            listOfGrades.Clear();
            listView.Clear();

            // Refresh the ListBox
            lbStudentsWithResult.Items.Refresh();
        }

        // Event handler for the "Close" button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}