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
            GetListService.GetListAsync(List);
        }
    }
}
