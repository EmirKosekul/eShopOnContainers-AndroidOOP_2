using eShopOnContainers.Core.Models;
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
        private ObservableCollection<Urun> kt;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public KatagoriViewModel()
        {
            kService = new KatagoriService();
            KT = GetKatagori();
        }
        public ObservableCollection<Urun> KT
        {
            get { return kt; }
            set
            {
                kt = value;
                OnPropertyChanged("Urun");
            }
        }

        private ObservableCollection<Urun> GetKatagori()
        {
            return kService.getKatagori();
        }
        
    }
}
