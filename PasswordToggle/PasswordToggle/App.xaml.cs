using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PasswordToggle.Services;
using PasswordToggle.Views;

[assembly: ExportFont("FontAwesome5Regular.otf", Alias = "FontAwesome5Regular")]

namespace PasswordToggle
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
