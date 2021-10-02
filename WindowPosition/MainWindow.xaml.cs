using System;
using System.Windows;

namespace WindowPosition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStyle = System.Windows.WindowStyle.ToolWindow;
        }
        // Для Window в XAML коде WindowStartupLocation="CenterScreen" для старта окна в центре экрана.
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Вариант 1
            Double width  = SystemParameters.FullPrimaryScreenWidth;
            Double height = SystemParameters.FullPrimaryScreenHeight;
            //// Вариант 2 не учитывается панель задач.
            //width = SystemParameters.WorkArea.Width;
            //height = SystemParameters.WorkArea.Height;
            this.Top = (height - this.Height) / 2;
            this.Left = (width - this.Width) / 2;
        }

    }
}