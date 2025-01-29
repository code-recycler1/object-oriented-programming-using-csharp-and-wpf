using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using CollectionsAndOOExercises_DAL;
using CollectionsAndOOExercises_Models;

namespace CollectionsAndOOExercises_WPF
{
    public partial class Exercise_2_Trainee : Window
    {
        // List to store the trainees
        private List<Trainee> listOfTrainees = new List<Trainee>();

        public Exercise_2_Trainee()
        {
            InitializeComponent();
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Read the list of trainees from the file
                FileReader fileReader = new FileReader();
                listOfTrainees = fileReader.ReadFile("doc\\trainees.txt");

                // Bind the list to the ListBox
                lbTrainees.ItemsSource = listOfTrainees;

                // Set the display path to show the full name of the trainee
                lbTrainees.DisplayMemberPath = "FullName";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error");
            }
        }

        // Event handler for when the selection in the ListBox changes
        private void lbTrainees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbTrainees.SelectedItem is Trainee trainee)
            {
                // Populate the text boxes with the selected trainee's details
                txtFirstName.Text = trainee.FirstName;
                txtLastName.Text = trainee.LastName;
            }
        }

        // Event handler for the "Add" button
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter a first name and a last name.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            // Add the new trainee to the list
            AddTrainee(txtFirstName.Text, txtLastName.Text);

            // Clear input fields and set focus to the first name field
            ClearInputFields();
            txtFirstName.Focus();
        }

        // Event handler for the "Delete" button
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbTrainees.SelectedItem is Trainee trainee)
            {
                // Confirm deletion with the user
                if (MessageBox.Show($"Are you sure you want to delete: {trainee.FullName}?", "Delete Trainee", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    // Remove the selected trainee from the list
                    listOfTrainees.Remove(trainee);

                    // Refresh the ListBox
                    lbTrainees.Items.Refresh();

                    // Clear input fields
                    ClearInputFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a trainee to delete.", "Error", MessageBoxButton.OK);
            }
        }

        // Event handler for the "Update" button
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (lbTrainees.SelectedItem is Trainee trainee)
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Please enter a first name and a last name.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                // Update the selected trainee's details
                trainee.FirstName = txtFirstName.Text;
                trainee.LastName = txtLastName.Text;

                // Refresh the ListBox
                lbTrainees.Items.Refresh();

                // Clear input fields
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please select a trainee to update.", "Error", MessageBoxButton.OK);
            }
        }

        // Event handler for the "Close" button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Helper method to add a new trainee
        private void AddTrainee(string firstName, string lastName)
        {
            Trainee newTrainee = new Trainee(firstName, lastName);
            listOfTrainees.Add(newTrainee);

            // Refresh the ListBox
            lbTrainees.Items.Refresh();
        }

        // Method to clear input fields
        private void ClearInputFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }
    }
}