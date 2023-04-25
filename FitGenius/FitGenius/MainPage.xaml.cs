using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FitGenius;

namespace FitGenius
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnFitnessGuruClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FitnessGuruPage());
        }

        private async void OnWorkoutPlanClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkoutPlanPage());
        }

        private async void OnFitnessFundamentalsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FitnessFundamentalsPage());
        }

        private async void OnFitnessJournalClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FitnessJournalPage());
        }
    }

}
