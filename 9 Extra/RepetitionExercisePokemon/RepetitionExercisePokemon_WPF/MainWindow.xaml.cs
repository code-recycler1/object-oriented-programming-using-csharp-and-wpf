using System.Windows;

namespace RepetitionExercisePokemon_WPF
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

        private void btnExercise_1_OO_Click(object sender, RoutedEventArgs e)
        {
            Exercise_1_OO exercise_1_OO = new Exercise_1_OO();
            exercise_1_OO.Show();
        }

        private void btnExercise_2_OO_and_String_List_Click(object sender, RoutedEventArgs e)
        {
            Exercise_2_OO_and_String_List exercise_2_OO_and_String_List = new Exercise_2_OO_and_String_List();
            exercise_2_OO_and_String_List.Show();
        }

        private void btnExercise_3_OO_and_OO_List_Click(object sender, RoutedEventArgs e)
        {
            Exercise_3_OO_and_OO_List exercise_3_OO_and_OO_List = new Exercise_3_OO_and_OO_List();
            exercise_3_OO_and_OO_List.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
