using QuSwense.ModernControls.ViewModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuSwense.ModernControls.Themes
{
    public partial class MenuSidebarTreeResourceDictionary
    {
        private void TreeViewItem_Click(object sender, MouseButtonEventArgs e)
        {
            var menuSidebarTreeStackPanel = sender as StackPanel;
            var menuSidebarTreeStackPanelClickCommand = AttachClickCommand.GetClickCommand(menuSidebarTreeStackPanel);
            var nodeItemVm = AttachClickCommand.GetNodeItemVM(menuSidebarTreeStackPanel);

            //nodeItemVm.IsSelected = true;
        }
    }
}
