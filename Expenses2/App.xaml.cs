using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Expenses2.Views;
namespace Expenses2
{
    public partial class App : Application
    {
        public static string DatabasePath;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
        public App(string dbp)
        {
            InitializeComponent();

            DatabasePath = dbp;

            MainPage = new NavigationPage(new MainPage());

            
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
