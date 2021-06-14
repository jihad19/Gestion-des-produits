using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace product
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void AlbumPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AlbumPage());
        }

        private void StudioPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StudioPage());
        }

        private void RegisterPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void LoginPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}