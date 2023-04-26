using FitGenius.upper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitGenius.lower
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class lowermain : ContentPage
	{
		public lowermain ()
		{
			InitializeComponent ();
		}
        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new quad());
        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new hams());
        }

        async private void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new glutes());
        }

        async private void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new calves());
        }
    }
}