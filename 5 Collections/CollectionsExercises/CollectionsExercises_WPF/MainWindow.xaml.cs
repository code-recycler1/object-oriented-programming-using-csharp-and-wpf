using System.Windows;

namespace CollectionsExercises_WPF
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

        private void btnExercise_1_Animals_Click(object sender, RoutedEventArgs e)
        {
            Exercise_1_Animals animals = new Exercise_1_Animals();
            animals.Show();
        }

        private void btnExercise_2_Prime_Minister_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2_Prime_Minister primeMinister = new Exercise_2_Prime_Minister();
            primeMinister.Show();
        }

        private void btnExercise_3_Students_with_Results_Click(object sender, RoutedEventArgs e)
        {
            Exercise_3_Students_with_Results studentsWithResults = new Exercise_3_Students_with_Results();
            studentsWithResults.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
