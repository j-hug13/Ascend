namespace Ascend;

public partial class WorkoutPage : ContentPage
{
	public WorkoutPage()
	{
		InitializeComponent();
	}

	private async void StrengthClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new MuscleGroupPage());
    }

    private async void FlexibilityClicked(object sender, EventArgs e)
    {
        string category = "Flexibility";
        var workouts = new List<Workout>
        {
            new Workout{ Name = "Stretches", Category = category}
        };

        await Navigation.PushAsync(new CategoryPage("Flexibility & Mobility", workouts));
    }

    private async void CardioClicked(object sender, EventArgs e)
    {
        string category = "Cardio";
        var workouts = new List<Workout>
        {
            new Workout{ Name = "Run", Category = category },
            new Workout{ Name = "Bike Ride", Category = category },
            new Workout{ Name = "Swim", Category = category }
        };

        await Navigation.PushAsync(new CategoryPage("Cardio", workouts));
    }
}