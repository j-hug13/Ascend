using System.Collections.Generic;

namespace Ascend;

public partial class MuscleGroupPage : ContentPage
{
	public MuscleGroupPage()
	{
		InitializeComponent();
	}

	private async void ChestClicked(object sender, EventArgs e)
	{
		var workouts = new List<Workout>
		{
			new Workout { Name = "Bench Press", Category = "Strength Training" },
			new Workout { Name = "Push-Ups", Category = "Strength Training" },
			new Workout { Name = "Chest Flyes", Category = "Strength Training" }
		};
        await Navigation.PushAsync(new CategoryPage("Strength Training", workouts));
    }

	private async void BackClicked(object sender, EventArgs e)
	{
		var workouts = new List<Workout>
		{
			new Workout { Name = "Pull-Ups", Category = "Strength Training" },
			new Workout { Name = "Deadlifts", Category = "Strength Training" },
			new Workout { Name = "Bent-Over Rows", Category = "Strength Training" }
		};
        await Navigation.PushAsync(new CategoryPage("Strength Training", workouts));
    }

	private async void LegsClicked(object sender, EventArgs e)
	{
		var workouts = new List<Workout>
		{
			new Workout { Name = "Squats", Category = "Strength Training" },
			new Workout { Name = "Lunges", Category = "Strength Training" },
			new Workout { Name = "Leg Press", Category = "Strength Training" }
		};
        await Navigation.PushAsync(new CategoryPage("Strength Training", workouts));
    }

	private async void ArmsClicked(object sender, EventArgs e) 
	{ 
		var workouts = new List<Workout>
		{
			new Workout { Name = "Bicep Curls", Category = "Strength Training" },
			new Workout { Name = "Tricep Dips", Category = "Strength Training" },
			new Workout { Name = "Hammer Curls", Category = "Strength Training" }
		};
        await Navigation.PushAsync(new CategoryPage("Strength Training", workouts));
    }

	private async void ShouldersClicked(object sender, EventArgs e)
	{
		var workouts = new List<Workout>
		{
			new Workout { Name = "Overhead Press", Category = "Strength Training" },
			new Workout { Name = "Lateral Raises", Category = "Strength Training" },
			new Workout { Name = "Front Raises", Category = "Strength Training" }
		};
        await Navigation.PushAsync(new CategoryPage("Strength Training", workouts));
    }

	private async void CoreClicked(object sender, EventArgs e)
	{
		var workouts = new List<Workout>
		{
			new Workout { Name = "Crunches", Category = "Strength Training" },
			new Workout { Name = "Planks", Category = "Strength Training" },
			new Workout { Name = "Russian Twists", Category = "Strength Training" }
		};
        await Navigation.PushAsync(new CategoryPage("Strength Training", workouts));
    }
}