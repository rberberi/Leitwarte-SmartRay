using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows;
using System;
using System.Windows.Media;

namespace SmartRay_Leitwarte.Pages.NLA480
{
    /// <summary>
    /// Interaktionslogik für OP30.xaml
    /// </summary>
    public partial class OP30 : Page
    {
        public OP30()
        {
            InitializeComponent();
            //LINE CHART

            SeriesCollectionLineChart = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Fehlerquote",
                    Values = new ChartValues<double> { 22, 24, 25, 28 ,20, 20, 24, 25, 28, 25, 26 },
                    Stroke = Brushes.Red,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 15

                },
            };//LINE CHART

            LabelsLineChart = new[] { "01.01.2018", "02.01.2018", "03.01.2018", "04.01.2018",
                                    "05.01.2018", "06.01.2018", "07.01.2018", "08.01.2018", "09.01.2018", "10.05.2018" };

            DataContext = this;


        }//PAGE OP30

        private void PieChart_Loaded(object sender, RoutedEventArgs e)
        {
            PointLabel = chartPoint =>
            string.Format("{0}", chartPoint.Y);
            //string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);


            DataContext = this;
        }
        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 8;
        }



        public Func<ChartPoint, string> PointLabel { get; set; }
        public SeriesCollection SeriesCollectionLineChart { get; set; }
        public string[] LabelsLineChart { get; set; }


        #region DateTime Picker
        private void btn_dateTime2_Click(object sender, RoutedEventArgs e)
        {
            this.sp_dateTime2.Visibility = this.sp_dateTime2.Visibility == Visibility.Visible
                ? Visibility.Collapsed
                : Visibility.Visible;
            this.sp_dateTime1.Visibility = Visibility.Collapsed;
        }

        private void btn_dateTime1_Click(object sender, RoutedEventArgs e)
        {
            this.sp_dateTime1.Visibility = this.sp_dateTime1.Visibility == Visibility.Visible
                ? Visibility.Collapsed
                : Visibility.Visible;
            this.sp_dateTime2.Visibility = Visibility.Collapsed; 
        }

        private void btn_auswertung_dt1_Click(object sender, RoutedEventArgs e)
        {
            this.sp_dateTime1.Visibility = Visibility.Collapsed;
        }

        private void btn_auswertung_dt2_Click(object sender, RoutedEventArgs e)
        {
            this.sp_dateTime2.Visibility = Visibility.Collapsed;
        }
        #endregion

    }//CLASS
}//NAMESPACE
