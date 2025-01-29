using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using CollectionsAndOOExample_DAL;
using CollectionsAndOOExample_Models;

namespace CollectionsAndOOExample_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // List to store the results of students
        private List<ResultStudent> listOfResults = new List<ResultStudent>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Read the list of students and their grades from the file
                FileReader fileReader = new FileReader();
                listOfResults = fileReader.ReadFile("doc\\studentAndGrade.txt");

                // Bind the list to the ListBox
                lstResult.ItemsSource = listOfResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error");
            }
        }

        // Event handler for when the selection in the ListBox changes
        private void lstResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstResult.SelectedItem is ResultStudent student)
            {
                // Display the selected student's name and grades in the TextBoxes
                txtName.Text = student.Name;
                txtGrades.Text = student.Grades.ToString();
            }
        }

        // Event handler for the "Update" button
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (lstResult.SelectedItem is ResultStudent student)
            {
                if (double.TryParse(txtGrades.Text, out double number))
                {
                    // Update the selected student's name and grades
                    student.Name = txtName.Text;
                    student.Grades = number;

                    // Refresh the ListBox to reflect the changes
                    lstResult.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Please enter a valid grade.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Error");
            }
        }

        // Event handler for the "Delete" button
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstResult.SelectedItem is ResultStudent student)
            {
                // Remove the selected student from the list
                listOfResults.Remove(student);

                // Refresh the ListBox to reflect the changes
                lstResult.Items.Refresh();

                // Clear the TextBoxes
                txtName.Clear();
                txtGrades.Text = "";
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Error");
            }
        }
    }
}
