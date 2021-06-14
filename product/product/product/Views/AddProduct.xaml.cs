using product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace product.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProduct : ContentPage
    {
        public AddProduct()
        {
            InitializeComponent();
            public string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "mydb.db3");

    }

    private void AddP_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<ProductModel>();
            var maxPk = db.Table<ProductModel>().OrderByDescending(c => c.Id).FirstOrDefault();

        ProductModel ProductModel = new ProductModel()
            {
                Id = (maxPk == null ? 1 : maxPk.Id + 1),
                Name = _nameEntry.Text,
                Description = _descriptionEntry.Text,
                Price = _priceEntry.Text,
            };

            db.Insert(ProductModel);
            await DisplayAlert(null, ProductModel.Name + "Saved", "Ok");
            await Navigation.PopAsync();
        }
    }
}