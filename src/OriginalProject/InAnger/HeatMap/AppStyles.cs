using System;
using Xamarin.Forms;

namespace InAnger.HeatMap
{
	public static class AppStyles
	{
		public static Color LightGrey = Color.FromHex ("929292");
		public static Color DarkGrey = Color.FromHex ("707070");

		public static Color[] Colors {
			get { 
				return new Color[4] {
					Color.FromHex ("E8F0FD"),
					Color.FromHex ("7DACF3"),
					Color.FromHex ("3D7BE4"),
					Color.FromHex ("1F3DA8")
				};
			}
		}

		public static Style PageViewLabelStyle {
			get { 
				return new Style (typeof(Label)) {
					Setters = {
						new Setter { Property = Label.FontSizeProperty, Value = 14 },
						new Setter { Property = Label.TextColorProperty, Value = LightGrey },
						new Setter { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold }
					}
				};
			}
		}

		public static Style PageViewCountLabelStyle {
			get { 
				return new Style (typeof(Label)) {
					Setters = {
						new Setter { Property = Label.FontSizeProperty, Value = 22 },
						new Setter { Property = Label.FontFamilyProperty, Value = Device.OnPlatform ("Avenir", "sans-serif-thin", null) },
						new Setter { Property = Label.TextColorProperty, Value = DarkGrey },
					}
				};
			}
		}

		public static Style HoursLabelStyle {
			get { 
				return new Style (typeof(Label)) {
					Setters = {
						new Setter { Property = Label.FontSizeProperty, Value = 10 },
						new Setter { Property = Label.TextColorProperty, Value = LightGrey },
						new Setter { Property = Label.XAlignProperty, Value = TextAlignment.End },
					}
				};
			}
		}

		public static Style DaysLabelStyle {
			get { 
				return new Style (typeof(Label)) {
					Setters = {
						new Setter { Property = Label.FontSizeProperty, Value = 12 },
						new Setter { Property = Label.TextColorProperty, Value = LightGrey },
						new Setter { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
						new Setter { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center }
					}
				};
			}
		}
	}
}

