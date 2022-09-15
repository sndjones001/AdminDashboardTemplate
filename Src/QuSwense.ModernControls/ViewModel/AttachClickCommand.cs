using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuSwense.ModernControls.ViewModel
{
    public class AttachClickCommand : DependencyObject
    {
        public static ICommand GetClickCommand(DependencyObject d)
        {
            return (ICommand)d.GetValue(ClickCommandProperty);
        }

        public static void SetClickCommand(DependencyObject d, ICommand value)
        {
            d.SetValue(ClickCommandProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClickCommandProperty =
            DependencyProperty.Register("ClickCommand", typeof(ICommand), typeof(AttachClickCommand), new PropertyMetadata(null));

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
            DependencyProperty.Register("NodeItemVM", typeof(UIMenuNodeItemVM), typeof(AttachClickCommand), new PropertyMetadata(null));

    }
}
