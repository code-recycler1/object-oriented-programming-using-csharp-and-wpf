using System.Windows;

namespace CollectionsAndOOExercises_WPF
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

        private void btnExercise_1_Television_Click(object sender, RoutedEventArgs e)
        {
            Exercise_1_Television television = new Exercise_1_Television();
            television.Show();
        }

        private void btnExercise_2_Trainee_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2_Trainee trainee = new Exercise_2_Trainee();
            trainee.Show();
        }

        private void btnExercise_3_Shopping_Cart_Click(object sender, RoutedEventArgs e)
        {
            Exercise_3_Shopping_Cart shoppingCart = new Exercise_3_Shopping_Cart();
            shoppingCart.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
