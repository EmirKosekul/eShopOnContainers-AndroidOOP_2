using eShopOnContainers.Core.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.SendData
{
    public class SendDataService : ISendDataService
    {
        FirebaseClient client;
        public SendDataService()
        {
            client = new FirebaseClient("https://oop2-6c2c3-default-rtdb.firebaseio.com/");
        }
        public async void send(Urun urun)   
        {
              await client.Child("Sepet").PostAsync(urun);
        }      
    }
}
