using FinalProduct.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProduct.ViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DuaViewModel : ContentPage
    {
        public ObservableCollection<DuaList> DuaLists { get; set; }
        public DuaViewModel()
        {
            InitializeComponent();
            ObservableCollection<DuaList> DuaList = new ObservableCollection<DuaList>();
            DuaList.Add(new DuaList { Name = "Test1", ImageUrl = "home.png", Location = "This is our detail page details to be listed" });
        }
    }
}