using System;

using Xamarin.Forms;

namespace Cards
{
	public class App : Application
	{
		public App ()
		{
			var cards = new CardData ();

			var cardstack = new StackLayout {
				Spacing = 15,
				Padding = new Thickness (10),
				VerticalOptions = LayoutOptions.StartAndExpand,
			};

			foreach (var card in cards) {
				cardstack.Children.Add (new CardView (card));
			}

			var shadowcardstack = new StackLayout {
				Spacing = 5,
				Padding = new Thickness (5),
				VerticalOptions = LayoutOptions.StartAndExpand,
			};

			foreach (var card in cards) {
				shadowcardstack.Children.Add (new ShadowCardView (card));
			}

			var page = new ContentPage {
				Title = "Activity",
				BackgroundColor = Color.White,
				Content = new ScrollView () {
					Content = new StackLayout () {
						Children = { 
							cardstack, 
							shadowcardstack 
						}
					}	
				}
			};

			MainPage = new NavigationPage (page) { 
				BarBackgroundColor = StyleKit.BarBackgroundColor,
				BarTextColor = Color.White
			};
		}
	}
}