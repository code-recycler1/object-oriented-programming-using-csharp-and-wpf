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
    /// Interaction logic for FrmStart.xaml
    /// </summary>
    public partial class FrmStart : Window
    {
        public FrmStart()
        {
            InitializeComponent(); // Initializes the window and its components
        }

        // Event handler for the "Open FrmGrid" button
        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            FrmGrid frmGrid = new FrmGrid(); // Creates a new instance of FrmGrid
            frmGrid.Show(); // Displays the FrmGrid window
        }

        // Event handler for the "Open FrmStackPanel" button
        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            FrmStackPanel frmStackPanel = new FrmStackPanel(); // Creates a new instance of FrmStackPanel
            frmStackPanel.Show(); // Displays the FrmStackPanel window
        }

        // Event handler for the "Close" button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown(); // Closes the application
        }
    }
}
