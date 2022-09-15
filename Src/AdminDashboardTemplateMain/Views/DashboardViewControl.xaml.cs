using LiveCharts.Maps;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace AdminDashboardTemplateMain.Views
{
    /// <summary>
    /// Interaction logic for DashboardViewControl.xaml
    /// </summary>
    public partial class DashboardViewControl : UserControl
    {
        public DashboardViewControl()
        {
            InitializeComponent();

            var r = new Random();

            Values = new Dictionary<string, double>();

            Values["MX"] = r.Next(0, 100);
            Values["CA"] = r.Next(0, 100);
            Values["US"] = r.Next(0, 100);
            Values["IN"] = r.Next(0, 100);
            Values["CN"] = r.Next(0, 100);
            Values["JP"] = r.Next(0, 100);
            Values["BR"] = r.Next(0, 100);
            Values["DE"] = r.Next(0, 100);
            Values["FR"] = r.Next(0, 100);
            Values["GB"] = r.Next(0, 100);

            LanguagePack = new Dictionary<string, string>();
            LanguagePack["MX"] = "México"; // change the language if necessary

            DataContext = this;
        }

        public Dictionary<string, MapData> Lands { get; set; }
        public Dictionary<string, double> Values { get; set; }
        public Dictionary<string, string> LanguagePack { get; set; }
    }
}
