using System;

using Xamarin.Forms;

namespace InAnger.Woofer 
{
	public class DetailsView : ContentView
	{
		public DetailsView ()
		{
			var name = new Label () {
				Text = "Alabama Wolf",
				FontSize = 20,
				FontFamily = Device.OnPlatform("HelveticaNeue-Bold","sans-serif-black",null),
				XAlign = TextAlignment.Center,
				TextColor = Color.Black
			};

			var where = new Label () {
				Text = "Phoenix, Arizona",
				FontSize = 12,
				FontFamily = Device.OnPlatform("HelveticaNeue-Light","sans-serif-light",null),
				XAlign = TextAlignment.Center,
				TextColor = Color.FromHex("#666")
			};

			var bio = new Label () {
				Text = "Do you have treats for me? Look at me, I'm an angel, sitting and everything.",
				FontSize = 14,
				FontFamily = Device.OnPlatform("HelveticaNeue","sans-serif",null),
				XAlign = TextAlignment.Center,
				TextColor = Color.Black
			};

			var stack = new StackLayout () {
				Padding = new Thickness(20,10),
				Children = {
					name,
					where,
					bio
				}
			};

			Content = stack;
		}
	}
}