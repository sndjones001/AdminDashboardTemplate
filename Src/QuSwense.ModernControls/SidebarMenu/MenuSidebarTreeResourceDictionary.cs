using QuSwense.ModernControls.ViewModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuSwense.ModernControls.Themes
{
    public partial class MenuSidebarTreeResourceDictionary
    {
        private void MenuSidebarTreeItem_Click(object sender, MouseButtonEventArgs e)
        {
            var menuSidebarTreeStackPanel = sender as Border;
            var nodeItemVm = MenuSidebarTreeAttachProperty.GeItem(menuSidebarTreeStackPanel);
            var expandCollapseButton = MenuSidebarTreeAttachProperty.GetExpandCollapseButton(menuSidebarTreeStackPanel);
            var hasItemsTreeViewItem = MenuSidebarTreeAttachProperty.GetMenuItemHasItems(menuSidebarTreeStackPanel);

            if(hasItemsTreeViewItem)
                expandCollapseButton.IsChecked = !expandCollapseButton.IsChecked;

            //nodeItemVm.ClickCommand?.Execute(null);
        }
    }
}
