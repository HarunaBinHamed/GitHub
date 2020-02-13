using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProduct
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DuasShell : Shell
    {
        public DuasShell()
        {
            InitializeComponent();


            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                       {
                           Device.BeginInvokeOnMainThread(() =>
                             DateTime.Now.ToString("HH:mm:ss")
                               );
                           return true;
                       });

        }
    }
}