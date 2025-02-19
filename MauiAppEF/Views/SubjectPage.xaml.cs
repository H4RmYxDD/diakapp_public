using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEF.Views
{
    public partial class SubjectsPage : ContentPage
    {
        public SubjectsPage()
        {
            InitializeComponent();
            LoadSubjects();
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
