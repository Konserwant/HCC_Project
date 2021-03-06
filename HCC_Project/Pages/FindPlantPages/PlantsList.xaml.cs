using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HCC_Project.Pages.FindPlantPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantsList : ContentPage
    {
        public PlantsList()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.MainMenu());
        }
    }
}