using System;
using Xamarin.Forms;

namespace InAnger.Jobbberr
{
	public class SyncSliderView : ContentView
	{
		private Slider syncSlider;

		public event EventHandler<ValueChangedEventArgs> SyncValueChanged;

		public double SyncValue { get; set; }

		public SyncSliderView ()
		{
			Content = new StackLayout () {
				Padding = new Thickness (0, 20),
				Spacing = 5,
				Children = {
					SliderLabels (),
					SyncSlider ()
				}
			};
		}

		private Slider SyncSlider (double value = 25)
		{
			syncSlider = new Slider () {
				Maximum = 75,
				Minimum = 0,
				Value = value,
			};

			SyncValue = value;

			syncSlider.ValueChanged += HandleSliderChangedEvent;
			return syncSlider;
		}

		private Grid SliderLabels ()
		{
			var grid = new Grid {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			grid.Children.Add (
				SyncLabel ("1", LayoutOptions.StartAndExpand, new Thickness (5, 0, 0, 0))
				, 0, 0);

			grid.Children.Add (
				SyncLabel ("5", LayoutOptions.Center)
				, 1, 0);

			grid.Children.Add (
				SyncLabel ("30", LayoutOptions.Center)
				, 2, 0);

			grid.Children.Add (
				SyncLabel ("60", LayoutOptions.EndAndExpand, new Thickness (0, 0, 5, 0))
				, 3, 0);

			return grid;
		}

		private StackLayout SyncLabel (string text, LayoutOptions horizontalOptions, Thickness padding = new Thickness ())
		{
			return new StackLayout () {
				Padding = padding,
				Spacing = 2,
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = horizontalOptions,
				Children = {
					new Label () {
						Style = AppStyle.SettingSyncSliderTimeLabel,
						Text = text 
					},
					new Label () {
						Text = "min",
						Style = AppStyle.SettingSyncSliderMinLabel,
					}
				}
			};
		}

		private void HandleSliderChangedEvent (object sender, ValueChangedEventArgs e)
		{
			syncSlider.Value = ((int)Math.Round (e.NewValue / 25.0)) * 25;

			if (SyncValueChanged != null) {
				var changes = new ValueChangedEventArgs (e.OldValue, syncSlider.Value);
				SyncValueChanged.Invoke (this, changes);
			}
		}
	}
}