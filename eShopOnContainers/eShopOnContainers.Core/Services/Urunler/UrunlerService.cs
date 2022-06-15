using eShopOnContainers.Core.Models;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.Services.Urunler
{
    class UrunlerService : IUrunlerService
    {
        FirebaseClient client;
        public UrunlerService()
        {
            client = new FirebaseClient("https://oop2-6c2c3-default-rtdb.firebaseio.com/");
        }
        public ObservableCollection<Urun> getUrunler()
        {
            var urunAl = client.Child("Urunler1").AsObservable<Urun>().AsObservableCollection();
            return urunAl;
        }

        public ObservableCollection<Urun> getUrunler2()
        {
            var urunAl2 = client.Child("Urunler2").AsObservable<Urun>().AsObservableCollection();
            return urunAl2;
        }
    }
}
