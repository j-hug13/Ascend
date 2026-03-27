using System;
using System.Linq;
using Microsoft.Maui.Controls;

namespace Ascend;

public partial class WorkoutHistoryPage : ContentPage
{
	public WorkoutHistoryPage()
	{
		InitializeComponent();

		LoadWorkoutsForDate(DateTime.Today);
    }

	private void OnDateSelected(object sender, DateChangedEventArgs e)
	{
		LoadWorkoutsForDate(e.NewDate);
    }

	private void LoadWorkoutsForDate(DateTime date)
	{
		var filteredWorkouts = Manager.WorkoutHistory.Where(w => w.Date.Date == date.Date).OrderByDescending(w => w.Date).ToList();
		WorkoutHistoryCollection.ItemsSource = filteredWorkouts;
    }

	private void OnDeleteClicked(object sender, EventArgs e)
	{
		if (sender is Button b && b.BindingContext is Workout w)
		{
			Manager.RemoveWorkout(w);
			LoadWorkoutsForDate(WorkoutDatePicker.Date);
        }
	}

    protected override void OnAppearing()
	{
		base.OnAppearing();
        WorkoutHistoryCollection.ItemsSource = Manager.WorkoutHistory;
    }
}