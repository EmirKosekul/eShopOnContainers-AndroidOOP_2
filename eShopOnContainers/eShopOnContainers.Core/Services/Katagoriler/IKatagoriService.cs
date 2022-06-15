using eShopOnContainers.Core.Models.Katagori;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.Katagoriler
{
   public interface IKatagoriService
    {
         ObservableCollection<KatagoriTurleri> getKatagori();
    }
}
