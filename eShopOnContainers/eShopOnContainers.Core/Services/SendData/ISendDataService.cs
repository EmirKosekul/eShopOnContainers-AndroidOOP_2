using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.SendData
{
    public interface ISendDataService
    {
        void send(Urun urun);
    }
}
