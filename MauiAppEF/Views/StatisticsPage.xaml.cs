using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MauiAppEF.Views
{
    public partial class StatisticsPage : ContentPage
    {

        public StatisticsPage()
        {
            InitializeComponent();
            CalculateStatistics();
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
