using System.Windows;

namespace WindowInteracting
{
    public partial class Window2 : Window, InteractiveWindow
    {
        public Window2()
        {
            InitializeComponent();
        }
        #region IInteractiveWindow Members
        public void UpdateWindow(string message)
        {
            label1.Content = message;
        }
        #endregion
    }
}