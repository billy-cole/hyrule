using Xamarin.Forms;
using Microcharts;
using SkiaSharp;
using McEntry = Microcharts.Entry;
using System;
using System.Collections.Generic;

namespace MicroChartPicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CreateCharts();
            PopulatePicker();
        }

        private void PopulatePicker()
        {
            var chartTypeList = new List<string>
            {
                "Bar Chart",
                "Donut Chart",
                "Radial Chart"
            };

            ChartPicker.ItemsSource = chartTypeList;
        }

        private void CreateCharts()
        {
            var entries = new List<McEntry>()
            {
                new McEntry(17)
                {
                    Label = "MH: World Small Monsters",
                    Color = SKColor.Parse("#008e34"),
                },
                new McEntry(34)
                {
                    Label = "MH: World Large Monsters",
                    Color = SKColor.Parse("#003489"),
                },
                new McEntry(34)
                {
                    Label = "MH: Generations Small Monsters",
                    Color = SKColor.Parse("#e004a5"),
                },
                new McEntry(74)
                {
                    Label = "MH: Generations Large Monsters",
                    Color = SKColor.Parse("#04e0b4"),
                }
            };

            var barChart   = new BarChart()   { Entries = entries };
            var donutChart = new DonutChart() { Entries = entries };
            var radialChart  = new RadialGaugeChart()  { Entries = entries };

            BarChart.Chart   = barChart;
            DonutChart.Chart = donutChart;
            RadialChart.Chart = radialChart;
        }

        private void Handle_ChartPickerIndexChanged(object sender, EventArgs e)
        {
            Picker chartPicker = (Picker)sender;
            string selectedChart = (string)chartPicker.SelectedItem;

            if (selectedChart.Equals("Bar Chart"))
            {
                BarChart.IsVisible = true;
                DonutChart.IsVisible = false;
                RadialChart.IsVisible = false;
            }
            if (selectedChart.Equals("Donut Chart"))
            {
                BarChart.IsVisible = false;
                DonutChart.IsVisible = true;
                RadialChart.IsVisible = false;
            }
            if (selectedChart.Equals("Radial Chart"))
            {
                BarChart.IsVisible = false;
                DonutChart.IsVisible = false;
                RadialChart.IsVisible = true;
            }
        }
    }
}
