using System;

using Xamarin.Forms;

namespace InAnger.Woofer
{
	public class SlideShowView : ContentView
	{
		public SlideShowView ()
		{
			HeightRequest = 200;

			var image1 = new Image() {Source = new FileImageSource(){ File = "bama1.jpg"}};
			var image2 = new Image() {Source = new FileImageSource(){ File = "bama2.jpg"}};
			var image3 = new Image() {Source = new FileImageSource(){ File = "bama3.jpg"}};
			var image4 = new Image() {Source = new FileImageSource(){ File = "bama4.jpg"}};
			var image5 = new Image() {Source = new FileImageSource(){ File = "bama5.jpg"}};
			var image6 = new Image() {Source = new FileImageSource(){ File = "bama6.jpg"}};
			var image7 = new Image() {Source = new FileImageSource(){ File = "bama7.jpg"}};
			var image8 = new Image() {Source = new FileImageSource(){ File = "bama8.jpg"}};
			var image9 = new Image() {Source = new FileImageSource(){ File = "bama9.jpg"}};

			var stack = new StackLayout () {
				Padding = new Thickness(0,0,0,10),
				Orientation = StackOrientation.Horizontal,
				Spacing = 10,
				Children = {
					image1,
					image2,
					image3,
					image4,
					image5,
					image6,
					image7,
					image8,
					image9
				}
			};

			Content = new ScrollView() {
				Content = stack, 
				Orientation = ScrollOrientation.Horizontal};
		}
	}
}