using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Entity mvs)
        {
            InitializeComponent();
            foto.Source = mvs.Resimi;
            label1.Text = mvs.Adi;
            label2.Text = mvs.Fiyati.ToString();

        }
    }
}