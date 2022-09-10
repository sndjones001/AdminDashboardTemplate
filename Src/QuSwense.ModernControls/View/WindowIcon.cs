using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuSwense.ModernControls.View
{
    public class WindowIcon : Control
    {
        static WindowIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowIcon), new FrameworkPropertyMetadata(typeof(WindowIcon)));
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            Window w = Window.GetWindow(this);
            if (e.ClickCount == 1)
            {
                Point p;
                if (e.ChangedButton == MouseButton.Left)
                {
                    p = this.PointToScreen(e.GetPosition(this));
                    p.X += 1;
                    p.Y += 1;
                }
                else
                {
                    p = this.PointToScreen(e.GetPosition(this));
                    p.X += 1;
                    p.Y += 1;
                }
                System.Windows.SystemCommands.ShowSystemMenu(w, p);
            }
            if (e.ClickCount == 2 && e.ChangedButton == MouseButton.Left)
                w.Close();
        }

        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(ImageSource), typeof(WindowIcon), new PropertyMetadata(null));


    }
}
