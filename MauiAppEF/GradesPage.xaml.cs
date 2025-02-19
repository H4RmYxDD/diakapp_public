using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;


namespace MauiAppEF
{
    public partial class GradesPage : ContentPage
    {
        public GradesPage()
        {
            InitializeComponent();
            LoadGrades();
        }
        private void InitializeComponent()
        {
            // This method is usually auto-generated in the .xaml.cs file
            // Ensure that the XAML file is properly linked to this code-behind file
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
