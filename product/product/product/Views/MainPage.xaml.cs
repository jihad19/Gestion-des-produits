using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace product
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Date", TstDate.Date.ToString("dd/MM/yyyy"), "Ok", "Cancel");
            //DisplayPromptAsync("Get your number", "First Number");
            Navigation.PushAsync(new StudioPage());
            //Navigation.PopAsync();
        }
    }
}
