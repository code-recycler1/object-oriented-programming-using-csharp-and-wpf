using CollectionsExercises_DAL;
using System;
using System.Collections.Generic;
using System.Windows;

namespace CollectionsExercises_WPF
{
    public partial class Exercise_2_Prime_Minister : Window
    {
        // List to store the names of ministers
        private List<string> listOfMinisters = new List<string>();

        // List to store the number of votes for each minister
        private List<int> listOfVotes = new List<int>();

        public Exercise_2_Prime_Minister()
        {
            InitializeComponent();
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Read the list of ministers from the file
                FileReader fileReader = new FileReader();
                listOfMinisters = fileReader.ReadFileAsString("doc\\ministers.txt");

                // Initialize the list of votes with zeros
                foreach (var item in listOfMinisters)
                {
                    listOfVotes.Add(0);
                }

                // Bind the list of ministers to the ComboBox
                cmbMinisters.ItemsSource = listOfMinisters;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ministers: {ex.Message}", "Error");
            }
        }

        // Event handler for the "Outcome" button
        private void btnOutcome_Click(object sender, RoutedEventArgs e)
        {
            // Clear the label content
            lblResult.Content = "";

            // Display the voting results
            for (int i = 0; i < listOfMinisters.Count; i++)
            {
                lblResult.Content += $"{listOfMinisters[i]}: {listOfVotes[i]} votes{Environment.NewLine}";
            }
        }

        // Event handler for the "Vote" button
        private void btnVote_Click(object sender, RoutedEventArgs e)
        {
            // Check if a minister is selected
            if (cmbMinisters.SelectedIndex >= 0)
            {
                // Increment the vote count for the selected minister
                listOfVotes[cmbMinisters.SelectedIndex] += 1;
                MessageBox.Show("Vote recorded!", "Success");
            }
            else
            {
                MessageBox.Show("Please select a minister first!", "Error");
            }
        }

        // Event handler for the "Close" button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}