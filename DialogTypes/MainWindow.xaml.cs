using System.Windows;

namespace DialogTypes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NewWindow window = new NewWindow("Модальное");
            window.ShowDialog();
            // Код после метода ShowDialog выполнится только тогда, кода диалоговое окно закроется.
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NewWindow window = new NewWindow("Немодальное");
            window.Show();
            // Код после метода Show выполнится сразу.
        }

    }
}