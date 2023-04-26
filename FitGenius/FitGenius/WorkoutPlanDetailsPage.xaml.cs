using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitGenius
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkoutPlanDetailsPage : ContentPage
    {
        public WorkoutPlanDetailsPage(WorkoutPlan workoutPlan)
        {
            InitializeComponent();
            DisplayWorkoutDetails(workoutPlan);
        }

        private void DisplayWorkoutDetails(WorkoutPlan workoutPlan)
        {
            // Add the workout plan name as a header
            WorkoutDetailsStack.Children.Add(new Label
            {
                Text = workoutPlan.PlanName,
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            });

            // Iterate through the properties of the workout plan
            foreach (var property in workoutPlan.GetType().GetProperties())
            {
                if (property.PropertyType == typeof(bool))
                {
                    // Check if the workout is included in the plan
                    bool included = (bool)property.GetValue(workoutPlan);
                    if (included)
                    {
                        // Add a label for the workout to the stack layout
                        WorkoutDetailsStack.Children.Add(new Label
                        {
                            Text = property.Name,
                            FontSize = 18,
                            TextColor = Color.FromHex("#4a4a4a")
                        });
                    }
                }
            }
        }
    }
}
