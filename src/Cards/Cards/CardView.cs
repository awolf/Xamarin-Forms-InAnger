using System;

using Xamarin.Forms;

namespace Cards
{
	public class CardView : ContentView
	{
		public CardView (Card card)
		{
			Grid grid = new Grid {
				Padding = new Thickness (0, 1, 1, 1),
				RowSpacing = 1,
				ColumnSpacing = 1,		
				BackgroundColor = StyleKit.CardBorderColor,
				VerticalOptions = LayoutOptions.FillAndExpand,
				RowDefinitions = {
					new RowDefinition { Height = new GridLength (70, GridUnitType.Absolute) },
					new RowDefinition { Height = new GridLength (30, GridUnitType.Absolute) }
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (4, GridUnitType.Absolute) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (100, GridUnitType.Absolute) },
					new ColumnDefinition { Width = new GridLength (50, GridUnitType.Absolute) }
				}
			};

			grid.Children.Add (
				new CardStatusView (card)
		, 0, 1, 0, 2);

			grid.Children.Add (new CardDetailsView (card), 1, 4, 0, 1);

			grid.Children.Add (
				new IconLabelView (
					card.StatusMessageFileSource,
					card.StatusMessage
				)
		, 1, 1);

			grid.Children.Add (
				new IconLabelView (
					card.ActionMessageFileSource,
					card.ActionMessage
				)
		, 2, 1);

			grid.Children.Add (new ConfigIconView (), 3, 1);

			Content = grid;
		}
	}
}