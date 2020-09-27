using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.DataClasses;
using Xamarin.Forms;

namespace TestTask
{
    public partial  class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetListAsync();

        }
        private async void GetListAsync()
        {
            IList<Offer> offers = new List<Offer>();
            Task<Yml_catalog> task = GetRequestService.Get<Yml_catalog>("http://partner.market.yandex.ru/pages/help/YML.xml");
            await task.ContinueWith(result =>
            {
                Yml_catalog catalog = result.Result;
                offers = catalog.shop.offers.offer;               
            });
            List.ItemsSource = offers;

        }


    }
}
