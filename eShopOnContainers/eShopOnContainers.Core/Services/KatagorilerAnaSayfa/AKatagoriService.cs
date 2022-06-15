using eShopOnContainers.Core.Models.Katagori;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.Services.KatagorilerAnaSayfa
{
    public class AKatagoriService: IAKatagoriService
    {
        FirebaseClient client;
        public AKatagoriService()
        {
            client = new FirebaseClient("https://oop2-6c2c3-default-rtdb.firebaseio.com/");
        }

        public ObservableCollection<KatagoriTurleri> AgetKatagori()
        {
            var katagoriAl = client.Child("Katagoriler").AsObservable<KatagoriTurleri>().AsObservableCollection();
            return katagoriAl;
        }
        public ObservableCollection<KatagoriTurleri> AgetKatagori2()
        {
            var katagoriAl2 = client.Child("Katagoriler2").AsObservable<KatagoriTurleri>().AsObservableCollection();
            return katagoriAl2;
        }
        public ObservableCollection<KatagoriTurleri> AgetKatagori3()
        {
            var katagoriAl3 = client.Child("Katagoriler3").AsObservable<KatagoriTurleri>().AsObservableCollection();
            return katagoriAl3;
        }
    }
}
