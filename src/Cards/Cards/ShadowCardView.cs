using System;

using Xamarin.Forms;

namespace Cards
{
	public class ShadowCardView : ContentView
	{
		public ShadowCardView (Card card)
		{

			Grid grid = new Grid {
				Padding = new Thickness (0, 1, 1, 1),
				RowSpacing = 1,
				ColumnSpacing = 1,		
				BackgroundColor = Color.Transparent,
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


			var layout = new RelativeLayout () {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 125,
				Padding = new Thickness (0)
			};

			var cardBackground = new Image () { 
				Source = StyleKit.Icons.Shadow0240,
				Aspect = Aspect.Fill
			};

			layout.Children.Add (
				cardBackground,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((parent) => {
					return (parent.Width);
				}),
				Constraint.RelativeToParent ((parent) => {
					return (parent.Height);
				})
			);

			layout.Children.Add (
				grid,
				Constraint.Constant (10),
				Constraint.Constant (10),
				Constraint.RelativeToParent ((parent) => {
					return (parent.Width - 15);
				}),
				Constraint.RelativeToParent ((parent) => {
					return (parent.Height - 0);
				})
			);

			Content = layout;
		}
	}
}