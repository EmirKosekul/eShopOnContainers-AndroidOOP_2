using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.Services.Urunler
{
    public interface IUrunlerService
    {
        ObservableCollection<Urun> getUrunler();
        ObservableCollection<Urun> getUrunler2();
    }
}
