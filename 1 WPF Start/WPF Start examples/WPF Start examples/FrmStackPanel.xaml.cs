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
    /// Interaction logic for FrmStackPanel.xaml
    /// </summary>
    public partial class FrmStackPanel : Window
    {
        public FrmStackPanel()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the "Red" button
        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            // Toggle the foreground and background colors of the Red button
            var originalForeground = btnRed.Foreground;
            btnRed.Foreground = (originalForeground == Brushes.Red) ? btnRed.Background : Brushes.Red;
            btnRed.Background = (originalForeground == Brushes.Red) ? Brushes.Red : originalForeground;
        }

        // Event handler for the "Green" button
        private void btnGreen_Click(object sender, RoutedEventArgs e)
        {
            // Toggle the foreground and background colors of the Green button
            var originalForeground = btnGreen.Foreground;
            btnGreen.Foreground = (originalForeground == Brushes.Green) ? btnGreen.Background : Brushes.Green;
            btnGreen.Background = (originalForeground == Brushes.Green) ? Brushes.Green : originalForeground;
        }

        // Event handler for the "Blue" button
        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            // Toggle the foreground and background colors of the Blue button
            var originalForeground = btnBlue.Foreground;
            btnBlue.Foreground = (originalForeground == Brushes.Blue) ? btnBlue.Background : Brushes.Blue;
            btnBlue.Background = (originalForeground == Brushes.Blue) ? Brushes.Blue : originalForeground;
        }

        // Event handler for the "Close" button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Closes the current window
        }
    }
}
