using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using QuSwense.ModernControls.View;

namespace QuSwense.ModernControls.ViewModel
{
    /// <summary>
    /// Use this class to define tree like data types for similar UI Controls.
    /// Currently used for the items of <see cref="MenuSidebarTree"/>.
    /// </summary>
    public class TreeNodeItemVM<ITItem> : ViewModelBase
    {
        /// <summary>
        /// The children nodes of this tree node item.
        /// </summary>
        public List<TreeNodeItemVM<ITItem>> ChildNodes { get; set; }

        public ITItem Data { get; set; }

        public ICommand ClickCommand { get; set; }
    }
}
