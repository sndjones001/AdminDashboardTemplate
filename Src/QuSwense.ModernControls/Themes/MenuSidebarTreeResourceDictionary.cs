using QuSwense.ModernControls.View;
using QuSwense.ModernControls.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var menuSidebarTreeStackPanelClickCommandParam = AttachClickCommand.GetNodeItemVM(menuSidebarTreeStackPanel);
        }
    }
}
