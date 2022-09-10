using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class MenuSidebarTree : TreeView
    {
        static MenuSidebarTree()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuSidebarTree), new FrameworkPropertyMetadata(typeof(MenuSidebarTree)));
        }

        public int ScrollViewerPadding { get; protected set; } = 4;
        public Thickness ItemContainerStyleGridMargin { get; protected set; } = new Thickness(2,2,2,2);

        public int HeaderContentWidth
        {
            get { return (int)GetValue(HeaderContentWidthProperty); }
            set { SetValue(HeaderContentWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderContentWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderContentWidthProperty =
            DependencyProperty.Register("HeaderContentWidth", typeof(int), typeof(MenuSidebarTree), new PropertyMetadata(0));

    }
}
