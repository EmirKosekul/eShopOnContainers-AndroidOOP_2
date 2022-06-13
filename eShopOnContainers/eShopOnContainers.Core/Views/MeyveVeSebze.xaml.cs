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
    public partial class MeyveVeSebze : ContentPage
    {
        List<Entity> meyveVeSebze1;
        List<Entity> meyveVeSebze2;
        List<Entity> meyve1 = new List<Entity> { };
        List<Entity> meyve2 = new List<Entity> { };
        List<Entity> sebze1 = new List<Entity> { };
        List<Entity> sebze2 = new List<Entity> { };
        List<Entity> yesillik1 = new List<Entity> { };
        List<Entity> yesillik2 = new List<Entity> { };
        public MeyveVeSebze()
        {
            InitializeComponent();
            meyveVeSebze1 = new List<Entity> {
             new Entity{Adi="Domates", Fiyati=17.5, Resimi="Domates.jpg", Tagi="Sebze" , Navigationpage="Domates"},
             new Entity{Adi="Soğan", Fiyati=19.5, Resimi="sogan.jpg", Tagi="Sebze"},
             new Entity{Adi="Portakal", Fiyati=18.5, Resimi="portakal.jpg", Tagi="Meyve",Navigationpage="Portakal"},             
             new Entity{Adi="Maydonoz", Fiyati=19.5, Resimi="maydonoz.jpg", Tagi="Yeşillik"},
            };
            meyveVeSebze2 = new List<Entity> {
            new Entity{Adi="Salatalık", Fiyati=9.5, Resimi="salatalik.jpg", Tagi="Sebze"},
             new Entity{Adi="Kıvırcık", Fiyati=1.5, Resimi="kivircik.jpg", Tagi="Yeşillik"},
             new Entity{Adi="Nane", Fiyati=19.5, Resimi="nane.jpg", Tagi="Yeşillik"},
             new Entity{Adi="Muz", Fiyati=11.5, Resimi="muz.jpg", Tagi="Meyve" }
            };
            meyve1 = new List<Entity> { };
            meyve2 = new List<Entity> { };
            sebze1 = new List<Entity> { };
            sebze2 = new List<Entity> { };
            yesillik1 = new List<Entity> { };
            yesillik2 = new List<Entity> { };
            
            foreach (var item in meyveVeSebze1)
            {
                if (item.Tagi == "Meyve")
                {
                    meyve1.Add(item);
                }
            }
            foreach (var item in meyveVeSebze2)
            {
                if (item.Tagi == "Meyve")
                {
                    meyve2.Add(item);
                }
            }
            foreach (var item in meyveVeSebze1)
            {
                if (item.Tagi == "Sebze")
                {
                    sebze1.Add(item);
                }
            }
            foreach (var item in meyveVeSebze2)
            {
                if (item.Tagi == "Sebze")
                {
                    sebze2.Add(item);
                }
            }
            foreach (var item in meyveVeSebze1)
            {
                if (item.Tagi == "Yeşillik")
                {
                    yesillik1.Add(item);
                }
            }
            foreach (var item in meyveVeSebze2)
            {
                if (item.Tagi == "Yeşillik")
                {
                    yesillik2.Add(item);
                }
            }
            lst1.ItemsSource = meyveVeSebze1;
            lst2.ItemsSource = meyveVeSebze2;
        }
        private void meyveBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = meyve1;
            lst2.ItemsSource = meyve2;
        }
        private void sebzeBtn_Clicked(object sender, EventArgs e/*,List<MeyveVeSebzeNesne> sbz1, List<MeyveVeSebzeNesne> sbz2*/)
        {
            lst1.ItemsSource = sebze1;
            lst2.ItemsSource = sebze2;
        }
        private void yesillikBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = yesillik1;
            lst2.ItemsSource = yesillik2;
        }

        private void lst1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item==null)
            {
                return;
            }
            Navigation.PushModalAsync(new DetailPage(e.Item as Entity));
        }
        private void lst2_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            Navigation.PushModalAsync(new DetailPage(e.Item as Entity));
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
    }
}