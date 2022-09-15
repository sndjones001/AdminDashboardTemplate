﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace QuSwense.ModernControls.ViewModel
{
    public class UIMenuNodeItemVMSettings
    {
        public Visibility DefaultTextVisibility { get; set; }
        public double DefaultMenuIconSize { get; set; }
        public Thickness DefaultMenuIconMargin { get; set; }
        public Thickness DefaultMenuContainerMargin { get; set; }
        public BitmapImageBuilder ImageBuilder { get; protected set; }
        public Brush DefaultMenuItemBackground { get; set; }
        public Brush DefaultMenuItemMouseOverBackground { get; set; }

        public UIMenuNodeItemVMSettings(string assemblyName, string baseImagePath)
        {
            DefaultTextVisibility = Visibility.Visible;
            DefaultMenuIconSize = 20.0;
            DefaultMenuIconMargin = new Thickness(4, 0, 15, 0);
            DefaultMenuContainerMargin = new Thickness(1);
            DefaultMenuItemBackground = new SolidColorBrush(Colors.Transparent);
            DefaultMenuItemMouseOverBackground = new SolidColorBrush(Colors.Transparent);
            ImageBuilder = new BitmapImageBuilder(assemblyName, baseImagePath);
        }
    }
}
