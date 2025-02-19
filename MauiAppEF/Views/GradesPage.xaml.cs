using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;


namespace MauiAppEF.Views
{
    public partial class GradesPage : ContentPage
    {
        public GradesPage()
        {
            InitializeComponent();
            LoadGrades();
        }
        private void LoadGrades()
        {
            //GradesListView.ItemsSource = App.DbContext.Grades.ToList();
        }
        private void OnAddGradeClicked(object sender, EventArgs e)
        {
            // Grade hozzáadása logika
        }
    }
}
