using System.Windows;

namespace WindowInteracting
{
    public partial class NewWindow : Window
    {
        public NewWindow()
        {
            InitializeComponent();
        }
        public void UpdateWindow(string message)
        {
            LabelResult.Content = message;
        }
    }
}