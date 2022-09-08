using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace QuSwense.ModernControls.View
{
    /// <summary>
    /// Interaction logic for WindowTitleBar.xaml
    /// </summary>
    public partial class WindowTitleBar : UserControl, INotifyPropertyChanged
    {
        private Window _parentWindow;

        public WindowTitleBar()
        {
            InitializeComponent();

            DataContext = this;
            Loaded += WindowTitleBar_Loaded;
        }

        private void WindowTitleBar_Loaded(object sender, RoutedEventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            _parentWindow = Window.GetWindow(this);

            if(_parentWindow != null)
                _parentWindow.StateChanged += ParentWindow_StateChanged;
        }

        private void ParentWindow_StateChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged(nameof(CaptionButtonMargin));
        }

        public Thickness CaptionButtonMargin
        {
            get
            {
                if (_parentWindow != null && _parentWindow.WindowState == WindowState.Maximized)
                    return new Thickness(6, 6, 0, 0);
                else
                    return new Thickness(0, 0, 0, 0);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
