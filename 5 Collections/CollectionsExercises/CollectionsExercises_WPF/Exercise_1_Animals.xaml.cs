using CollectionsExercises_DAL;
using System;
using System.Collections.Generic;
using System.Windows;

namespace CollectionsExercises_WPF
{
    public partial class Exercise_1_Animals : Window
    {
        // List to store animals
        private List<string> listOfAnimals = new List<string>();

        public Exercise_1_Animals()
        {
            InitializeComponent();
        }

        // Read animals from a file and display them in the ListBox
        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listOfAnimals.Clear();
                FileReader fileReader = new FileReader();
                listOfAnimals = fileReader.ReadFileAsString("doc\\animals.txt");

                // Bind the list to the ListBox
                lbAnimals.ItemsSource = listOfAnimals;
                lbAnimals.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }

        // Add a new animal to the list
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string newAnimal = txtAnimal.Text.Trim();

            if (!string.IsNullOrEmpty(newAnimal))
            {
                if (!listOfAnimals.Contains(newAnimal))
                {
                    listOfAnimals.Add(newAnimal);
                    lbAnimals.Items.Refresh();
                    txtAnimal.Clear(); // Clear the input field
                }
                else
                {
                    MessageBox.Show("This animal already exists.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an animal name.");
            }
        }

        // Clear the list of animals
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            listOfAnimals.Clear();
            lbAnimals.Items.Refresh();
        }

        // Delete the selected animal from the list
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbAnimals.SelectedItem is string selectedAnimal)
            {
                listOfAnimals.Remove(selectedAnimal);
                lbAnimals.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Please select an animal to delete.");
            }
        }

        // Sort the list of animals alphabetically
        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            listOfAnimals.Sort();
            lbAnimals.Items.Refresh();
        }

        // Close the application
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}