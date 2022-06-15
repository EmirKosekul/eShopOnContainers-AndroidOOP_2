using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Services.Urunler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    class UrunlerViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        IUrunlerService uService;
        private ObservableCollection<Urun> ut;
        private ObservableCollection<Urun> ut2;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public UrunlerViewModel()
        {
            uService = new UrunlerService();
            UT = GetUrun();
            UT2 = GetUrun2();
        }
        public ObservableCollection<Urun> UT
        {
            get { return ut; }
            set
            {
                ut = value;
                OnPropertyChanged("KatagoriTurleri");
            }
        }
        public ObservableCollection<Urun> UT2
        {
            get { return ut2; }
            set
            {
                ut2 = value;
                OnPropertyChanged("KatagoriTurleri");
            }
        }
        private ObservableCollection<Urun> GetUrun()
        {
            return uService.getUrunler();
        }
        private ObservableCollection<Urun> GetUrun2()
        {
            return uService.getUrunler2();
        }
    }
}
