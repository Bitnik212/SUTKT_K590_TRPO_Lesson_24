using System.Windows;

namespace WindowOwnership
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            (Owner as MainWindow).Title = "Hello from child"; // получение ссылки на родительское окно
        }
    }
}