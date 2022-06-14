using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Models.Catalog;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.Services.Catalog
{
    public class CatalogMockService : ICatalogService
    {
        private ObservableCollection<CatalogBrand> MockCatalogBrand = new ObservableCollection<CatalogBrand>
        {
            // new CatalogBrand { Id = 1, Brand = "Azure" },
            //new CatalogBrand { Id = 2, Brand = "Visual Studio" }
            new CatalogBrand {Id = 1, Brand = "MeyveVeSebze" },
            new CatalogBrand { Id = 2, Brand = "Atistirmalik" },
            new CatalogBrand { Id = 3, Brand = "EtTavuk" }
        };

        private ObservableCollection<CatalogType> MockCatalogType = new ObservableCollection<CatalogType>
        {
            //new CatalogType { Id = 1, Type = "Mug" },
            //new CatalogType { Id = 2, Type = "T-Shirt" }
            new CatalogType { Id = 1, Type = "MeyveVeSebze" },
            new CatalogType { Id = 2, Type = "Atistirmalik" },
            new CatalogType { Id = 3, Type = "EtTavuk" }
        };

               

        private ObservableCollection<CatalogItem> MockCatalog = new ObservableCollection<CatalogItem>
        {
            //new CatalogItem { Id = Common.Common.MockCatalogItemId01, PictureUri = "fake_product_01.png", Name = ".NET Bot Blue Sweatshirt (M)", Price = 19.50M, CatalogBrandId = 2, CatalogBrand = "Visual Studio", CatalogTypeId = 2, CatalogType = "T-Shirt" },
            //new CatalogItem { Id = Common.Common.MockCatalogItemId02, PictureUri = "fake_product_02.png", Name = ".NET Bot Purple Sweatshirt (M)", Price = 19.50M, CatalogBrandId = 2, CatalogBrand = "Visual Studio", CatalogTypeId = 2, CatalogType = "T-Shirt" },
            //new CatalogItem { Id = Common.Common.MockCatalogItemId03, PictureUri = "fake_product_03.png", Name = ".NET Bot Black Sweatshirt (M)", Price = 19.95M, CatalogBrandId = 2, CatalogBrand = "Visual Studio", CatalogTypeId = 2, CatalogType = "T-Shirt" },
            //new CatalogItem { Id = Common.Common.MockCatalogItemId04, PictureUri = "fake_product_04.png", Name = ".NET Black Cupt", Price = 17.00M, CatalogBrandId = 2, CatalogBrand = "Visual Studio", CatalogTypeId = 1, CatalogType = "Mug" },
            //new CatalogItem { Id = Common.Common.MockCatalogItemId05, PictureUri = "fake_product_05.png", Name = "Azure Black Sweatshirt (M)", Price = 19.50M, CatalogBrandId = 1, CatalogBrand = "Azure", CatalogTypeId = 2, CatalogType = "T-Shirt" }
            new CatalogItem { Id = Common.Common.MockCatalogItemId01, PictureUri = "tavuk.jpg", Name = "Piliç Tavuk", Price = 19.50M,  CatalogTypeId = 3, CatalogType = "EtTavuk",CatalogBrandId = 3,CatalogBrand="MeyveVeSebze" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId02, PictureUri = "kofte.jpg", Name = "Köfte", Price = 10.50M, CatalogTypeId = 3, CatalogType = "EtTavuk",CatalogBrandId = 3,CatalogBrand="MeyveVeSebze" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId03, PictureUri = "balik.jpg", Name = "Balık", Price = 9.95M, CatalogTypeId = 3, CatalogType = "EtTavuk",CatalogBrandId = 3,CatalogBrand="MeyveVeSebze" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId04, PictureUri = "karam.jpg", Name = "Eti Karam", Price = 1.00M,CatalogTypeId = 2, CatalogType = "Atistirmalik",CatalogBrandId = 2,CatalogBrand="Atistirmalik" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId05, PictureUri = "ulkerpeti.jpg", Name = "Ülker Petibör", Price = 2.50M, CatalogTypeId = 2, CatalogType = "Atistirmalik",CatalogBrandId = 2,CatalogBrand="Atistirmalik" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId01, PictureUri = "ulkercubuk.jpg", Name = "Ülker Çubuk", Price = 1.50M,  CatalogTypeId = 2, CatalogType = "Atistirmalik",CatalogBrandId = 2,CatalogBrand="Atistirmalik" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId02, PictureUri = "Domates.jpg", Name = "Domates", Price = 4.50M, CatalogTypeId = 1, CatalogType = "MeyveVeSebze",CatalogBrandId = 1,CatalogBrand="EtTavuk" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId03, PictureUri = "sogan.jpg", Name = "Soğan", Price = 3.95M, CatalogTypeId = 1, CatalogType = "MeyveVeSebze",CatalogBrandId = 1,CatalogBrand="EtTavuk" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId03, PictureUri = "portakal.jpg", Name = "Portakal", Price = 2.95M, CatalogTypeId = 1, CatalogType = "MeyveVeSebze",CatalogBrandId = 1,CatalogBrand="EtTavuk" },
        };

        public async Task<ObservableCollection<CatalogItem>> GetCatalogAsync()
        {
            await Task.Delay(10);

            return MockCatalog;
        }

        public async Task<ObservableCollection<CatalogItem>> FilterAsync(int catalogBrandId, int catalogTypeId)
        {
            await Task.Delay(10);

            return MockCatalog
                .Where(c => c.CatalogBrandId == catalogBrandId &&
                c.CatalogTypeId == catalogTypeId)
                .ToObservableCollection();
        }

        public async Task<ObservableCollection<CatalogBrand>> GetCatalogBrandAsync()
        {
            await Task.Delay(10);

            return MockCatalogBrand;
        }

        public async Task<ObservableCollection<CatalogType>> GetCatalogTypeAsync()
        {
            await Task.Delay(10);

            return MockCatalogType;
        }
    }
}