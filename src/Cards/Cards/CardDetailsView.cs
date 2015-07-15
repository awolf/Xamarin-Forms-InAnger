using System;

using Xamarin.Forms;

namespace Cards
{
	public class CardDetailsView : ContentView
	{
		public CardDetailsView (Card card)
		{
			BackgroundColor = Color.White;

			Label TitleText = new Label () {
				FormattedText = card.Title,
				FontSize = 18,
				TextColor = StyleKit.LightTextColor
			};

			Label DescriptionText = new Label () {
				FormattedText = card.Description,
				FontSize = 12,
				TextColor = StyleKit.LightTextColor
			};

			var stack = new StackLayout () {
				Spacing = 0,
				Padding = new Thickness (10, 0, 0, 0),
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					TitleText,
					DescriptionText,
					new DateTimeView (card)
				}
			};

			Content = stack;
		}
	}
}