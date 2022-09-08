using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace QuSwense.ModernControls.View
{
    public class CaptionButton : Button
    {
        static CaptionButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CaptionButton), new FrameworkPropertyMetadata(typeof(CaptionButton)));
        }
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(CaptionButton), new UIPropertyMetadata(new CornerRadius()));

        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            DependencyProperty.Register(nameof(HoverBackground), typeof(Brush), typeof(CaptionButton), new UIPropertyMetadata(new SolidColorBrush(Colors.LightBlue)));

        public Brush PressedBackground
        {
            get { return (Brush)GetValue(PressedBackgroundProperty); }
            set { SetValue(PressedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty PressedBackgroundProperty =
            DependencyProperty.Register(nameof(PressedBackground), typeof(Brush), typeof(CaptionButton), new UIPropertyMetadata(new SolidColorBrush(Colors.LightBlue)));
    }
}
