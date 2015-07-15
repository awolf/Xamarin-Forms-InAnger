using System;
using Xamarin.Forms;

namespace Cards
{
	public class CardStatusView : ContentView
	{
		public CardStatusView (Card card)
		{
			var statusBoxView = new BoxView {
				VerticalOptions = LayoutOptions.Fill,
				HorizontalOptions = LayoutOptions.Fill
			};

			switch (card.Status) {
			case  CardStatus.Alert:
				statusBoxView.BackgroundColor = StyleKit.Status.AlertColor;
				break;
			case CardStatus.Completed:
				statusBoxView.BackgroundColor = StyleKit.Status.CompletedColor;
				break;
			case CardStatus.Unresolved:
				statusBoxView.BackgroundColor = StyleKit.Status.UnresolvedColor;
				break;
			default:
				statusBoxView.BackgroundColor = StyleKit.Status.UnresolvedColor;
				break;
			}
			;

			Content = statusBoxView;
		}
	}
}