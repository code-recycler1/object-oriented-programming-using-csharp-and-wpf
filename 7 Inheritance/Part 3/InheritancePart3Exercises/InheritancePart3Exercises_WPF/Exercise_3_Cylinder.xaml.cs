using InheritancePart3Exercises_Models.Exercise_3;
using System.Collections.Generic;
using System.Windows;
using Point = InheritancePart3Exercises_Models.Exercise_3.Point;

namespace InheritancePart3Exercises_WPF
{
    public partial class Exercise_3_Cylinder : Window
    {
        // List to store all geometric objects (Point, Circle, Cylinder)
        private List<Point> listOfForms = new List<Point>();

        public Exercise_3_Cylinder()
        {
            InitializeComponent();
        }

        // Event handler for window load
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Bind the list of forms to the ListBox
            lstForms.ItemsSource = listOfForms;
            // lstForms.DisplayMemberPath = "Description"; // Commented out to test ToString()
        }

        // Event handler for "Test Point" button
        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            // Validate X and Y inputs
            if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y))
            {
                // Create a Point object and add it to the list
                Point point = new Point(x, y);
                lblResult.Content = point.ToString();
                AddObject(point);
            }
            else
            {
                // Show an error message if inputs are invalid
                lblResult.Content = "X and Y must be numerical!";
            }
        }

        // Event handler for "Test Circle" button
        private void btnCircle_Click(object sender, RoutedEventArgs e)
        {
            // Validate X, Y, and R inputs
            if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y) && int.TryParse(txtR.Text, out int r))
            {
                // Create a Circle object and add it to the list
                Circle circle = new Circle(x, y, r);
                lblResult.Content = circle.ToString();
                AddObject(circle);
            }
            else
            {
                // Show an error message if inputs are invalid
                lblResult.Content = "X, Y, and R must be numerical!";
            }
        }

        // Event handler for "Test Cylinder" button
        private void btnCylinder_Click(object sender, RoutedEventArgs e)
        {
            // Validate X, Y, R, and H inputs
            if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y) && int.TryParse(txtR.Text, out int r) && int.TryParse(txtH.Text, out int h))
            {
                // Create a Cylinder object and add it to the list
                Cylinder cylinder = new Cylinder(x, y, r, h);
                lblResult.Content = cylinder.ToString();
                AddObject(cylinder);
            }
            else
            {
                // Show an error message if inputs are invalid
                lblResult.Content = "X, Y, R, and H must be numerical!";
            }
        }

        // Event handler for "Show" button
        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            // Check if an object is selected in the ListBox
            if (lstForms.SelectedItem is Point form)
            {
                // Display the selected object's data in a MessageBox
                MessageBox.Show(form.ToString());
            }
            else
            {
                // Show an error message if no object is selected
                MessageBox.Show("Please select an object first!", "Error");
            }
        }

        // Method to add an object to the list and refresh the ListBox
        private void AddObject(Point point)
        {
            // Check if the object already exists in the list
            if (!listOfForms.Contains(point))
            {
                // Add the object to the list and refresh the ListBox
                listOfForms.Add(point);
                lstForms.Items.Refresh();
            }
            else
            {
                // Show an error message if the object already exists
                MessageBox.Show($"This object has already been added: {point}", "Error");
            }
        }
    }
}