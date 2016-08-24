using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }
        async void AddPlaceClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPlacePage());
        }
        async void MyPlacesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyPlacesPage());
        }
    }
}
