using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace product
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FirstPage();
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
