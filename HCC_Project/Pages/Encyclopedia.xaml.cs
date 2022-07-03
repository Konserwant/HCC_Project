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
    public partial class Encyclopedia : ContentPage
    {
        public Encyclopedia()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.FindPlantPages.PlantsList());
        }
    }
}