using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using QuSwense.ModernControls.View;

namespace QuSwense.ModernControls.ViewModel
{
    /// <summary>
    /// Use this class to define tree like data types for similar UI Controls.
    /// Currently used for the items of <see cref="MenuSidebarTree"/>.
    /// </summary>
    public class MenuSidebarItemViewModel : ViewModelBase
    {
        public static MenuSidebarItemViewModelSettings Settings { get; set; }

        /// <summary>
        /// The children nodes of this tree node item.
        /// </summary>
        public ObservableCollection<MenuSidebarItemViewModel> ChildNodes { get; set; }

        #region Menu image icon

        /// <summary>
        /// The path of the image file in the application resource to be displayed with the menu text.
        /// This is the actual property used by the Control Template to display the image on UI.
        /// </summary>
        public ImageSource MenuIconSource { get; set; }

        /// <summary>
        /// The image size used to display
        /// </summary>
        public double MenuIconSize { get; set; }

        #endregion

        #region Menu text

        /// <summary>
        /// The text data to display the menu name in the UI.
        /// </summary>
        public string MenuName { get; set; }

        /// <summary>
        /// Set the Text visibility. Used to switch the visibility on menu resize.
        /// </summary>
        public Visibility MenuNameVisibility { get; set; }

        /// <summary>
        /// Use Padding to define the menu text and icon gap
        /// </summary>
        public Thickness MenuNamePadding { get; set; }

        #endregion

        #region Menu Container

        /// <summary>
        /// The margin of each menu item
        /// </summary>
        public Thickness MenuItemContainerMargin { get; set; }

        /// <summary>
        /// Normal background color of menu item
        /// </summary>
        public Brush MenuItemBackground { get; set; }

        /// <summary>
        /// Mouse over background color of menu item
        /// </summary>
        public Brush MenuItemMouseOverBackground { get; set; }

        /// <summary>
        /// Display tooltip on the menu item
        /// </summary>
        public string Tooltip { get; set; }

        #endregion

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

        

        

        

        public static MenuSidebarItemViewModel CreateDummy() => new MenuSidebarItemViewModel();

        public static MenuSidebarItemViewModel Create(string menuText, string menuImage, Action command = null, bool isSelected = false, string tooltip = null)
        {
            return new MenuSidebarItemViewModel
            {
                //Data = new UIMenuData(menuText, settings.DefaultTextVisibility, settings.ImageBuilder?.GetImage(menuImage), settings.DefaultMenuIconSize, settings.DefaultMenuIconMargin, settings.DefaultMenuContainerMargin, settings.DefaultMenuItemBackground, settings.DefaultMenuItemMouseOverBackground, tooltip),
                //ClickCommand = new RelayCommand(command),
                //IsSelected = isSelected
            };
        }

        public MenuSidebarItemViewModel AddChild(params MenuSidebarItemViewModel[] uimenuNodeItems)
        {
            if (ChildNodes == null) ChildNodes = new ();
            //ChildNodes.AddRange(uimenuNodeItems);

            return this;
        }
    }
}
