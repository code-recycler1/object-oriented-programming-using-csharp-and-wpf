using System.Windows;

namespace ExceptionHandlingExercises_WPF
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

        private void btnExercise_2_Customer_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2_Customer customer = new Exercise_2_Customer();
            customer.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
