using System;

using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace InAnger.MallDash
{
	public class MallDashPage : ContentPage
	{
		public MallDashPage ()
		{
			Title = "Dashboard";

			var dashboard = new Grid () {
				ColumnSpacing = 0,
				RowSpacing = 0,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			Enumerable.Range (0, 4).ToList ().ForEach (x =>
				dashboard.RowDefinitions.Add (
				new RowDefinition { Height = new GridLength (1, GridUnitType.Star)
				}
			));

			Enumerable.Range (0, 3).ToList ().ForEach (x =>
				dashboard.ColumnDefinitions.Add (new ColumnDefinition { 
				Width = new GridLength (1, GridUnitType.Star) 
			}));

			var squares = DashData.GetDashData ();

			squares.ForEach (x => dashboard.Children.Add (new DashWidgetView (x), x.Column, x.Row));

			Content = dashboard;
		}
	}
}