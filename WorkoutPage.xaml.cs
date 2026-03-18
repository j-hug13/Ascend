using Ascend.Services;

namespace Ascend;

public partial class WorkoutPage : ContentPage
{
	public WorkoutPage()
	{
		InitializeComponent();
	}

	private async void StrengthClicked(object sender, EventArgs e)
	{
        var workouts = new List<Workout>
        {
            new Workout("Bench Press"),
            new Workout("Squats"),
            new Workout("Deadlift")
        };

        await Navigation.PushAsync(new CategoryPage("Strength Training", workouts));
    }

    private async void FlexibilityClicked(object sender, EventArgs e)
    {
        var workouts = new List<Workout>
        {
            new Workout("Stretches")
        };

        await Navigation.PushAsync(new CategoryPage("Flexibility & Mobility", workouts));
    }

    private async void CardioClicked(object sender, EventArgs e)
    {
        var workouts = new List<Workout>
        {
            new Workout("Run"),
            new Workout("Bike Ride"),
            new Workout("Swim")
        };

        await Navigation.PushAsync(new CategoryPage("Cardio", workouts));
    }
}