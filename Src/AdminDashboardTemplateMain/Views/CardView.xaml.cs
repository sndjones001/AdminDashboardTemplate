//using LiveCharts;
//using LiveCharts.Wpf;
using System;
using System.Windows.Controls;

namespace AdminDashboardTemplateMain.Views
{
    /// <summary>
    /// Interaction logic for CardView.xaml
    /// </summary>
    public partial class CardView : UserControl
    {
        //public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        public CardView()
        {
            InitializeComponent();

            //SeriesCollection = new SeriesCollection
            //{
            //    new ColumnSeries
            //    {
            //        //Title = "2015",
            //        Values = new ChartValues<double> { 10, 50, 39, 50 }
            //    }
            //};

            ////adding series will update and animate the chart automatically
            //SeriesCollection.Add(new ColumnSeries
            //{
            //    //Title = "2016",
            //    Values = new ChartValues<double> { 11, 56, 42 }
            //});

            ////also adding values updates and animates the chart automatically
            //SeriesCollection[1].Values.Add(48d);

            //Labels = new[] { "Maria", "Susan", "Charles", "Frida" };
            //Formatter = value => value.ToString("N");

            this.DataContext = this;
        }
    }
}
