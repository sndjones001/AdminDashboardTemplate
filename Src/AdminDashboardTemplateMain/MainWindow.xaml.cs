using AdminDashboardTemplateMain.ViewModel;
using QuSwense.ModernControls.View;
using QuSwense.ModernControls.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AdminDashboardTemplateMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : CustomMainWindow, INotifyPropertyChanged
    {
        private double _width = 211;

        public MainWindow()
        {
            InitializeComponent();

            PopulateSideMenu();

            Loaded += MainWindow_Loaded;
            this.DataContext = this;

            SelectedViewModel = new DashboardViewModel();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            StateChanged += MainWindow_StateChanged;
        }

        private void MainWindow_StateChanged(object sender, System.EventArgs e)
        {
            NotifyPropertyChanged(nameof(MenuSidebarTreeWidth));
        }

        public double MenuSidebarTreeWidth
        {
            get
            {
                if (WindowState == WindowState.Maximized)
                    return _width + 6;
                else
                    return _width;
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

        private object _selectedViewModel;
        public object SelectedViewModel
        {
            get => _selectedViewModel;
            set { _selectedViewModel = value; NotifyPropertyChanged(nameof(SelectedViewModel)); }
        }

        void PopulateSideMenu()
        {
            treeView.ItemsSource = new List<MenuNode>
            {
                new MenuNode{ Text = "Dashboard", IconPath = @"pack://application:,,,/AdminDashboardTemplateMain;component/Images/icons8-home-24.png", ClickCommand = OnDashboardMenuClick },
                new MenuNode{ Text = "Email", IconPath = @"pack://application:,,,/AdminDashboardTemplateMain;component/Images/icons8-mail-24.png", ClickCommand = OnEmailMenuClick },
                new MenuNode{ Text = "Calendar", IconPath = @"pack://application:,,,/AdminDashboardTemplateMain;component/Images/icons8-planner-24.png" },
                new MenuNode{ Text = "Charts", IconPath = @"pack://application:,,,/AdminDashboardTemplateMain;component/Images/icons8-combo-chart-50.png" },
                new MenuNode{ Text = "Tables", IconPath = @"pack://application:,,,/AdminDashboardTemplateMain;component/Images/icons8-tiles-24.png",
                ChildNodes = new List<MenuNode>
                {
                    new MenuNode{ Text = "Basic Tables", IconPath = @"pack://application:,,,/AdminDashboardTemplateMain;component/Images/icons8-table-24.png" },
                    new MenuNode{ Text = "Data Tables", IconPath = @"pack://application:,,,/AdminDashboardTemplateMain;component/Images/icons8-data-sheet-50.png" }
                } }
            };
        }

        private void OnDashboardMenuClick()
        {
            SelectedViewModel = new DashboardViewModel();
        }

        private void OnEmailMenuClick()
        {
            SelectedViewModel = new EmailViewModel();
        }

        private void OnWindowTitleBar_HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
