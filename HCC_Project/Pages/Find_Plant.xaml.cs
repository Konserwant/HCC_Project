using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HCC_Project.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Find_Plant : ContentPage
    {
        public Find_Plant()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.FindPlantPages.PlantsList());
        }
        private async void OnButtonClickedRooms(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.Rooms());
        }
    }
}