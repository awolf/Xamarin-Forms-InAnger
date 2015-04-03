using System;

using Xamarin.Forms;

namespace InAnger.Jobbberr
{
	public class StatusBarView : ContentView
	{
		public StatusBarView ()
		{
			HorizontalOptions = LayoutOptions.Fill;
			VerticalOptions = LayoutOptions.End;
			Content = new StackLayout () {
				Padding = new Thickness (0,10,0,0),
				Spacing = 0,
				Orientation = StackOrientation.Horizontal,
				Children = {
					new Label () { 
						Text = "Last Login",
						Style = AppStyle.SettingSwitchInstructionStyle,
						HorizontalOptions = LayoutOptions.Start
					},
					new Label () { 
						Text = " 2 days ago",
						Style = AppStyle.SettingSyncSliderMinLabel,
						HorizontalOptions = LayoutOptions.StartAndExpand
					},
					new Label () { 
						Text = "Synced",
						Style = AppStyle.SettingSwitchInstructionStyle,
						HorizontalOptions = LayoutOptions.EndAndExpand
					},
					new Label () { 
						Text = " 6 min ago",
						Style = AppStyle.SettingSyncSliderMinLabel,
						HorizontalOptions = LayoutOptions.End
					},
				}

			};
		}
	}
}