using QuSwense.ModernControls.ViewModel;
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

namespace QuSwense.Demo.MenuSidebarTreeControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PopulateSideMenu();
        }

        void PopulateSideMenu()
        {
            //MenuSidebarItemViewModelSettings settings = new MenuSidebarItemViewModelSettings(typeof(MainWindow).Assembly.GetName().Name, "Images");
            //var uiSidebarMenus = UIMenuNodeItemVM.CreateDummy()
            //    .AddChild
            //    (
            //        UIMenuNodeItemVM.Create("Dashboard", "icons8-home-24.png", OnDashboardMenuClick, settings, true),
            //        UIMenuNodeItemVM.Create("Email", "icons8-mail-24.png", OnDashboardMenuClick, settings),
            //        UIMenuNodeItemVM.Create("Calendar", "icons8-planner-24.png", OnDashboardMenuClick, settings),
            //        UIMenuNodeItemVM.Create("Charts", "icons8-combo-chart-50.png", OnDashboardMenuClick, settings),
            //        UIMenuNodeItemVM.Create("Tables", "icons8-tiles-24.png", OnDashboardMenuClick, settings)
            //            .AddChild
            //            (
            //                UIMenuNodeItemVM.Create("Basic Tables", "icons8-table-24.png", OnDashboardMenuClick, settings),
            //                UIMenuNodeItemVM.Create("Data Tables", "icons8-data-sheet-50.png", OnDashboardMenuClick, settings)
            //                .AddChild
            //                (
            //                    UIMenuNodeItemVM.Create("Chart Tables", "icons8-table-24.png", OnDashboardMenuClick, settings),
            //                    UIMenuNodeItemVM.Create("Excel Tables", "icons8-data-sheet-50.png", OnDashboardMenuClick, settings)
            //                )
            //            )
            //    );

            //treeView.ItemsSource = uiSidebarMenus.ChildNodes;
        }

        private void OnDashboardMenuClick()
        {
            //throw new NotImplementedException();
        }

        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }
    }
}
