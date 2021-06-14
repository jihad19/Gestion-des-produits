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
    public partial class StudioPage : ContentPage
    {
         public StudioPage()
        {
            InitializeComponent();
            //NavigationPage.SetHasNavigationBar(this, false);

        }

        private void Plus_Clicked(object sender, EventArgs e)
        {
            int x = int.Parse(num1.Text);
            int y = int.Parse(num2.Text);
            int result = x + y;
            Tasbe7.Text = result.ToString();
        }

        private void Moins_Clicked(object sender, EventArgs e)
        {
            int x = int.Parse(num1.Text);
            int y = int.Parse(num2.Text);
            int result = x - y;
            Tasbe7.Text = result.ToString();
        }

        private void Fois_Clicked(object sender, EventArgs e)
        {
            int x = int.Parse(num1.Text);
            int y = int.Parse(num2.Text);
            int result = x * y;
            Tasbe7.Text = result.ToString();
        }
        private void Mult_Clicked(object sender, EventArgs e)
        {
            int x = int.Parse(num1.Text);
            int y = int.Parse(num2.Text);
            int result = x / y;
            Tasbe7.Text = result.ToString();
        }

        

        
    }
}