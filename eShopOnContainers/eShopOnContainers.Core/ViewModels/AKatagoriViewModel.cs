using eShopOnContainers.Core.Models.Katagori;
using eShopOnContainers.Core.Services.Katagoriler;
using eShopOnContainers.Core.Services.KatagorilerAnaSayfa;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class AKatagoriViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        IAKatagoriService kService;
        private ObservableCollection<KatagoriTurleri> kt;
        private ObservableCollection<KatagoriTurleri> kt2;
        private ObservableCollection<KatagoriTurleri> kt3;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public AKatagoriViewModel()
        {
            kService = new AKatagoriService();
            KT = GetKatagori();
            KT2 = GetKatagori2();
            KT3 = GetKatagori3();
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
        public ObservableCollection<KatagoriTurleri> KT2
        {
            get { return kt2; }
            set
            {
                kt2 = value;
                OnPropertyChanged("KatagoriTurleri");
            }
        }
        public ObservableCollection<KatagoriTurleri> KT3
        {
            get { return kt3; }
            set
            {
                kt3 = value;
                OnPropertyChanged("KatagoriTurleri");
            }
        }
        private ObservableCollection<KatagoriTurleri> GetKatagori()
        {
            return kService.AgetKatagori();
        }
        private ObservableCollection<KatagoriTurleri> GetKatagori2()
        {
            return kService.AgetKatagori2();
        }
        private ObservableCollection<KatagoriTurleri> GetKatagori3()
        {
            return kService.AgetKatagori3();
        }
    }
}
