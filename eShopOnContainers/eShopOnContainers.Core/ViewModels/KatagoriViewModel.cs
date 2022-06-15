using eShopOnContainers.Core.Models.Katagori;
using eShopOnContainers.Core.Services.Dependency;
using eShopOnContainers.Core.Services.Katagoriler;
using eShopOnContainers.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.ViewModels
{
    public class KatagoriViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        IKatagoriService kService;
        private ObservableCollection<KatagoriTurleri> kt;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public KatagoriViewModel()
        {
            kService = new KatagoriService();
            KT = GetKatagori();
        }
        public ObservableCollection<KatagoriTurleri> KT
        {
            get { return kt; }
            set
            {
                kt = value;
                OnPropertyChanged("KatagoriTurleri");
            }
        }

        private ObservableCollection<KatagoriTurleri> GetKatagori()
        {
            return kService.getKatagori();
        }
        //public ObservableCollection<KatagoriTurleri> Products
        //{
        //    get => _products;
        //    set
        //    {
        //        _products = value;
        //        RaisePropertyChanged(() => Products);
        //    }
        //}

        //public override async Task InitializeAsync(IDictionary<string, string> query)
        //{

        //    // Get Catalog, Brands and Types
        //    Products = await kService.getKatagori();

        //}



        //private ObservableCollection<KatagoriTurleri> GetKatagori()
        //{
        //   return kService.getKatagori();
        //}
    }
}
