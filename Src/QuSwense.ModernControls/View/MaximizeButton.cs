using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace QuSwense.ModernControls.View
{
    public class MaximizeButton : CaptionButton, INotifyPropertyChanged
    {
        static MaximizeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MaximizeButton), new FrameworkPropertyMetadata(typeof(MaximizeButton)));
        }

        protected override void OnClick()
        {
            base.OnClick();
            Window w = Window.GetWindow(this);
            if (w.WindowState == WindowState.Maximized)
                SystemCommands.RestoreWindow(w);
            else
                SystemCommands.MaximizeWindow(w);
        }

        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            Window w = Window.GetWindow(this);
            if (w != null)
            {
                w.StateChanged += new EventHandler(OnWindowStateChanged);
            }
        }

        public MaximizeButton()
        {
            DataContext = this;
        }

        void OnWindowStateChanged(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(MaximizeIconVisibility));
            OnPropertyChanged(nameof(RestoreIconVisibility));
        }

        public Visibility MaximizeIconVisibility
        {
            get
            {
                Window w = Window.GetWindow(this);
                return w.WindowState == WindowState.Maximized ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        public Visibility RestoreIconVisibility
        {
            get
            {
                Window w = Window.GetWindow(this);
                return w.WindowState != WindowState.Maximized ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        #region INotifyPropertyChanged
        private void OnPropertyChanged([CallerMemberName]string info = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
