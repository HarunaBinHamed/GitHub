using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProduct.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DuaDetail : ContentPage
    {
        
        public DuaDetail(string Name, string Location, string ImageUrl)
        
        {   
            InitializeComponent();
            MyItemNameShow.Text = Name;
            MyLocationItemShow.Text = Location;
            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(ImageUrl)
            };

        }
    }
}