using SQLite;
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
    public partial class WorkoutPlanPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;

        public WorkoutPlanPage()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Load workout plans from the database
            var workoutPlans = await _connection.Table<WorkoutPlan>().ToListAsync();
            WorkoutPlanList.ItemsSource = workoutPlans;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WorkoutPlanCreation());
        }

        private void WorkoutPlanList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPlan = e.SelectedItem as WorkoutPlan;
            if (selectedPlan == null)
                return;

            Navigation.PushAsync(new WorkoutPlanDetailsPage(selectedPlan));
            ((ListView)sender).SelectedItem = null;
        }
    }
}
