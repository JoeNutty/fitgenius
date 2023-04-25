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
	public partial class FitnessFundamentalsPage : ContentPage
	{
		public FitnessFundamentalsPage ()
		{
			InitializeComponent ();
		}
        private async void CalorieDeficitButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalorieDeficitPage());
        }

        private async void MuscleTrainingButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MuscleTrainingPage());
        }

        private async void EatingHealthyButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EatingHealthyPage());
        }

    }
}