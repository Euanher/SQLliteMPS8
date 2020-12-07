using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clothes
{
    public partial class App : Application
    {
        internal static string FilePath;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
