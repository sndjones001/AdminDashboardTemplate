using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuSwense.ModernControls.View
{
    public class ExpandCollapseButton : ToggleButton
    {
        static ExpandCollapseButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExpandCollapseButton), new FrameworkPropertyMetadata(typeof(ExpandCollapseButton)));
        }

        public Thickness InnerExpanderMargin
        {
            get { return (Thickness)GetValue(InnerExpanderMarginProperty); }
            set { SetValue(InnerExpanderMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for InnerExpanderMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InnerExpanderMarginProperty =
            DependencyProperty.Register("InnerExpanderMargin", typeof(Thickness), typeof(ExpandCollapseButton), new PropertyMetadata(new Thickness(0)));

        public enum EArrowStartType
        {
            Top,
            Left,
            Right,
            Bottom
        }

        public EArrowStartType ArrowStartType
        {
            get { return (EArrowStartType)GetValue(ArrowStartTypeProperty); }
            set { SetValue(ArrowStartTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArrowStartType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArrowStartTypeProperty =
            DependencyProperty.Register("ArrowStartType", typeof(EArrowStartType), typeof(ExpandCollapseButton), new PropertyMetadata(EArrowStartType.Top, OnArrowStartTypeChanged));

        private static void OnArrowStartTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.CoerceValue(ArrowMarginProperty);
            d.CoerceValue(PathDataProperty);
            d.CoerceValue(ArrowCheckedRotateDegreeProperty);
        }

        public PenLineCap ArrowLineCap
        {
            get { return (PenLineCap)GetValue(ArrowLineCapProperty); }
            set { SetValue(ArrowLineCapProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArrowLineCap.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArrowLineCapProperty =
            DependencyProperty.Register("ArrowLineCap", typeof(PenLineCap), typeof(ExpandCollapseButton), new PropertyMetadata(PenLineCap.Round));

        public PenLineJoin ArrowLineJoin
        {
            get { return (PenLineJoin)GetValue(ArrowLineJoinProperty); }
            set { SetValue(ArrowLineJoinProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArrowLineJoin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArrowLineJoinProperty =
            DependencyProperty.Register("ArrowLineJoin", typeof(PenLineJoin), typeof(ExpandCollapseButton), new PropertyMetadata(PenLineJoin.Round));

        private static Geometry[] _pathData =
        {
            Geometry.Parse("M0,8L4,4L8,8"),
            Geometry.Parse("M8,0L4,4L8,8"),
            Geometry.Parse("M0,0L4,4L0,8"),
            Geometry.Parse("M0,0L4,4L8,0"),
        };

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Geometry PathData
        {
            get { return (Geometry)GetValue(PathDataProperty); }
            protected set { SetValue(PathDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PathData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PathDataProperty =
            DependencyProperty.Register("PathData", typeof(Geometry), typeof(ExpandCollapseButton), new PropertyMetadata(_pathData[(int)EArrowStartType.Top], null, OnCoercePathData));

        private static object OnCoercePathData(DependencyObject d, object baseValue)
        {
            var thisObj = d as ExpandCollapseButton;

            if (thisObj == null) return baseValue;

            switch (thisObj.ArrowStartType)
            {
                case EArrowStartType.Top:
                    return _pathData[(int)EArrowStartType.Top];
                case EArrowStartType.Left:
                    return _pathData[(int)EArrowStartType.Left];
                case EArrowStartType.Right:
                    return _pathData[(int)EArrowStartType.Right];
                case EArrowStartType.Bottom:
                    return _pathData[(int)EArrowStartType.Bottom];
                default:
                    return baseValue;
            }
        }

        private static Thickness[] _arrowMargin =
        {
            new Thickness(1,0,1,0),
            new Thickness(1,0,1,0),
            new Thickness(1,0,1,0),
            new Thickness(1,0,1,0),
        };

        public Thickness ArrowMargin
        {
            get { return (Thickness)GetValue(ArrowMarginProperty); }
            set { SetValue(ArrowMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArrowMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArrowMarginProperty =
            DependencyProperty.Register("ArrowMargin", typeof(Thickness), typeof(ExpandCollapseButton), new PropertyMetadata(_arrowMargin[(int)EArrowStartType.Top], null, OnCoerceArrowMargin));

        private static object OnCoerceArrowMargin(DependencyObject d, object baseValue)
        {
            var thisObj = d as ExpandCollapseButton;

            if (thisObj == null) return baseValue;

            switch (thisObj.ArrowStartType)
            {
                case EArrowStartType.Top:
                    return _arrowMargin[(int)EArrowStartType.Top];
                case EArrowStartType.Left:
                    return _arrowMargin[(int)EArrowStartType.Left];
                case EArrowStartType.Right:
                    return _arrowMargin[(int)EArrowStartType.Right];
                case EArrowStartType.Bottom:
                    return _arrowMargin[(int)EArrowStartType.Bottom];
                default:
                    return baseValue;
            }
        }

        public double ArrowScale
        {
            get { return (double)GetValue(ArrowScaleProperty); }
            set { SetValue(ArrowScaleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArrowScale.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArrowScaleProperty =
            DependencyProperty.Register("ArrowScale", typeof(double), typeof(ExpandCollapseButton), new PropertyMetadata(0.7));

        public double ArrowStrokeThickness
        {
            get { return (double)GetValue(ArrowStrokeThicknessProperty); }
            set { SetValue(ArrowStrokeThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArrowStrokeThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArrowStrokeThicknessProperty =
            DependencyProperty.Register("ArrowStrokeThickness", typeof(double), typeof(ExpandCollapseButton), new PropertyMetadata(2.0));

        public Brush ArrowStroke
        {
            get { return (Brush)GetValue(ArrowStrokeProperty); }
            set { SetValue(ArrowStrokeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArrowStroke.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArrowStrokeProperty =
            DependencyProperty.Register("ArrowStroke", typeof(Brush), typeof(ExpandCollapseButton), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(164, 164, 164))));

        private static double[] _arrowCheckedRotateDegree =
        {
            90,
            -90,
            90,
            -90,
        };

        public double ArrowCheckedRotateDegree
        {
            get { return (double)GetValue(ArrowCheckedRotateDegreeProperty); }
            set { SetValue(ArrowCheckedRotateDegreeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArrowCheckedRotateDegree.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArrowCheckedRotateDegreeProperty =
            DependencyProperty.Register("ArrowCheckedRotateDegree", typeof(double), typeof(ExpandCollapseButton), new PropertyMetadata(_arrowCheckedRotateDegree[(int)EArrowStartType.Top], null, OnCoerceArrowCheckedRotateDegree));

        private static object OnCoerceArrowCheckedRotateDegree(DependencyObject d, object baseValue)
        {
            var thisObj = d as ExpandCollapseButton;

            if (thisObj == null) return baseValue;

            switch (thisObj.ArrowStartType)
            {
                case EArrowStartType.Top:
                    return _arrowCheckedRotateDegree[(int)EArrowStartType.Top];
                case EArrowStartType.Left:
                    return _arrowCheckedRotateDegree[(int)EArrowStartType.Left];
                case EArrowStartType.Right:
                    return _arrowCheckedRotateDegree[(int)EArrowStartType.Right];
                case EArrowStartType.Bottom:
                    return _arrowCheckedRotateDegree[(int)EArrowStartType.Bottom];
                default:
                    return baseValue;
            }
        }
    }
}
