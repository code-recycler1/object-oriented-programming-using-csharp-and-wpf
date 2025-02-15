using ExamExamples_DAL;
using ExamExamples_Models.Exercise_2;
using System;
using System.Collections.Generic;
using System.Windows;

namespace ExamExamples_WPF
{
    /// <summary>
    /// Interaction logic for Exercise_2_Christmas_Dinner.xaml
    /// </summary>
    public partial class Exercise_2_Christmas_Dinner : Window
    {
        // FileOperations instance for reading and logging
        private FileOperations fileOperations = new FileOperations();

        // Lists to store dishes and reservations
        private List<Dish> listOfDishes = new List<Dish>();
        private List<Dish> listOfMainCourses = new List<Dish>();
        private List<Dish> listOfDesserts = new List<Dish>();
        private List<DinnerReservation> listOfDinnerReservations = new List<DinnerReservation>();

        public Exercise_2_Christmas_Dinner()
        {
            InitializeComponent();
        }

        // Event handler for when the window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Set window title
                this.Title = "Code Recycler";

                // Read dishes from file
                listOfDishes = fileOperations.ReadDishes("doc\\dishes.txt");

                // Select Dinner radio button by default
                rbDinner.IsChecked = true;

                // Split dishes into main courses and desserts
                foreach (Dish dish in listOfDishes)
                {
                    if (dish.Type.ToLower() == "main course")
                    {
                        listOfMainCourses.Add(dish);
                    }
                    else
                    {
                        listOfDesserts.Add(dish);
                    }
                }

                // Bind ComboBoxes to lists
                cmbMainCourses.ItemsSource = listOfMainCourses;
                cmbDesserts.ItemsSource = listOfDesserts;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"An error occurred: {exception.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for Dinner radio button
        private void rbDinner_Checked(object sender, RoutedEventArgs e)
        {
            cmbDesserts.Visibility = Visibility.Hidden;
            lblDessert.Visibility = Visibility.Hidden;
        }

        // Event handler for Christmas Dinner radio button
        private void rbChristmasDinner_Checked(object sender, RoutedEventArgs e)
        {
            cmbDesserts.Visibility = Visibility.Visible;
            lblDessert.Visibility = Visibility.Visible;
        }

        // Event handler for Show Reservations button
        private void btnShowReservations_Click(object sender, RoutedEventArgs e)
        {
            lblReservations.Content = "";
            foreach (DinnerReservation dinnerReservation in listOfDinnerReservations)
            {
                lblReservations.Content += dinnerReservation.ToString();
            }
        }

        // Event handler for Book button
        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validate inputs
                string errorText = Validate();
                if (errorText == "")
                {
                    if (cmbMainCourses.SelectedItem is Dish mainCourse)
                    {
                        DinnerReservation dinnerReservation = null;

                        // Create appropriate reservation based on selected radio button
                        if (rbChristmasDinner.IsChecked == true && cmbDesserts.SelectedItem is Dish dessert)
                        {
                            dinnerReservation = new ChristmasDinnerReservation(
                                txtName.Text,
                                int.Parse(txtNumberOfPeople.Text),
                                mainCourse.Name,
                                mainCourse.Price,
                                dessert.Name,
                                dessert.Price
                            );
                        }
                        else
                        {
                            dinnerReservation = new DinnerReservation(
                                txtName.Text,
                                int.Parse(txtNumberOfPeople.Text),
                                mainCourse.Name,
                                mainCourse.Price
                            );
                        }

                        // Check for duplicates
                        if (!listOfDinnerReservations.Contains(dinnerReservation))
                        {
                            listOfDinnerReservations.Add(dinnerReservation);
                        }
                        else
                        {
                            MessageBox.Show("You have already booked! Changes are not allowed!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                        // Disable Book button if restaurant is full
                        if (listOfDinnerReservations.Count >= 5)
                        {
                            btnBook.IsEnabled = false;
                            MessageBox.Show("No more reservations are accepted. The restaurant is full!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorText, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                fileOperations.LogErrors(exception);
            }
        }

        // Event handler for Close button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Method to validate inputs
        private string Validate()
        {
            string error = "";
            if (int.TryParse(txtNumberOfPeople.Text, out int numberOfPeople) == false)
            {
                error += "You must enter a numeric value for the number of people." + Environment.NewLine;
            }
            if (cmbMainCourses.SelectedItem == null)
            {
                error += "You must select a main course." + Environment.NewLine;
            }
            if (rbChristmasDinner.IsChecked == true && cmbDesserts.SelectedItem == null)
            {
                error += "You must select a dessert for a Christmas dinner.";
            }
            return error;
        }
    }
}