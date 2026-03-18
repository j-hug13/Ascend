using Ascend.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ascend;

public partial class CategoryPage : ContentPage
{
	private List<Workout> Workouts;

    public string CategoryName { get; set; }

    public CategoryPage(string categoryName, List<Workout> workouts)
	{
		InitializeComponent();
		Workouts = workouts;
        CategoryName = categoryName;
		CategoryLabel.Text = categoryName;
		WorkoutsCollection.ItemsSource = workouts;
    }

	private async void WorkoutClicked(object sender, EventArgs e)
	{
		var button = sender as Button;
		if (button == null) return;
		var workoutName = button?.Text;
		var workout = Workouts.FirstOrDefault(w => w.Name == workoutName);

		if (workout != null)
		{
            Manager.LogWorkout(workout);
			await DisplayAlert("Workout Logged", $"You have logged: {workoutName}", "OK");
        }
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();
        
		
    }
}