using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MauiAppEF
{
    using Microsoft.Maui.Controls;
    namespace StudentManagementApp
    {
        public partial class StudentsPage : ContentPage
        {
            private ListView StudentsListView;

            public StudentsPage()
            {
                InitializeComponent();
                StudentsListView = new ListView();
                LoadStudents();
            }
            private void InitializeComponent()
            {
                // This method is usually auto-generated in the .xaml.cs file
                // Ensure that the XAML file is properly linked to this code-behind file
            }

            private void LoadStudents()
            {
                StudentsListView.ItemsSource = App.DbContext.Students.ToList();
            }

            private void OnAddStudentClicked(object sender, EventArgs e)
            {
                // Diák hozzáadása logika
            }
        }
    }
}
