using eShopOnContainers.Core.Models.Katagori;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.Katagoriler
{
    public class KatagoriService : IKatagoriService
    {
        FirebaseClient client;
        public KatagoriService()
        {
            client = new FirebaseClient("https://oop2-6c2c3-default-rtdb.firebaseio.com/");
        }
        public  ObservableCollection<KatagoriTurleri> getKatagori()
        {
            var katagoriAl = client.Child("Katagoriler").AsObservable<KatagoriTurleri>().AsObservableCollection();
            return katagoriAl;
        }
    }
}
