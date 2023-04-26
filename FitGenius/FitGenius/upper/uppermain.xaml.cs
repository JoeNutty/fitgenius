using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitGenius.upper
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class uppermain : ContentPage
	{
		public uppermain ()
		{
			InitializeComponent ();
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new chest());
        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new back());
        }

        async private void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new arms());
        }

        async private void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new shoulders());
        }
    }
}