using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.DataClasses;
using Xamarin.Forms;

namespace TestTask
{
    public partial class MainPage : ContentPage
    {
        public ListView ListView;
        public MainPage()
        {
            InitializeComponent();
            SetListService.SetListAsync(List);
        }
       
        async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Offer tappedItem = e.Item as Offer;
            await Navigation.PushAsync(new OfferPage(tappedItem));
        }
    }
}
