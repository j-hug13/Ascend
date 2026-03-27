using System;
using Microsoft.Maui.Controls;

namespace Ascend;

public partial class WorkoutDetailPage : ContentPage
{
	private string _workoutName;
	private string _category;

	public WorkoutDetailPage(string workoutName, string category)
	{
		InitializeComponent();

		_workoutName = workoutName;
		_category = category;

		WorkoutNameLabel.Text = workoutName;

		SetUpFields();
	}

	private void SetUpFields()
	{
		if (_category == "Strength Training")
		{
			SetsEntry.IsVisible = true;
			RepsEntry.IsVisible = true;
			WeightEntry.IsVisible = true;
			DurationEntry.IsVisible = false;
			DistanceEntry.IsVisible = false;
		}
		else if (_category == "Cardio")
		{
			SetsEntry.IsVisible = false;
			RepsEntry.IsVisible = false;
			WeightEntry.IsVisible = false;
			DurationEntry.IsVisible = true;
			DistanceEntry.IsVisible = true;
		}
		else
		{
			SetsEntry.IsVisible = false;
			RepsEntry.IsVisible = false;
			WeightEntry.IsVisible = false;
			DurationEntry.IsVisible = false;
			DistanceEntry.IsVisible = false;
		}
	}

	private async void SaveWorkoutClicked(object sender, EventArgs e)
	{
		Workout workout = new Workout
		{
			Name = _workoutName,
			Category = _category,
			Date = DateTime.Now
		};

		try
		{
			if (_category == "Strength Training")
			{
				workout.Sets = int.Parse(SetsEntry.Text);
				workout.Reps = int.Parse(RepsEntry.Text);
				workout.Weight = double.Parse(WeightEntry.Text);
			}
			else if (_category == "Cardio")
			{
				workout.Duration = double.Parse(DurationEntry.Text);
				workout.Distance = double.Parse(DistanceEntry.Text);
			}
		}
		catch
		{
			await DisplayAlert("Error", "Please enter valid numbers for all fields.", "OK");
			return;
		}

		Manager.LogWorkout(workout);
		await DisplayAlert("Workout Saved", $"You have saved: {_workoutName}", "OK");
		await Navigation.PopAsync();
	}
}