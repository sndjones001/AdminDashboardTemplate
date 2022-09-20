using System.Collections.Generic;
using System.Windows.Input;
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

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    NotifyPropertyChanged("IsSelected");
                }
            }
        }
    }
}
