using System.Windows;

namespace QuSwense.ModernControls.View
{
    public class HelpButton : CaptionButton
    {
        static HelpButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HelpButton), new FrameworkPropertyMetadata(typeof(HelpButton)));
        }
    }
}
