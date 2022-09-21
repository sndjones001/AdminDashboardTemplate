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

namespace QuSwense.ModernControls.View
{
    public class MenuSidebarTreeItem : TreeViewItem
    {
        static MenuSidebarTreeItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuSidebarTreeItem), new FrameworkPropertyMetadata(typeof(MenuSidebarTreeItem)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new MenuSidebarTreeItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is MenuSidebarTreeItem;
        }

        public Thickness ItemContainerStyleGridMargin
        {
            get { return (Thickness)GetValue(ItemContainerStyleGridMarginProperty); }
            set { SetValue(ItemContainerStyleGridMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemContainerStyleGridMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemContainerStyleGridMarginProperty =
            DependencyProperty.Register("ItemContainerStyleGridMargin", typeof(Thickness), typeof(MenuSidebarTreeItem), new PropertyMetadata(new Thickness(2)));

        public double ItemIconSize
        {
            get { return (double)GetValue(ItemIconSizeProperty); }
            set { SetValue(ItemIconSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemIconSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemIconSizeProperty =
            DependencyProperty.Register("ItemIconSize", typeof(double), typeof(MenuSidebarTreeItem), new PropertyMetadata(20.0));

        public Thickness ItemTextPadding
        {
            get { return (Thickness)GetValue(ItemTextPaddingProperty); }
            set { SetValue(ItemTextPaddingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemIconMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemTextPaddingProperty =
            DependencyProperty.Register("ItemTextPadding", typeof(Thickness), typeof(MenuSidebarTreeItem), new PropertyMetadata(new Thickness(10,0,0,0)));
    }
}
