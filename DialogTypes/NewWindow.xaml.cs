using System.Windows;

namespace DialogTypes
{
    public partial class NewWindow : Window
    {
        public NewWindow()
        {
            InitializeComponent();
        }

        public NewWindow(string title)
        {
            InitializeComponent();
            Title = title;
        }
    }
}