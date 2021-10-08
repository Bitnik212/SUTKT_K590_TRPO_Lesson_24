using System.Runtime.Remoting.Contexts;
using System.Windows;
using System.Windows.Controls;
using Variant_1.ViewModel;

namespace Variant_1.View
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            // DataContext = new MainViewModel(NavigationService);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            // NavigationService?.Navigate(new MeanArephmeticPage());
        }
    }
}