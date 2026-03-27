using System;
using System.Collections.Generic;
using System.Linq;

namespace Ascend;

public partial class CategoryPage : ContentPage
{
	private List<Workout> _workouts;
	private string _category;

    public CategoryPage(string category, List<Workout> workouts)
	{
		InitializeComponent();
		_workouts = workouts;
		_category = category;
		Title = category;
		CategoryLabel.Text = category;
		WorkoutsCollection.ItemsSource = _workouts;
    }

	private async void WorkoutClicked(object sender, EventArgs e)
	{
		var button = sender as Button;
		if (button == null) return;
		var workoutName = button.Text;

		await Navigation.PushAsync(new WorkoutDetailPage(workoutName, _category));
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();
        
		
    }
}