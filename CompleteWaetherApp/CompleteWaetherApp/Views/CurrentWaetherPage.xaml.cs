using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompleteWaetherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrentWaetherPage : ContentPage
    {
        public CurrentWaetherPage()
        {
            InitializeComponent();
        }
    }
}