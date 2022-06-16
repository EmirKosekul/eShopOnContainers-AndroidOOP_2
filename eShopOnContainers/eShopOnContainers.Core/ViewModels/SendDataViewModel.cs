using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Services.SendData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    class SendDataViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        ISendDataService service;
        
        private ObservableCollection<Urun> sd;
        private ObservableCollection<Urun> sd2;
        private Urun data;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public SendDataViewModel()
        {
            service = new SendDataService();
            PostUrun();
            //PostUrun2();
        }
        
        public ICommand ButtonCommand
        {
            get
            {
                return new Command<Urun>((Urun value) =>
                    {
                         data = value;
                    });
            }
        }

        //public ObservableCollection<Urun> SD
        //{
        //    get { return sd; }

        //    set
        //    {
        //        if (sd != value)
        //        {
        //            value = sd;
        //            OnPropertyChanged("ObjPizzaList");
        //        }
        //    }
        //}
        //public ObservableCollection<Urun> SD2
        //{
        //    get { return sd2; }

        //    set
        //    {
        //        if (sd2 != value)
        //        {
        //            value = sd2;
        //            OnPropertyChanged("Urun");
        //        }
        //    }
        //}
        private void PostUrun()
        {
             service.send(data);
        }
        //private void PostUrun2()
        //{
        //  service.send(data);
        //}
    }
}
