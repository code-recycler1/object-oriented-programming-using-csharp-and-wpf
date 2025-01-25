using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Start_examples
{
    /// <summary>
    /// Interaction logic for FrmGrid.xaml
    /// </summary>
    public partial class FrmGrid : Window
    {
        public FrmGrid()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the "Submit" button
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // Display the full name in a message box
            MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text, "Full Name", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Event handler for the "Close" button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Closes the current window
        }
    }
}
