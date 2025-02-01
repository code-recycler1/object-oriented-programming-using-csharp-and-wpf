using System.Windows;

namespace InheritancePart2Exercises_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExercise_1_Bank_Account_Click(object sender, RoutedEventArgs e)
        {
            Exercise_1_Bank_Account bankAccount = new Exercise_1_Bank_Account();
            bankAccount.Show();
        }

        private void btnExercise_2_Animals_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2_Animals animals = new Exercise_2_Animals();
            animals.Show();
        }

        private void btnExercise_3_Cylinder_Click(object sender, RoutedEventArgs e)
        {
            Exercise_3_Cylinder cylinder = new Exercise_3_Cylinder();
            cylinder.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
