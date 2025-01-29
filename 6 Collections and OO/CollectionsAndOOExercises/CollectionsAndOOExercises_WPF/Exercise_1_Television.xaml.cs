using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using CollectionsAndOOExercises_Models;

namespace CollectionsAndOOExercises_WPF
{
    public partial class Exercise_1_Television : Window
    {
        // List to store the TV channels
        private List<TelevisionChannel> listOfTelevisionChannels = new List<TelevisionChannel>();

        public Exercise_1_Television()
        {
            InitializeComponent();
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Populate the list with TV channels
                listOfTelevisionChannels.Add(new TelevisionChannel(1, "BBC1"));
                listOfTelevisionChannels.Add(new TelevisionChannel(2, "BBC2"));
                listOfTelevisionChannels.Add(new TelevisionChannel(3, "ITV"));
                listOfTelevisionChannels.Add(new TelevisionChannel(4, "Channel 4"));
                listOfTelevisionChannels.Add(new TelevisionChannel(5, "Channel 5"));

                // Bind the list to the ComboBox
                cmbChannel.ItemsSource = listOfTelevisionChannels;

                // Set the display path to show the channel description
                cmbChannel.DisplayMemberPath = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading channels: {ex.Message}", "Error");
            }
        }

        // Event handler for when the selection in the ComboBox changes
        private void cmbChannel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbChannel.SelectedItem is TelevisionChannel televisionChannel)
            {
                // Display the selected channel's number in the label
                lblNumber.Content = $"The number of the channel is {televisionChannel.Number}";
            }
            else
            {
                // Clear the label if no channel is selected
                lblNumber.Content = "";
            }
        }
    }
}