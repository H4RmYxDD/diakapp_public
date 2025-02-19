using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MauiAppEF
{
    public partial class StatisticsPage : ContentPage
    {
        public ListView StatisticsListView { get; set; }

        public StatisticsPage()
        {
            InitializeComponent();
            StatisticsListView = new ListView();
            CalculateStatistics();
        }

        private void InitializeComponent()
        {
            // This method is usually auto-generated in the .xaml.cs file
            // Ensure that the XAML file is properly linked to this code-behind file
        }
        private void CalculateStatistics()
        {
            var stats = App.DbContext.Grades
                        .GroupBy(g => g.StudentId)
                        .Select(g => new { StudentId = g.Key, AvgGrade = g.Average(x => x.Grade) })
                        .ToList();
            StatisticsListView.ItemsSource = stats;
        }
    }
}
