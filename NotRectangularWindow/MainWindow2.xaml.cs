using System.Windows;
using System.Windows.Input;

namespace NotRectangularWindow
{
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
        }
        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

    }
}