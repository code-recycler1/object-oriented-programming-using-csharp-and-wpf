using System.Collections.Generic;
using System.Windows;
using InheritancePart1Exercises_Models.Exercise_2;

namespace InheritancePart1Exercises_WPF
{
    public partial class Exercise_2_Animals : Window
    {
        // Declare instances of Cat, Parrot, and Human
        private Cat myCat;
        private Parrot myParrot;
        private Human myHuman;

        // List to store the questions for talking
        private List<string> listOfQuestions = new List<string>();

        public Exercise_2_Animals()
        {
            InitializeComponent();
        }

        // Event handler for when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Set the default selected animal to Cat
            radCat.IsChecked = true;

            // Populate the list of questions
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

            // Bind the list of questions to the ListBox
            lstQuestions.ItemsSource = listOfQuestions;
        }

        // Event handler for the "Create" button
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                // Create the selected animal object
                if (radCat.IsChecked == true)
                {
                    myCat = new Cat(txtName.Text);
                }
                else if (radParrot.IsChecked == true)
                {
                    myParrot = new Parrot(txtName.Text);
                }
                else if (radHuman.IsChecked == true)
                {
                    myHuman = new Human(txtName.Text);
                }
            }
            else
            {
                MessageBox.Show("Please enter a name", "Error");
            }
        }

        // Event handler for the "Talk" button
        private void btnTalk_Click(object sender, RoutedEventArgs e)
        {
            Animal myAnimal = WhatAnimal();
            if (lstQuestions.SelectedItem is string question && myAnimal != null)
            {
                MessageBox.Show(myAnimal.Talk(question));
            }
            else
            {
                MessageBox.Show("Please select a sentence and create an animal first.", "Error");
            }
        }

        // Event handler for the "Caress" button
        private void btnCaress_Click(object sender, RoutedEventArgs e)
        {
            Animal animal = WhatAnimal();
            if (animal != null)
            {
                MessageBox.Show(animal.Caress());
            }
            else
            {
                MessageBox.Show("Please create an animal first.", "Error");
            }
        }

        // Event handler for the "Eat" button
        private void btnEat_Click(object sender, RoutedEventArgs e)
        {
            Animal animal = WhatAnimal();
            if (animal != null)
            {
                MessageBox.Show(animal.Eat());
            }
            else
            {
                MessageBox.Show("Please create an animal first.", "Error");
            }
        }

        // Event handler for the "Close" button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Helper method to determine the selected animal
        private Animal WhatAnimal()
        {
            Animal myAnimal = null;
            if (radCat.IsChecked == true)
            {
                myAnimal = myCat;
            }
            else if (radParrot.IsChecked == true)
            {
                myAnimal = myParrot;
            }
            else if (radHuman.IsChecked == true)
            {
                myAnimal = myHuman;
            }
            if (myAnimal == null)
            {
                MessageBox.Show("Please create an animal first.", "Error");
            }
            return myAnimal;
        }
    }
}