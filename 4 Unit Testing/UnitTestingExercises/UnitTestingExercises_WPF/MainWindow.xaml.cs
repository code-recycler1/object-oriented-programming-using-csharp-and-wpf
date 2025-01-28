using System.Windows;

namespace UnitTestingExercises_WPF
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

        private void btnExercise_1_Swimming_Pool_Click(object sender, RoutedEventArgs e)
        {
            Exercise_1_Swimming_Pool swimmingPool = new Exercise_1_Swimming_Pool();
            swimmingPool.Show();
        }

        private void btnExercise_2_Train_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2_Train train = new Exercise_2_Train();
            train.Show();
        }

        private void btnExercise_3_Tamagotchi_Click(object sender, RoutedEventArgs e)
        {
            Exercise_3_Tamagotchi tamagotchi = new Exercise_3_Tamagotchi();
            tamagotchi.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
