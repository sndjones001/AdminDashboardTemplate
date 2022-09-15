using AdminDashboardTemplateMain.ViewModel;
using QuSwense.ModernControls.View;
using QuSwense.ModernControls.ViewModel;
using System.ComponentModel;
using System.Windows;

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
            UIMenuNodeItemVMSettings settings = new UIMenuNodeItemVMSettings(nameof(AdminDashboardTemplateMain), "Images");
            var uiSidebarMenus = UIMenuNodeItemVM.CreateDummy()
                .AddChild
                (
                    UIMenuNodeItemVM.Create("Dashboard", "icons8-home-24.png", OnDashboardMenuClick, settings, true),
                    UIMenuNodeItemVM.Create("Email", "icons8-mail-24.png", OnDashboardMenuClick, settings),
                    UIMenuNodeItemVM.Create("Calendar", "icons8-planner-24.png", OnDashboardMenuClick, settings),
                    UIMenuNodeItemVM.Create("Charts", "icons8-combo-chart-50.png", OnDashboardMenuClick, settings),
                    UIMenuNodeItemVM.Create("Tables", "icons8-tiles-24.png", OnDashboardMenuClick, settings)
                        .AddChild
                        (
                            UIMenuNodeItemVM.Create("Basic Tables", "icons8-table-24.png", OnDashboardMenuClick, settings),
                            UIMenuNodeItemVM.Create("Data Tables", "icons8-data-sheet-50.png", OnDashboardMenuClick, settings)
                            .AddChild
                            (
                                UIMenuNodeItemVM.Create("Chart Tables", "icons8-table-24.png", OnDashboardMenuClick, settings),
                                UIMenuNodeItemVM.Create("Excel Tables", "icons8-data-sheet-50.png", OnDashboardMenuClick, settings)
                            )
                        )
                );

            treeView.ItemsSource = uiSidebarMenus.ChildNodes;
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
