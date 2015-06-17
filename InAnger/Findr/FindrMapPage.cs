using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace InAnger
{
	public class FindrMapPage : ContentPage
	{
		public FindrMapPage ()
		{
			Title = "Find a Shop";
			BackgroundColor = Color.White;

			var lense = new Image () {
				Source = new FileImageSource () { File = "maplense.png" },
				Aspect = Aspect.AspectFit,
				IsOpaque = true,
				InputTransparent = true
			};

			var map = new Map (
				        MapSpan.FromCenterAndRadius (
					        new Position (33.509242, -112.035860), Distance.FromMiles (0.3))) {
				IsShowingUser = true,
			};

			var pin = new Pin {
				Type = PinType.Place,
				Position = new Position (33.509242, -112.035860),
				Label = "Potbelly Sandwich Shop",
				Address = "2131 E. Camelback Rd.  Phoenix, AZ"
			};
			map.Pins.Add (pin);

			var stack = new StackLayout () {
				Padding = new Thickness (10),
				Children = {
					new Label () {
						FontAttributes = FontAttributes.Bold,
						Text = "Delivery Zone:",
						TextColor = Color.FromHex ("852F29"),
					},
					new Label () {
						Text = "North to E Lincoln Dr, South to E Osborn Rd, East to 40th Street, West to Central Ave ",
						FontSize = 14,

					},
					new Label () {
						FontAttributes = FontAttributes.Bold,
						Text = "Delivery Available:",
						TextColor = Color.FromHex ("852F29"),
					},
					new Label () {
						Text = "Mon. - Fri. 11:00 AM to 2:00 PM",
						FontSize = 14
					},
				}	
			};

			var orderonline = new StackLayout () {
				BackgroundColor = Color.FromHex ("E6A93D"),
				Children = {
			
					new Label () { 
						Text = "Order Online",
						FontSize = 22,
						FontAttributes = FontAttributes.Bold,
						TextColor = Color.White,
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					},
				}	
			};

			RelativeLayout relativeLayout = new RelativeLayout () {
				HeightRequest = 100,
			};

			relativeLayout.Children.Add (
				map,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width;
				}),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width;
				})
			);

			relativeLayout.Children.Add (
				lense,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width;
				}),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width;
				})
			);

			relativeLayout.Children.Add (
				stack,
				Constraint.Constant (0),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width - 10;
				}),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width;
				}),
				Constraint.RelativeToParent ((parent) => {
					return parent.Height - (parent.Width + 50);
				})
			);

			relativeLayout.Children.Add (
				orderonline,
				Constraint.Constant (0),
				Constraint.RelativeToParent ((parent) => {
					return parent.Height - 50;
				}),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width;
				}),
				Constraint.RelativeToParent ((parent) => {
					return 50;
				})
			);

			this.Content = relativeLayout;
		}
	}
}