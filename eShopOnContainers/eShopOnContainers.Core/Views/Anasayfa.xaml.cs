using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        List<ImageClass> list;
        public Anasayfa()
        {
            InitializeComponent();
            list = new List<ImageClass>()
            {
                new ImageClass{foto="https://ayb.akinoncdn.com/cms/2022/03/29/3c86a6a6-2664-4d51-b6d6-0412de31dbbf.jpg"},
                new ImageClass{foto="https://ayb.akinoncdn.com/cms/2022/04/25/c2d542a1-a36a-419e-88dc-8dae92fa3d3c.jpg"},
                new ImageClass{foto="https://ayb.akinoncdn.com/cms/2022/04/22/06aa82de-117e-4898-8588-bda98f3cfbbf.jpg"},
                new ImageClass{foto="https://ayb.akinoncdn.com/cms/2022/04/22/203fd6de-16af-4a93-822e-5814ac80f388.jpg"},
            };
            kaydirma.ItemsSource = list;
        }

        private async void Domates_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeyveVeSebze());
        }
        private async void Icecek_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Icecek());
        }
        private async void Mutfak_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Mutfak());
        }
        private async void UnluMamuller_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new UnluMamuller());
        }
        private async void Atistirmalik_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Atistirmalik());
        }
        private async void Et_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new EtTavuk());
        }
    }
}