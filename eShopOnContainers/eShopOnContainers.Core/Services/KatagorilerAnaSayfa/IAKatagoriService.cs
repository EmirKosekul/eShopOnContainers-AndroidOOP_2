using eShopOnContainers.Core.Models.Katagori;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.Services.KatagorilerAnaSayfa
{
   public  interface IAKatagoriService
    {
        ObservableCollection<KatagoriTurleri> AgetKatagori();
        ObservableCollection<KatagoriTurleri> AgetKatagori2();
        ObservableCollection<KatagoriTurleri> AgetKatagori3();
    }
}
