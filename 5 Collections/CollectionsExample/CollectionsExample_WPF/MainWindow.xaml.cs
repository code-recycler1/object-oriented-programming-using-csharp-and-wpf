using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using CollectionsExample_DAL;

namespace CollectionsExample_WPF
{
    public partial class MainWindow : Window
    {
        // List to store numbers
        private List<int> listOfNumbers = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Load initial data into the list and UI
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            lbItemsAdd.Items.Clear();
            listOfNumbers = new List<int> { 5, 2, 9, 7, 3, 1, 0, 8 };

            // Populate lbItemsAdd using Items.Add
            foreach (var item in listOfNumbers)
            {
                lbItemsAdd.Items.Add(item);
            }

            // Bind listOfNumbers to lbItemsSource
            lbItemsSource.ItemsSource = listOfNumbers;

            RefreshControls();
        }

        // Add numbers to the list
        private void btnAddList_Click(object sender, RoutedEventArgs e)
        {
            listOfNumbers.Add(4);
            if (!listOfNumbers.Contains(6))
            {
                listOfNumbers.Add(6);
            }
            RefreshControls();
        }

        // Remove a number from the list
        private void btnRemoveList_Click(object sender, RoutedEventArgs e)
        {
            listOfNumbers.Remove(5);
            RefreshControls();
        }

        // Sort the list
        private void btnSortList_Click(object sender, RoutedEventArgs e)
        {
            listOfNumbers.Sort();
            RefreshControls();
        }

        // Clear the list
        private void btnClearList_Click(object sender, RoutedEventArgs e)
        {
            listOfNumbers.Clear();
            RefreshControls();
        }

        // Read numbers from a file and add them to the list
        private void btnReadFileList_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FileReader fileReader = new FileReader();
                List<int> listFromFile = fileReader.ReadFile("doc\\numbers.txt");
                listOfNumbers.AddRange(listFromFile);
                RefreshControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }

        // Handle selection change in lbItemsSource
        private void lbItemsSource_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbItemsSource.SelectedItem is int number)
            {
                MessageBox.Show($"You picked number: {number}");
            }
        }

        // Add numbers to the bound list (listOfNumbers)
        private void btnAddItemsSource_Click(object sender, RoutedEventArgs e)
        {
            listOfNumbers.Add(4);
            listOfNumbers.Add(6);
            RefreshControls();
        }

        // Remove a number from the bound list (listOfNumbers)
        private void btnRemoveItemsSource_Click(object sender, RoutedEventArgs e)
        {
            listOfNumbers.Remove(5);
            RefreshControls();
        }

        // Add numbers to lbItemsAdd directly
        private void btnAddItemsAdd_Click(object sender, RoutedEventArgs e)
        {
            lbItemsAdd.Items.Add(4);
            lbItemsAdd.Items.Add(6);
        }

        // Remove a number from lbItemsAdd directly
        private void btnRemoveItemsAdd_Click(object sender, RoutedEventArgs e)
        {
            lbItemsAdd.Items.Remove(5);
        }

        // Clear lbItemsAdd directly
        private void btnClearItemsAdd_Click(object sender, RoutedEventArgs e)
        {
            lbItemsAdd.Items.Clear();
        }

        // Reset the application to its initial state
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            listOfNumbers = null;
            lbItemsAdd.Items.Clear();
            lbItemsSource.ItemsSource = null;
            lblResult.Content = "List will be displayed here";
        }

        // Refresh the UI controls to reflect changes in the list
        private void RefreshControls()
        {
            lblResult.Content = string.Join(Environment.NewLine, listOfNumbers);
            lbItemsSource.Items.Refresh();
        }
    }
}