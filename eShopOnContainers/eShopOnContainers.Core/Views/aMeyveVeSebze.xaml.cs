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
    public partial class aMeyveVeSebze : ContentPage
    {
        List<Urun> meyveVeSebze1;
        List<Urun> meyveVeSebze2;
        public aMeyveVeSebze()
        {
            InitializeComponent();
            meyveVeSebze1 = new List<Urun> {
             new Urun{Name="Domates", Price=17.5f, Image="Domates.jpg"},
             new Urun{Name="Soğan", Price=19.5f, Image="sogan.jpg" },
             new Urun{Name="Portakal", Price=18.5f, Image="portakal.jpg"},
             new Urun{Name="Maydonoz", Price=19.5f, Image="maydonoz.jpg" },
            };
            meyveVeSebze2 = new List<Urun> {
            new Urun{Name="Salatalık", Price=9.5f, Image="salatalik.jpg"},
             new Urun{Name="Kıvırcık", Price=1.5f, Image="kivircik.jpg"},
             new Urun{Name="Nane", Price=19.5f, Image="nane.jpg"},
             new Urun{Name="Muz", Price=11.5f, Image="muz.jpg"}
            };
            lst1.ItemsSource = meyveVeSebze1;
            lst2.ItemsSource = meyveVeSebze2;
        }

        
    }
}