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
    public partial class Ara : ContentPage
    {
        List<Entity> list;
        List<Entity> list2;
        List<Entity> listEmpty;
        public Ara()
        {
            InitializeComponent();
            listEmpty = new List<Entity>();
            list2 = new List<Entity>();
            list = new List<Entity>{
             new Entity{Adi="Eti Karam", Fiyati=7.35, Resimi="karam.jpg", Tagi="cik" , Navigationpage="Domates"},
             new Entity{Adi="Ülker Petibör", Fiyati=2.90, Resimi="ulkerpeti.jpg", Tagi="kek"},
             new Entity{Adi="Ülker Çubuk", Fiyati=10.9, Resimi="ulkercubuk.jpg", Tagi="kraker",Navigationpage="hazir"},
             new Entity{Adi="Ülker Çikolata", Fiyati=8.90, Resimi="ulker.jpg", Tagi="cik"},
             new Entity{Adi="Eti Burçak", Fiyati=11.90, Resimi="burcak.jpg", Tagi="kek"},
             new Entity{Adi="Eti Çubuk", Fiyati=9.5, Resimi="eticubuk.jpg", Tagi="kraker"},
             new Entity{Adi="Piliç Tavuk", Fiyati=7.35, Resimi="tavuk.jpg", Tagi="beyaz" , Navigationpage="Domates"},
             new Entity{Adi="Köfte", Fiyati=2.90, Resimi="kofte.jpg", Tagi="kirmizi"},
             new Entity{Adi="Balık", Fiyati=10.9, Resimi="balik.jpg", Tagi="deniz",Navigationpage="hazir"},
             new Entity{Adi="Şinitzel", Fiyati=8.90, Resimi="sinitzel.jpg", Tagi="beyaz"},
             new Entity{Adi="Kokoreç", Fiyati=11.90, Resimi="kokorec.jpg", Tagi="kirmizi"},
             new Entity{Adi="Ton Balığı", Fiyati=9.5, Resimi="ton.jpg", Tagi="deniz"},
             new Entity{Adi="Hayat Su 10L", Fiyati=17.35, Resimi="hayatsu.jpg", Tagi="su" , Navigationpage="Domates"},
             new Entity{Adi="Kızılay Maden Suyu", Fiyati=9.90, Resimi="kizilaymaden.jpg", Tagi="su"},
             new Entity{Adi="Pepsi", Fiyati=10.9, Resimi="pepsi.jpg", Tagi="gazli",Navigationpage="Portakal"},
             new Entity{Adi="Lipton Ice Tea", Fiyati=7.90, Resimi="lipton.jpg", Tagi="gazsiz"},
             new Entity{Adi="Akmina Maden Suyu", Fiyati=8.90, Resimi="akminamaden.jpg", Tagi="su"},
             new Entity{Adi="Coca Cola", Fiyati=11.90, Resimi="coca.jpg", Tagi="gazli"},
             new Entity{Adi="Bi Cola", Fiyati=19.5, Resimi="bicola.jpg", Tagi="gazli"},
             new Entity{Adi="Limonata", Fiyati=14.5, Resimi="limonata.jpg", Tagi="gazsiz" },
             new Entity{Adi="Domates", Fiyati=17.5, Resimi="Domates.jpg", Tagi="Sebze" , Navigationpage="Domates"},
             new Entity{Adi="Soğan", Fiyati=19.5, Resimi="sogan.jpg", Tagi="Sebze"},
             new Entity{Adi="Portakal", Fiyati=18.5, Resimi="portakal.jpg", Tagi="Meyve",Navigationpage="Portakal"},
             new Entity{Adi="Maydonoz", Fiyati=19.5, Resimi="maydonoz.jpg", Tagi="Yeşillik"},
             new Entity{Adi="Salatalık", Fiyati=9.5, Resimi="salatalik.jpg", Tagi="Sebze"},
             new Entity{Adi="Kıvırcık", Fiyati=1.5, Resimi="kivircik.jpg", Tagi="Yeşillik"},
             new Entity{Adi="Nane", Fiyati=19.5, Resimi="nane.jpg", Tagi="Yeşillik"},
             new Entity{Adi="Muz", Fiyati=11.5, Resimi="muz.jpg", Tagi="Meyve" },
             new Entity{Adi="Meşrubat Bardağı", Fiyati=17.35, Resimi="mesrubat.jpg", Tagi="z" , Navigationpage="Domates"},
             new Entity{Adi="Buzdolabı Poşeti", Fiyati=9.90, Resimi="buzdolabiposeti.jpg", Tagi="ms"},
             new Entity{Adi="Çay Bardağı", Fiyati=8.90, Resimi="caybardagi.jpg", Tagi="z"},
             new Entity{Adi="Karton Tabak", Fiyati=11.90, Resimi="kartontabak.jpg", Tagi="ms"},
             new Entity{Adi="Künefe", Fiyati=17.35, Resimi="kunefe.jpg", Tagi="tatli" , Navigationpage="Domates"},
             new Entity{Adi="Ekmek", Fiyati=2.90, Resimi="ekmek.jpg", Tagi="ekmek"},
             new Entity{Adi="Hazır Pasta Keki", Fiyati=10.9, Resimi="hazirpasta.jpg", Tagi="hazir",Navigationpage="hazir"},
             new Entity{Adi="Mozaik Pasta", Fiyati=8.90, Resimi="mozaik.jpg", Tagi="tatli"},
             new Entity{Adi="Lavaş", Fiyati=11.90, Resimi="lavas.jpg", Tagi="ekmek"},
             new Entity{Adi="Galeta", Fiyati=9.5, Resimi="galeta.jpg", Tagi="hazir"}
            };

        }
        private async void icecek_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Icecek());
        }
        private async void meyve_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new MeyveVeSebze());
        }
        private async void mutfak_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Mutfak());
        }
        private async void unlu_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new UnluMamuller());
        }
        private async void atistirmalik_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Atistirmalik());
        }
        private async void et_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new EtTavuk());
        }
        private void lst1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            Navigation.PushModalAsync(new DetailPage(e.Item as Entity));
        }
        private void entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (var item in list)
            {
                if (item.Adi.Contains(entry.Text))
                {
                    list2.Add(item);
                }
            }
            lst1.ItemsSource = list2;
        }
    }
}