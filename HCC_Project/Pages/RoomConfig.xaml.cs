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
    public partial class RoomConfig : ContentPage
    {
        public RoomConfig()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.Rooms());
        }
    }
}