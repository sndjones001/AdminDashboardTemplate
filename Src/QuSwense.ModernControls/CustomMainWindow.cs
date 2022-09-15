using QuSwense.ModernControls.Common;
using System.Windows;

namespace QuSwense.ModernControls
{
    public class CustomMainWindow : Window
    {
        static CustomMainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomMainWindow), new FrameworkPropertyMetadata(typeof(CustomMainWindow)));
        }

        private int _marginAroundWindowToAllowDropShadow = 10;
        private int _radiusWindowEdges = 10;
        private WindowDockPosition _dockPosition = WindowDockPosition.Undocked;
        private WindowResizer _windowResizer;

        /// <summary>
        /// True if the window should be borderless because it is docked or maximized
        /// </summary>
        //public bool IsWindowBorderless { get => WindowState == WindowState.Maximized || _dockPosition != WindowDockPosition.Undocked; }

        /// <summary>
        /// The size of the resize border around the window, taking into account the outer margin
        /// </summary>
        //public Thickness ResizeBorderThickness { get => new Thickness(ResizeBorderAroundWindow + OuterMarginSize); }
        //public Thickness InnerContentPadding { get => new Thickness(ResizeBorderAroundWindow); }
        //public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }
        //public int WindowRadius
        //{
        //    get => IsWindowBorderless ? 0 : _radiusWindowEdges;
        //    set => _radiusWindowEdges = value;
        //}
        //public CornerRadius CloseButtonCornerRadius { get => new CornerRadius(0, RadiusWindowEdges, 0, 0); }

        /// <summary>
        /// The height of the title bar / caption of the window
        /// </summary>
        //public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight + ResizeBorderAroundWindow); } }
        //public ICommand MinimizeCommand { get; protected set; }
        //public ICommand MaximizeCommand { get; protected set; }
        //public ICommand CloseCommand { get; protected set; }
        //public ICommand MenuCommand { get; protected set; }

        //public int TitleHeight
        //{
        //    get { return (int)GetValue(TitleHeightProperty); }
        //    set { SetValue(TitleHeightProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for TitleHeight.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty TitleHeightProperty =
        //    DependencyProperty.Register("TitleHeight", typeof(int), typeof(CustomMainWindow), new PropertyMetadata(35));


        //public int ResizeBorderAroundWindow
        //{
        //    get { return (int)GetValue(ResizeBorderAroundWindowProperty); }
        //    set { SetValue(ResizeBorderAroundWindowProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for ResizeBorderAroundWindow.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ResizeBorderAroundWindowProperty =
        //    DependencyProperty.Register("ResizeBorderAroundWindow", typeof(int), typeof(CustomMainWindow), new PropertyMetadata(6, OnResizeBorderAroundWindowChanged));

        //private static void OnResizeBorderAroundWindowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    d.CoerceValue(ResizeBorderThicknessProperty);
        //}

        //public int RadiusWindowEdges
        //{
        //    get { return IsWindowBorderless ? 0 : (int)GetValue(RadiusWindowEdgesProperty); }
        //    set { SetValue(RadiusWindowEdgesProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for RadiusWindowEdges.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty RadiusWindowEdgesProperty =
        //    DependencyProperty.Register("RadiusWindowEdges", typeof(int), typeof(CustomMainWindow), new PropertyMetadata(0, OnRadiusWindowEdgesChanged));

        //private static void OnRadiusWindowEdgesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    d.CoerceValue(OuterMarginSizeProperty);
        //}

        ///// <summary>
        ///// The margin around the window to allow for a drop shadow
        ///// </summary>
        //public int OuterMarginSize
        //{
        //    get { return (int)GetValue(OuterMarginSizeProperty); }
        //    set { SetValue(OuterMarginSizeProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for OuterMarginSize.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty OuterMarginSizeProperty =
        //    DependencyProperty.Register("OuterMarginSize", typeof(int), typeof(CustomMainWindow), new PropertyMetadata(0, ONOuterMarginSizeChanged, OnOuterMarginSizeCoerced));

        //private static void ONOuterMarginSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    d.CoerceValue(ResizeBorderThicknessProperty);
        //}

        //private static object OnOuterMarginSizeCoerced(DependencyObject d, object baseValue)
        //{
        //    var window = (CustomMainWindow)d;
        //    return window.IsWindowBorderless ? 0 : window.RadiusWindowEdges;
        //}


        public bool IsWindowBorderless { get => WindowState == WindowState.Maximized || _dockPosition != WindowDockPosition.Undocked; }
        private static int _outerMarginSize = 10;
        public Thickness OuterMarginSize
        {
            get { return IsWindowBorderless ? new Thickness(0) : (Thickness)GetValue(OuterMarginSizeProperty); }
            set { SetValue(OuterMarginSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OuterMarginSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OuterMarginSizeProperty =
            DependencyProperty.Register("OuterMarginSize", typeof(Thickness), typeof(CustomMainWindow), new PropertyMetadata(new Thickness(_outerMarginSize), OnOuterMarginSizeChanged));

        private static void OnOuterMarginSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.CoerceValue(ResizeBorderThicknessProperty);
        }

        private static int _resizeBorderAroundWindow = 6;
        public Thickness ResizeBorderThickness
        {
            get { return (Thickness)GetValue(ResizeBorderThicknessProperty); }
            set { SetValue(ResizeBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ResizeBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ResizeBorderThicknessProperty =
            DependencyProperty.Register("ResizeBorderThickness", typeof(Thickness), typeof(CustomMainWindow), new PropertyMetadata(new Thickness(_resizeBorderAroundWindow), null, OnResizeBorderThicknessCoerced));

        private static object OnResizeBorderThicknessCoerced(DependencyObject d, object baseValue)
        {
            var window = (CustomMainWindow)d;
            return new Thickness(_resizeBorderAroundWindow + window.OuterMarginSize.Left,
                _resizeBorderAroundWindow + window.OuterMarginSize.Top,
                _resizeBorderAroundWindow + window.OuterMarginSize.Right,
                _resizeBorderAroundWindow + window.OuterMarginSize.Bottom);
        }
    }
}
