using System;
using Xamarin.Forms;
using ImageCircle.Forms.Plugin.Abstractions;

namespace InAnger.FindAVet
{
	public class VetCell:ViewCell
	{
		public VetCell ()
		{
			var vetProfileImage = new CircleImage {
				BorderColor = Color.FromHex ("#F2995D"),
				BorderThickness = 2,
				HeightRequest = 50,
				WidthRequest = 50,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
			};
			vetProfileImage.SetBinding (Image.SourceProperty, "ImageSource");

			var nameLabel = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.Black
			};
			nameLabel.SetBinding (Label.TextProperty, "Name");

			var distanceLabel = new Label () {
				FontAttributes = FontAttributes.Bold,
				FontSize = 12,
				TextColor = Color.FromHex ("#666")
			};
			distanceLabel.SetBinding (Label.TextProperty, new Binding ("Distance", stringFormat: "{0} Miles Away"));

			// Online image and label
			var onlineImage = new Image () {
				Source = "online.png",
				HeightRequest = 8,
				WidthRequest = 8
			};
			onlineImage.SetBinding (Image.IsVisibleProperty, "ShouldShowAsOnline");
			var onLineLabel = new Label () { 
				Text = "Online", 
				TextColor = Color.FromHex ("#F2995D"),
				FontSize = 12,
			};
			onLineLabel.SetBinding (Label.IsVisibleProperty, "ShouldShowAsOnline");

			// Offline image and label
			var offlineImage = new Image () {
				Source = "offline.png",
				HeightRequest = 8,
				WidthRequest = 8
			};
			offlineImage.SetBinding (Image.IsVisibleProperty, "ShouldShowAsOffline");
			var offLineLabel = new Label () { 
				Text = "5 hours ago", 
				TextColor = Color.FromHex ("#ddd"),
				FontSize = 12,
			};
			offLineLabel.SetBinding (Label.IsVisibleProperty, "ShouldShowAsOffline");

			// Vet rating label and star image
			var starLabel = new Label () { 
				FontSize = 12,
				TextColor = Color.Gray
			};
			starLabel.SetBinding (Label.TextProperty, "Stars");

			var starImage = new Image () {
				Source = "star.png",
				HeightRequest = 12,
				WidthRequest = 12
			};

			var ratingStack = new StackLayout () {
				Spacing = 3,
				Orientation = StackOrientation.Horizontal,
				Children = { starImage, starLabel }
			};

			var statusLayout = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Children = { distanceLabel, onlineImage, onLineLabel, offlineImage, offLineLabel }
			};

			var vetDetailsLayout = new StackLayout {
				Padding = new Thickness (10, 0, 0, 0),
				Spacing = 0,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { nameLabel, statusLayout, ratingStack }
			};

			var tapImage = new Image () {
				Source = "tap.png",
				HorizontalOptions = LayoutOptions.End,
				HeightRequest = 12,
			};

			var cellLayout = new StackLayout {
				Spacing = 0,
				Padding = new Thickness (10, 5, 10, 5),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { vetProfileImage, vetDetailsLayout, tapImage }
			};

			this.View = cellLayout;
		}
	}
}

