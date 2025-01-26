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

        private void btnExercise_1_Counter_Click(object sender, RoutedEventArgs e)
        {
            Exercise_1_Counter counter = new Exercise_1_Counter();
            counter.Show();
        }

        private void btnExercise_2_TV_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2_Television tv = new Exercise_2_Television();
            tv.Show();
        }

        private void btnExercise_3_Swimming_Pool_Click(object sender, RoutedEventArgs e)
        {
            Exercise_3_Swimming_Pool pool = new Exercise_3_Swimming_Pool();
            pool.Show();
        }

        private void btnExercise_4_Student_Click(object sender, RoutedEventArgs e)
        {
            Exercise_4_Student student = new Exercise_4_Student();
            student.Show();
        }

        private void btnExercise_5_Rectangle_Click(object sender, RoutedEventArgs e)
        {
            Exercise_5_Rectangle rectangle = new Exercise_5_Rectangle();
            rectangle.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
