using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HCC_Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pages.FirstLaunch();
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
