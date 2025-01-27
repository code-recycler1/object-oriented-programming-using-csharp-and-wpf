using System.Windows;

namespace OO_Exercises_WPF
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

        private void btnExercise_1_Square_Click(object sender, RoutedEventArgs e)
        {
            Exercise_1_Square square = new Exercise_1_Square();
            square.Show();
        }

        private void btnExercise_2_BMI_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2_BMI bmi = new Exercise_2_BMI();
            bmi.Show();
        }

        private void btnExercise_3_Lamp_Click(object sender, RoutedEventArgs e)
        {
            Exercise_3_Lamp lamp = new Exercise_3_Lamp();
            lamp.Show();
        }

        private void btnExercise_4_Train_Click(object sender, RoutedEventArgs e)
        {
            Exercise_4_Train train = new Exercise_4_Train();
            train.Show();
        }

        private void btnExercise_5_Tamagotchi_Click(object sender, RoutedEventArgs e)
        {
            Exercise_5_Tamagotchi tamagotchi = new Exercise_5_Tamagotchi();
            tamagotchi.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
