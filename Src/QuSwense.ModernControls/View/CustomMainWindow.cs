using System.Windows;

namespace QuSwense.ModernControls.View
{
    public class CustomMainWindow : Window
    {
        static CustomMainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomMainWindow), new FrameworkPropertyMetadata(typeof(CustomMainWindow)));
        }
    }
}
