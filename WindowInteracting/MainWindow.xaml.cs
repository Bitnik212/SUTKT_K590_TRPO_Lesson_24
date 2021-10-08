using System.Windows;

namespace WindowInteracting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        NewWindow _window = new NewWindow();
        public MainWindow()
        {
            InitializeComponent();
            // Стартуем окна как немодальные.
            Window1 w1 = new Window1();
            w1.Show();
            Window2 w2 = new Window2();
            w2.Show();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Отображаем второе окно как немодальное.
            _window.Show();
            // Делаем первую кнопку не активной.
            buttonShow.IsEnabled = false;
            // Вторую кнопку, для обновления дочернего окна, делаем активной.
            buttonUpdate.IsEnabled = true;
        }
        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Вызываем пользовательский метод, который обновляет значения Label в дочернем окне.
            _window.UpdateWindow("Hello world");
            buttonUpdate.IsEnabled = false;
        }
        

    }
}