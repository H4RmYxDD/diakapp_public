using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEF
{
    public partial class SubjectsPage : ContentPage
    {
        public SubjectsPage()
        {
            InitializeComponent();
            LoadSubjects();
        }
        private void InitializeComponent()
        {
            // This method is usually auto-generated in the .xaml.cs file
            // Ensure that the XAML file is properly linked to this code-behind file
        }
        private void OnAddSubjectClicked(object sender, EventArgs e)
        {
            // Tantárgy hozzáadása logika
        }
        private void LoadSubjects()
        {
            // Assuming SubjectsPageListview is a ListView defined in the XAML file
            var subjectsPageListview = this.FindByName<ListView>("SubjectsPageListview");
            subjectsPageListview.ItemsSource = App.DbContext.Subjects.ToList();
        }
    }
}
