using product.Views;
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
    public partial class FirstPage : MasterDetailPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void Regis_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MainPage());
        }

        private void Log_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new LoginPage());

        }

        private void stu_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new StudioPage());

        }

        private void alb_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AlbumPage());

        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AddProduct());

        }
    }
}