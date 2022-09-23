using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace QuSwense.ModernControls.ViewModel
{
    /// <summary>
    /// Use attach property to pass command and parameters from <see cref="MenuSidebarItem"/>
    /// </summary>
    public class MenuSidebarTreeAttachProperty : DependencyObject
    {
        public MenuSidebarItemViewModel Item
        {
            get { return (MenuSidebarItemViewModel)GetValue(ItemProperty); }
            set { SetValue(ItemProperty, value); }
        }

        public static MenuSidebarItemViewModel GeItem(DependencyObject d)
        {
            return (MenuSidebarItemViewModel)d.GetValue(ItemProperty);
        }

        public static void SetItem(DependencyObject d, MenuSidebarItemViewModel value)
        {
            d.SetValue(ItemProperty, value);
        }

        // Using a DependencyProperty as the backing store for NodeItemVM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemProperty =
            DependencyProperty.Register("Item", typeof(MenuSidebarItemViewModel), typeof(MenuSidebarTreeAttachProperty), new PropertyMetadata(null));

        public ToggleButton ExpandCollapseButton
        {
            get { return (ToggleButton)GetValue(ExpandCollapseButtonProperty); }
            set { SetValue(ExpandCollapseButtonProperty, value); }
        }

        public static ToggleButton GetExpandCollapseButton(DependencyObject d)
        {
            return (ToggleButton)d.GetValue(ExpandCollapseButtonProperty);
        }

        public static void SetExpandCollapseButton(DependencyObject d, ToggleButton value)
        {
            d.SetValue(ExpandCollapseButtonProperty, value);
        }

        // Using a DependencyProperty as the backing store for NodeItemVM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ExpandCollapseButtonProperty =
            DependencyProperty.Register("ExpandCollapseButton", typeof(ToggleButton), typeof(MenuSidebarTreeAttachProperty), new PropertyMetadata(null));

        public bool MenuItemHasItems
        {
            get { return (bool)GetValue(MenuItemHasItemsProperty); }
            set { SetValue(MenuItemHasItemsProperty, value); }
        }

        public static bool GetMenuItemHasItems(DependencyObject d)
        {
            return (bool)d.GetValue(MenuItemHasItemsProperty);
        }

        public static void SetMenuItemHasItems(DependencyObject d, bool value)
        {
            d.SetValue(MenuItemHasItemsProperty, value);
        }

        // Using a DependencyProperty as the backing store for NodeItemVM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MenuItemHasItemsProperty =
            DependencyProperty.Register("MenuItemHasItems", typeof(bool), typeof(MenuSidebarTreeAttachProperty), new PropertyMetadata(false));
    }
}
