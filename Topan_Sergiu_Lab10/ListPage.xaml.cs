using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topan_Sergiu_Lab10.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Topan_Sergiu_Lab10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (ShopList)BindingContext;
            slist.Date = DateTime.UtcNow;
            await App.Database.SaveShopListAsync(slist);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (ShopList)BindingContext;
            await App.Database.DeleteShopListAsync(slist);
            await Navigation.PopAsync();
        }
            public ListPage()
        {
            //InitializeComponent();
        }
    }
}