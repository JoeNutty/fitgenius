using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitGenius
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FitnessGuruPage : ContentPage
	{
		public FitnessGuruPage ()
		{
			InitializeComponent ();
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new upper.uppermain());
        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new lower.lowermain());
        }
    }
}