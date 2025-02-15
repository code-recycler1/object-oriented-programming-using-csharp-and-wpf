using System.Windows;

namespace ExamExamples_WPF
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

        private void btnExercise_1_Parcel_Service_Click(object sender, RoutedEventArgs e)
        {
            Exercise_1_Parcel_Service parcelService = new Exercise_1_Parcel_Service();
            parcelService.Show();
        }

        private void btnExercise_2_Christmas_Dinner_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2_Christmas_Dinner christmasDinner = new Exercise_2_Christmas_Dinner();
            christmasDinner.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
