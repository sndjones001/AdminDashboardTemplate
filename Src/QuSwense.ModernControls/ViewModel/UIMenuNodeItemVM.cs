using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuSwense.ModernControls.ViewModel
{
    public class UIMenuNodeItemVM : TreeNodeItemVM<UIMenuData>
    {
        public static UIMenuNodeItemVM CreateDummy() => new UIMenuNodeItemVM();

        public static UIMenuNodeItemVM Create(string menuText, string menuImage, Action command = null, UIMenuNodeItemVMSettings settings = null)
        {
            if (settings == null)
                settings = new UIMenuNodeItemVMSettings(string.Empty, string.Empty);

            return new UIMenuNodeItemVM
            {
                Data = new UIMenuData(menuText, settings.DefaultTextVisibility, settings.ImageBuilder?.GetImage(menuImage), settings.DefaultMenuIconSize, settings.DefaultMenuIconMargin, settings.DefaultMenuContainerMargin, settings.DefaultMenuItemBackground, settings.DefaultMenuItemMouseOverBackground),
                ClickCommand = new RelayCommand(command)
            };
        }

        public UIMenuNodeItemVM AddChild(params UIMenuNodeItemVM[] uimenuNodeItems)
        {
            if (ChildNodes == null) ChildNodes = new List<TreeNodeItemVM<UIMenuData>>();
            ChildNodes.AddRange(uimenuNodeItems);

            return this;
        }
    }
}
