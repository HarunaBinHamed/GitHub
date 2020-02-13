using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Geolocator;
namespace FinalProduct.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationalDuas : ContentPage
    {
        public LocationalDuas()
        {
            InitializeComponent();
            btnGenerator.Clicked += BtnGenerator_Clicked;
        }

        private async void BtnGenerator_Clicked(object sender, EventArgs e)
        {
            await RetreiveLocation();

        }

        private async Task RetreiveLocation()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 20;

            var position = await locator.GetPositionAsync();

            txtLat.Text ="Latitude" +  position.Latitude.ToString();
            txtLong.Text = "Longitude" + position.Longitude.ToString();
        }
    }
}