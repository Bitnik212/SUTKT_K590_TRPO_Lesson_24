using System.Windows;
using System.Windows.Input;

namespace NotRectangularWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        /*
          * 1. Задать свойство AllowTransparency = true
          * 2. Установить WindowsStyle = None
          * 3. В качестве фона установить картинку с прозрачными элементами.
          */

        public MainWindow()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Закрываем текущее приложение.
            Application.Current.Shutdown();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Для перетаскивания окна за любую область.
            DragMove();
        }

    }
}