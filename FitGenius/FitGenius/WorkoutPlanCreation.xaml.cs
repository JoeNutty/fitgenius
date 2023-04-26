using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitGenius
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkoutPlanCreation : ContentPage
    {
        private SQLiteAsyncConnection _connection;

        public WorkoutPlanCreation()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Get the workout plan name from the Entry control
            string workoutPlanName = WorkoutPlanNameEntry.Text;

            // Create a new workout plan object and set its properties
            WorkoutPlan newWorkoutPlan = new WorkoutPlan
            {
                PlanName = workoutPlanName,
                DumbbellBenchPress = DumbbellBenchPress.IsChecked,
                InclineDumbbellBenchPress = InclineDumbbellBenchPress.IsChecked,
                DumbbellChestFlys = DumbbellChestFlys.IsChecked,
                PullUps = PullUps.IsChecked,
                LatPulldowns = LatPulldowns.IsChecked,
                DumbbellRows = DumbbellRows.IsChecked,
                DumbbellCurls = DumbbellCurls.IsChecked,
                RopePulldown = RopePulldown.IsChecked,
                HammerCurls = HammerCurls.IsChecked,
                ShoulderPress = ShoulderPress.IsChecked,
                LateralRaises = LateralRaises.IsChecked,
                BarbellSquats = BarbellSquats.IsChecked,
                LegPress = LegPress.IsChecked,
                WalkingLunges = WalkingLunges.IsChecked,
                RomanianDeadlifts = RomanianDeadlifts.IsChecked,
                LegCurls = LegCurls.IsChecked,
                HipThrusts = HipThrusts.IsChecked,
                BulgarianSplitSquats = BulgarianSplitSquats.IsChecked,
                CalfRaises = CalfRaises.IsChecked
            };

            // Create the table if it does not exist
            await _connection.CreateTableAsync<WorkoutPlan>();

            // Add the workout plan to the database
            await _connection.InsertAsync(newWorkoutPlan);

            // Show an alert to indicate that the workout plan was created
            await DisplayAlert("Success", "Workout plan created successfully.", "OK");
        }
    }
}
