using System.Windows;

namespace WPF_Start_exercises
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

        private void btnExercise_1_Dice_Click(object sender, RoutedEventArgs e)
        {
            Exercise_1_Dice dice = new Exercise_1_Dice();
            dice.Show();
        }

        private void btnExercise_2_Circle_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2_Circle circle = new Exercise_2_Circle();
            circle.Show();
        }

        private void btnExercise_3_Cash_Register_Click(object sender, RoutedEventArgs e)
        {
            Exercise_3_Cash_Register cashRegister = new Exercise_3_Cash_Register();
            cashRegister.Show();
        }

        private void btnExercise_4_Employee_Click(object sender, RoutedEventArgs e)
        {
            Exercise_4_Employee employee = new Exercise_4_Employee();
            employee.Show();
        }
        private void btnExercise_5_Multiplication_Tables_Click(object sender, RoutedEventArgs e)
        {
            Exercise_5_Multiplication_Tables multiplicationTables = new Exercise_5_Multiplication_Tables();
            multiplicationTables.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

    }
}
