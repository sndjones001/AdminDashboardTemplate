using System;
using System.Collections.Generic;

namespace QuSwense.ModernControls.ViewModel
{
    public class UIMenuNodeItemVM : TreeNodeItemVM<UIMenuData>
    {
        public static UIMenuNodeItemVM CreateDummy() => new UIMenuNodeItemVM();

        public static UIMenuNodeItemVM Create(string menuText, string menuImage, Action command = null, UIMenuNodeItemVMSettings settings = null, bool isSelected = false)
        {
            if (settings == null)
                settings = new UIMenuNodeItemVMSettings(string.Empty, string.Empty);

            return new UIMenuNodeItemVM
            {
                Data = new UIMenuData(menuText, settings.DefaultTextVisibility, settings.ImageBuilder?.GetImage(menuImage), settings.DefaultMenuIconSize, settings.DefaultMenuIconMargin, settings.DefaultMenuContainerMargin, settings.DefaultMenuItemBackground, settings.DefaultMenuItemMouseOverBackground),
                ClickCommand = new RelayCommand(command),
                IsSelected = isSelected
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
