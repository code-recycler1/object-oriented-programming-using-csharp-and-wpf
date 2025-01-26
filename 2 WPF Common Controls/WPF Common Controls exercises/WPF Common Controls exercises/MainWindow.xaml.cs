using System.Windows;

namespace WPF_Common_Controls_exercises
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

        private void btnExercise_1_Ideal_Weight_Click(object sender, RoutedEventArgs e)
        {
            Exercise_1_Ideal_Weight idealWeight = new Exercise_1_Ideal_Weight();
            idealWeight.Show();
        }

        private void btnExercise_2_VAT_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2_VAT vat = new Exercise_2_VAT();
            vat.Show();
        }

        private void btnExercise_3_Reading_Files_Basic_Click(object sender, RoutedEventArgs e)
        {
            Exercise_3_Reading_Files_Basic readingFiles = new Exercise_3_Reading_Files_Basic();
            readingFiles.Show();
        }

        private void btnExercise_4_Reading_Files_Advanced_Click(object sender, RoutedEventArgs e)
        {
            Exercise_4_Reading_Files_Advanced readingFiles = new Exercise_4_Reading_Files_Advanced();
            readingFiles.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
