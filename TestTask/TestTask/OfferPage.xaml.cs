using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.DataClasses;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TestTask
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferPage : ContentPage
    {
        public OfferPage(Offer offer)
        {
            InitializeComponent();
            string JSONstring = JsonConvert.SerializeObject(offer, new
            JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
            });
            TestLabel.Text = JSONstring;
        }
    }
}