using System;

using Xamarin.Forms;
using System.Linq;

namespace InAnger.HeatMap
{
public class HeatMapApp 
{
	Grid heatMap;

	public Page GetMainPage ()
	{
		SetupHeatMap ();

		AddHoursColumn ();
		AddWeekDayRow ();

		AddHeatSquares ();

		var stack = new StackLayout () {
			Padding = new Thickness (5, 0, 10, 0),
			Spacing = 0,
			Children = {
				new Label () {
					Text = "Page Views",
					Style = AppStyles.PageViewLabelStyle
				},
				new Label () {
					Text = "24,098",
					Style = AppStyles.PageViewCountLabelStyle
				},
				heatMap
			}
		};

		return new NavigationPage (new ContentPage () {
			Title = "Behavior",
			Padding = new Thickness (0, 5, 0, 0),
			Content = new ScrollView () { 
				Content = stack
			}
		});
	}

	public void SetupHeatMap()
	{
		heatMap = new Grid () {
			ColumnSpacing = 2,
			RowSpacing = 2,
			VerticalOptions = LayoutOptions.FillAndExpand
		};

		Enumerable.Range (1, 25).ToList ().ForEach (x =>
			heatMap.RowDefinitions.Add (
				new RowDefinition { Height = GridLength.Auto }
			));

		Enumerable.Range (1, 8).ToList ().ForEach (x =>
			heatMap.ColumnDefinitions.Add (new ColumnDefinition { 
				Width = new GridLength (1, GridUnitType.Star) 
			}));
	}

	private void AddHoursColumn()
	{
		var hours = AppData.Hours;

		for (int i = 0; i < 24; i++) {
			heatMap.Children.Add (new Label () { 
				Text = hours [i],
				Style = AppStyles.HoursLabelStyle
			}, 0, i + 1);
		}
	}

	private void AddWeekDayRow()
	{
		var days = AppData.Days;

		for (int i = 0; i < 7; i++) {
			heatMap.Children.Add (new Label () { 
				Text = days [i],
				Style = AppStyles.DaysLabelStyle,
			}, i + 1, 0);
		}
	}

	private void AddHeatSquares()
	{
		var values = AppData.Values;
		var colors = AppStyles.Colors;

		for (int i = 0; i < 7; i++) {
			for (int j = 0; j < 24; j++) {
				heatMap.Children.Add (new BoxView () { 
					Color = colors [values [i, j]],
					HeightRequest = 15
				}, i + 1, j + 1);
			}
		}
	}
}
}