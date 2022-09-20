using QuSwense.ModernControls.ViewModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuSwense.ModernControls.Themes
{
    public partial class MenuSidebarTreeResourceDictionary
    {
        private void TreeViewItem_Click(object sender, MouseButtonEventArgs e)
        {
            var menuSidebarTreeStackPanel = sender as Border;
            var nodeItemVm = TreeViewItemAttachProperty.GetNodeItemVM(menuSidebarTreeStackPanel);
            var expandCollapseButton = TreeViewItemAttachProperty.GetExpandCollapseButton(menuSidebarTreeStackPanel);
            var hasItemsTreeViewItem = TreeViewItemAttachProperty.GetHasItemsTreeViewItem(menuSidebarTreeStackPanel);

            if(hasItemsTreeViewItem)
                expandCollapseButton.IsChecked = !expandCollapseButton.IsChecked;

            nodeItemVm.ClickCommand?.Execute(null);
        }
    }
}
