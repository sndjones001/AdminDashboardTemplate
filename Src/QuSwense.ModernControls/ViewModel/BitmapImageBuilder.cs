using System;
using System.IO;
using System.Windows.Media.Imaging;

namespace QuSwense.ModernControls.ViewModel
{
    public class BitmapImageBuilder
    {
        public string BaseImagePath { get; set; }

        public BitmapImageBuilder(string assemblyName = null, string baseImagePath = null)
        {
            if(!string.IsNullOrEmpty(assemblyName) && !string.IsNullOrEmpty(baseImagePath))
                BaseImagePath = Path.Combine(@$"pack://application:,,,/{assemblyName};component/", baseImagePath);
        }

        public BitmapImage GetImage(string imageFileName)
        {
            if(!string.IsNullOrEmpty(BaseImagePath))
                return new BitmapImage(new Uri(Path.Combine(BaseImagePath, imageFileName)));
            else
                return new BitmapImage(new Uri(imageFileName));
        }
    }
}
