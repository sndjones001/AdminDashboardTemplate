﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace QuSwense.ModernControls.View
{
    public class MenuSidebarTree : TreeView
    {
        static MenuSidebarTree()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuSidebarTree), new FrameworkPropertyMetadata(typeof(MenuSidebarTree)));
        }

        public Thickness ScrollViewerPadding
        {
            get { return (Thickness)GetValue(ScrollViewerPaddingProperty); }
            set { SetValue(ScrollViewerPaddingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ScrollViewerPadding.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ScrollViewerPaddingProperty =
            DependencyProperty.Register("ScrollViewerPadding", typeof(Thickness), typeof(MenuSidebarTree), new PropertyMetadata(new Thickness(0)));


        public Thickness ItemContainerStyleGridMargin
        {
            get { return (Thickness)GetValue(ItemContainerStyleGridMarginProperty); }
            set { SetValue(ItemContainerStyleGridMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemContainerStyleGridMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemContainerStyleGridMarginProperty =
            DependencyProperty.Register("ItemContainerStyleGridMargin", typeof(Thickness), typeof(MenuSidebarTree), new PropertyMetadata(new Thickness(2)));

        public int HeaderContentWidth
        {
            get { return (int)GetValue(HeaderContentWidthProperty); }
            set { SetValue(HeaderContentWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderContentWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderContentWidthProperty =
            DependencyProperty.Register("HeaderContentWidth", typeof(int), typeof(MenuSidebarTree), new PropertyMetadata(0));

        public Brush MenuItemBackground
        {
            get { return (Brush)GetValue(MenuItemBackgroundProperty); }
            set { SetValue(MenuItemBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MenuItemBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MenuItemBackgroundProperty =
            DependencyProperty.Register("MenuItemBackground", typeof(Brush), typeof(MenuSidebarTree), new PropertyMetadata(new SolidColorBrush(Colors.White)));


        public Brush MenuItemMouseOverBackground
        {
            get { return (Brush)GetValue(MenuItemMouseOverBackgroundProperty); }
            set { SetValue(MenuItemMouseOverBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MenuItemMouseOverBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MenuItemMouseOverBackgroundProperty =
            DependencyProperty.Register("MenuItemMouseOverBackground", typeof(Brush), typeof(MenuSidebarTree), new PropertyMetadata(new SolidColorBrush(Colors.Transparent)));


        public Brush MenuItemMouseOverForeground
        {
            get { return (Brush)GetValue(MenuItemMouseOverForegroundProperty); }
            set { SetValue(MenuItemMouseOverForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MenuItemMouseOverForeground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MenuItemMouseOverForegroundProperty =
            DependencyProperty.Register("MenuItemMouseOverForeground", typeof(Brush), typeof(MenuSidebarTree), new PropertyMetadata(new SolidColorBrush(Colors.Black)));

        public Thickness TreeViewSubItemMargin
        {
            get { return (Thickness)GetValue(TreeViewSubItemMarginProperty); }
            set { SetValue(TreeViewSubItemMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TreeViewSubItemMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TreeViewSubItemMarginProperty =
            DependencyProperty.Register("TreeViewSubItemMargin", typeof(Thickness), typeof(MenuSidebarTree), new PropertyMetadata(new Thickness(8,0,0,0)));

        public ICommand ItemClickCommand
        {
            get { return (ICommand)GetValue(ItemClickCommandProperty); }
            set { SetValue(ItemClickCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemClickCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemClickCommandProperty =
            DependencyProperty.Register("ItemClickCommand", typeof(ICommand), typeof(MenuSidebarTree), new UIPropertyMetadata(null));

        
    }
}
