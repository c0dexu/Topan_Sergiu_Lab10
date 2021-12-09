using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using Topan_Sergiu_Lab10.Data;
using System.IO;

namespace Topan_Sergiu_Lab10
{
    public partial class App : Application
    {
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
