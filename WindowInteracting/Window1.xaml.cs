using System.Windows;

namespace WindowInteracting
{
    public partial class Window1 : Window, InteractiveWindow
    {
        public Window1()
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