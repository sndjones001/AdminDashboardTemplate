using System.Windows.Media;
using System.Windows;

namespace QuSwense.ModernControls.ViewModel
{
    public class UIMenuData : ViewModelBase
    {
        #region Menu text
        /// <summary>
        /// The text data to display the menu name in the UI.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Set the Text visibility. Used to switch the visibility on menu resize.
        /// </summary>
        public Visibility TextVisibility { get; set; }
        #endregion

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

        /// <summary>
        /// Set the margin of the image to provide gaps during UI display
        /// </summary>
        public Thickness MenuIconMargin { get; set; }
        #endregion

        #region Container
        public Thickness MenuContainerMargin { get; set; }
        public Brush MenuItemBackground { get; set; }
        public Brush MenuItemMouseOverBackground { get; set; }
        #endregion


        #region Constructors
        /// <summary>
        /// Construct
        /// </summary>
        /// <param name="text"></param>
        /// <param name="menuIconPath"></param>
        public UIMenuData(string text, Visibility textVisibility, ImageSource menuIcon, double imageSize, Thickness imageMargin, Thickness menuContainerMargin, Brush menuItemBackground, Brush menuItemMouseOverBackground)
        {
            Text = text;
            TextVisibility = textVisibility;
            MenuIconSource = menuIcon;
            MenuIconSize = imageSize;
            MenuIconMargin = imageMargin;
            MenuContainerMargin = menuContainerMargin;
            MenuItemBackground = menuItemBackground;
            MenuItemMouseOverBackground = menuItemMouseOverBackground;
        }
        #endregion
    }
}
