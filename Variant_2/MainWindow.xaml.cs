using System.Windows;
using Microsoft.Win32;

namespace Variant_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        ExtraWindow extraWindow = new ExtraWindow();
        OpenFileDialog opener = new OpenFileDialog();

        public MainWindow() => InitializeComponent();

        void add(object sender, RoutedEventArgs e){
            opener.Filter = "Image files (*.PNG)|*.png|All Files (*.*)|*.*";
            if(opener.ShowDialog() == true)
                MessageBox.Show(extraWindow.add(opener.FileName));
        }

        void show(object sender, RoutedEventArgs e) => extraWindow.ShowDialog();

        void shutdown(object sender, System.ComponentModel.CancelEventArgs e) => App.Current.Shutdown();
    }
}