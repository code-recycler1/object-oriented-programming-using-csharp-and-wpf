using InheritancePart1Exercises_Models.Exercise_3;
using System.Windows;

namespace InheritancePart1Exercises_WPF
{
    public partial class Exercise_3_Cylinder : Window
    {
        public Exercise_3_Cylinder()
        {
            InitializeComponent();
        }

        // Event handler for the "Test Point" button
        private void btnPoints_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y))
            {
                // Create a Point object and display its data
                InheritancePart1Exercises_Models.Exercise_3.Point p = new InheritancePart1Exercises_Models.Exercise_3.Point(x, y);
                lblResult.Content = p.ShowData();
            }
            else
            {
                lblResult.Content = "X and Y must be numerical!";
            }
        }

        // Event handler for the "Test Circle" button
        private void btnCircle_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y) && int.TryParse(txtR.Text, out int r))
            {
                // Create a Circle object and display its data
                Circle c = new Circle(x, y, r);
                lblResult.Content = c.ShowData();
            }
            else
            {
                lblResult.Content = "X, Y, and R must be numerical!";
            }
        }

        // Event handler for the "Test Cylinder" button
        private void btnCylinder_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y) && int.TryParse(txtR.Text, out int r)
                && int.TryParse(txtH.Text, out int h))
            {
                // Create a Cylinder object and display its data
                Cylinder cil = new Cylinder(x, y, r, h);
                lblResult.Content = cil.ShowData();
            }
            else
            {
                lblResult.Content = "X, Y, R, and H must be numerical!";
            }
        }
    }
}