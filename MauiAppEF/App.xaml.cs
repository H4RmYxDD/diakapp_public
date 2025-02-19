using MauiAppEF.Data;
using System;

namespace MauiAppEF
{
    public partial class App : Application
    {
       public static ApplicationDbContext DbContext { get; private set; }

        public App()
        {
            InitializeComponent();
            DbContext = new ApplicationDbContext();
            DbContext.Database.EnsureCreated();
            MainPage = new AppShell();
        }

    }
}