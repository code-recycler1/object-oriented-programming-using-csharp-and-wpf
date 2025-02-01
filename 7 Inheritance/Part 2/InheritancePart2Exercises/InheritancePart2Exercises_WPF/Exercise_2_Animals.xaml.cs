using InheritancePart2Exercises_Models.Exercise_2;
using System.Collections.Generic;
using System.Windows;

namespace InheritancePart2Exercises_WPF
{
    public partial class Exercise_2_Animals : Window
    {
        // List to store all animals
        private List<Animal> listOfAnimals = new List<Animal>();

        // List to store predefined questions
        private List<string> listOfQuestions = new List<string>();

        public Exercise_2_Animals()
        {
            InitializeComponent();
        }

        // Event handler for window load
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Set the default radio button to "Cat"
            rbCat.IsChecked = true;

            // Add predefined questions to the list
            listOfQuestions.Add("Hello");
            listOfQuestions.Add("Good morning");
            listOfQuestions.Add("How are you?");
            listOfQuestions.Add("Who are you?");
            listOfQuestions.Add("What's the time?");
            listOfQuestions.Add("Are you hungry?");
            listOfQuestions.Add("Polly wants a.... ?");
            listOfQuestions.Add("What is the State fish of Hawaii?");
            listOfQuestions.Add("What is 10 + 12?");
            listOfQuestions.Add("What color is your hair?");

            // Bind the questions list to the ListBox
            lstQuestions.ItemsSource = listOfQuestions;

            // Bind the animals list to the ListBox
            lstAnimals.ItemsSource = listOfAnimals;
            lstAnimals.DisplayMemberPath = "Data";
        }

        // Event handler for "Create" button
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            // Validate the name input
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                Animal animal = null;

                // Create the appropriate animal based on the selected radio button
                if (rbCat.IsChecked == true)
                {
                    animal = new Cat(txtName.Text);
                }
                else if (rbParrot.IsChecked == true)
                {
                    animal = new Parrot(txtName.Text);
                }
                else
                {
                    animal = new Human(txtName.Text);
                }

                // Add the animal to the list and refresh the ListBox
                listOfAnimals.Add(animal);
                lstAnimals.Items.Refresh();
            }
            else
            {
                // Show an error message if the name is empty
                MessageBox.Show("Please enter a name", "Error");
            }
        }

        // Event handler for "Talk" button
        private void btnTalk_Click(object sender, RoutedEventArgs e)
        {
            // Check if an animal and a question are selected
            if (lstAnimals.SelectedItem is Animal animal && lstQuestions.SelectedItem is string question)
            {
                // Display the animal's response to the question
                MessageBox.Show(animal.Talk(question));
            }
            else
            {
                // Show an error message if no animal or question is selected
                MessageBox.Show("Please select an animal and a question first!", "Error");
            }
        }

        // Event handler for "Caress" button
        private void btnCaress_Click(object sender, RoutedEventArgs e)
        {
            // Check if an animal is selected
            if (lstAnimals.SelectedItem is Animal animal)
            {
                // Display the animal's response to being caressed
                MessageBox.Show(animal.Caress());
            }
            else
            {
                // Show an error message if no animal is selected
                MessageBox.Show("Please select an animal first!", "Error");
            }
        }

        // Event handler for "Eat" button
        private void btnEat_Click(object sender, RoutedEventArgs e)
        {
            // Check if an animal is selected
            if (lstAnimals.SelectedItem is Animal animal)
            {
                // Display the animal's response to eating
                MessageBox.Show(animal.Eat());
            }
            else
            {
                // Show an error message if no animal is selected
                MessageBox.Show("Please select an animal first!", "Error");
            }
        }

        // Event handler for "Close" button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            // Close the window
            this.Close();
        }
    }
}