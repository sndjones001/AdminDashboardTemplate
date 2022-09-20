using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace QuSwense.ModernControls.ViewModel
{
    public class TreeViewItemAttachProperty : DependencyObject
    {
        public UIMenuNodeItemVM NodeItemVM
        {
            get { return (UIMenuNodeItemVM)GetValue(NodeItemVMProperty); }
            set { SetValue(NodeItemVMProperty, value); }
        }

        public static UIMenuNodeItemVM GetNodeItemVM(DependencyObject d)
        {
            return (UIMenuNodeItemVM)d.GetValue(NodeItemVMProperty);
        }

        public static void SetNodeItemVM(DependencyObject d, UIMenuNodeItemVM value)
        {
            d.SetValue(NodeItemVMProperty, value);
        }

        // Using a DependencyProperty as the backing store for NodeItemVM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NodeItemVMProperty =
            DependencyProperty.Register("NodeItemVM", typeof(UIMenuNodeItemVM), typeof(TreeViewItemAttachProperty), new PropertyMetadata(null));

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
            DependencyProperty.Register("ExpandCollapseButton", typeof(ToggleButton), typeof(TreeViewItemAttachProperty), new PropertyMetadata(null));

        public bool HasItemsTreeViewItem
        {
            get { return (bool)GetValue(HasItemsTreeViewItemProperty); }
            set { SetValue(HasItemsTreeViewItemProperty, value); }
        }

        public static bool GetHasItemsTreeViewItem(DependencyObject d)
        {
            return (bool)d.GetValue(HasItemsTreeViewItemProperty);
        }

        public static void SetHasItemsTreeViewItem(DependencyObject d, bool value)
        {
            d.SetValue(HasItemsTreeViewItemProperty, value);
        }

        // Using a DependencyProperty as the backing store for NodeItemVM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HasItemsTreeViewItemProperty =
            DependencyProperty.Register("HasItemsTreeViewItem", typeof(bool), typeof(TreeViewItemAttachProperty), new PropertyMetadata(false));
    }
}
