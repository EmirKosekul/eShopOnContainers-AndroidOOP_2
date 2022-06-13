using eShopOnContainers.Core.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace eShopOnContainers.Core.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}