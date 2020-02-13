using FinalProduct.ViewModel;
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
    public partial class Duas : ContentPage
    {
        public IList<DuaList> DuaList { get; private set; }

        public Duas()
        {
            InitializeComponent();
            BindingContext = new DuaViewModel();

           DuaList = new List<DuaList>();
            DuaList.Add(new DuaList
            {
                Name = "Home",
                Location = "The House Duas",
                ImageUrl = "home.png"
            });

            DuaList.Add(new DuaList
            {
                Name = "Travel",
                Location = "Dua when traveling",
                ImageUrl = "travel.jpg"
            });

            DuaList.Add(new DuaList
            {
                Name = "Mosque",
                Location = "Dua to the Mosque",
                ImageUrl = "mo2.jpg"
            });

            DuaList.Add(new DuaList
            {
                Name = "Life",
                Location = "Duas through life",
                ImageUrl = "travel.jpg"
            });

            DuaList.Add(new DuaList
            {
                Name = "Health",
                Location = "Duas to the Health",
                ImageUrl = "health.jfif"
            });
        
        BindingContext = this;
        }

        public Duas(string name, string location, string imageUrl)
        {
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        DuaList selectedItem = e.SelectedItem as DuaList;
    }

    void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
    {
        DuaList tappedItem = e.Item as DuaList;
    }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as DuaList;
            await Navigation.PushAsync(new Duas(mydetails.Name, mydetails.Location, mydetails.ImageUrl));

        }



    }
}