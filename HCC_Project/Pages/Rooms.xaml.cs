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
    public partial class Rooms : ContentPage
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.RoomConfig());
        }

        private async void BackToMenu(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.MainMenu());
        }
    }
}