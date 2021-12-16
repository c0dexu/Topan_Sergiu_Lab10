using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Topan_Sergiu_Lab10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    ShopList sl;
    public ActivityPage(ShopList slist)
    {
        InitializeComponent();
        sl = slist;
    }

    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
        }
    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var product = (Product)BindingContext;
        await App.Database.SaveProductAsync(product);
        listView.ItemsSource = await App.Database.GetProductsAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var product = (Product)BindingContext;
        await App.Database.DeleteProductAsync(product);
        listView.ItemsSource = await App.Database.GetProductsAsync();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetProductsAsync();
    }

    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

        Product p;
        if (e.SelectedItem != null)
        {
            p = e.SelectedItem as Product;
            var lp = new ListProduct()
            {
                ShopListID = sl.ID,
                ProductID = p.ID
            };
            await App.Database.SaveListProductAsync(lp);
            p.ListProducts = new List<ListProduct> { lp };

            await Navigation.PopAsync();
        }
    }
    }