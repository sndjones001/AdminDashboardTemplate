using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace QuSwense.ModernControls.ViewModel
{
    public class MenuNode : INotifyPropertyChanged
    {
        public List<MenuNode> ChildNodes { get; set; }
        public string Text { get; set; }
        public Visibility TextVisibility { get; set; }
        public string IconPath
        {
            get { return IconSource.ToString(); }
            set { IconSource = new BitmapImage(new System.Uri(value)); }
        }
        public ImageSource IconSource { get; protected set; }
        public double ImageSize { get; set; }
        public Thickness ImageMargin { get; set; }

        public Action ClickCommand { get; set; }

        private void OnMouseClickTreeItem(object sender, MouseButtonEventArgs args)
        {
            ClickCommand?.Invoke();
        }

        public MenuNode(string text)
        {
            Text = text;
            TextVisibility = Visibility.Visible;
            ImageSize = 18;
            ImageMargin = new Thickness(4, 0, 15, 0);
        }

        public MenuNode() : this(string.Empty) { }
    }
}
