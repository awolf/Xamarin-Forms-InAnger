using System;

using Xamarin.Forms;

namespace Cards
{
	public class DateTimeView : ContentView
	{
		public DateTimeView (Card card)
		{
			var labelStyle = new Style (typeof(Label))
				.Set (Label.FontSizeProperty, 8)
				.Set (Label.TextColorProperty, StyleKit.MediumGrey)
				.Set (Image.VerticalOptionsProperty, LayoutOptions.Center);

			var iconStyle = new Style (typeof(Image))
				.Set (Image.HeightRequestProperty, 10)
				.Set (Image.WidthRequestProperty, 10)
				.Set (Image.VerticalOptionsProperty, LayoutOptions.Center);

			var stack = new StackLayout () {
				VerticalOptions = LayoutOptions.Center,
				HeightRequest = 20,
				Padding = new Thickness (0),
				Orientation = StackOrientation.Horizontal,
				Children = {
					new Image () {
						Style = iconStyle,
						Source = StyleKit.Icons.SmallCalendar,
					},
					new Label () {
						Text = card.DueDate.ToShortDateString (),
						Style = labelStyle,
					},
					new BoxView () { Color = Color.Transparent, WidthRequest = 20 },
					new Image () {
						Style = iconStyle,
						Source = StyleKit.Icons.SmallClock,
					},
					new Label () {
						Text = card.DirationInMinutes.ToString () + " Minutes",
						Style = labelStyle,
					}
				}
			};

			Content = stack;
		}
	}
}