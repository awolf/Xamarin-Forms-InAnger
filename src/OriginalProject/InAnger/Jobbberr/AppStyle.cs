using System;
using Xamarin.Forms;

namespace InAnger.Jobbberr
{
	public static class AppStyle
	{
		public static Color BaseColor = Color.FromHex ("#464646");
		public static Color BrandColor = Color.FromHex ("#F2995D");
		public static Color DarkLabelColor = Color.FromHex ("#747474");
		public static Color LightLabelColor = Color.FromHex ("#D5D5D5");

		public static int PageTitleFontSize = 18;
		public static int SwitchLabelFontSize = 14;
		public static int SwitchInstructionLabelFontSize = 10;
		public static int SliderMinLabelFontSize = 8;


		// Label Styles

		public static Style PageTitleLabelStyle {
			get { 
				return new Style (typeof(Label)) {
					Setters = {
						new Setter { Property = Label.XAlignProperty, Value = TextAlignment.Center },
						new Setter { Property = Label.FontSizeProperty, Value = PageTitleFontSize },
						new Setter { Property = Label.TextColorProperty, Value = LightLabelColor }
					}
				};
			}
		}

		public static Style PageTitleLabelFrameStyle {
			get { 
				return new Style (typeof(Frame)) {
					Setters = {
						new Setter { Property = Frame.BackgroundColorProperty, Value = Color.Transparent },
						new Setter { Property = Frame.HasShadowProperty, Value = false },
					}
				};
			}
		}

		public static Style SettingSwitchLabelStyle {
			get { 
				return new Style (typeof(Label)) {
					Setters = {
						new Setter { Property = Label.FontSizeProperty, Value = SwitchLabelFontSize },
						new Setter { Property = Label.YAlignProperty, Value = TextAlignment.Center },
						new Setter { Property = Label.TextColorProperty, Value = DarkLabelColor },
						new Setter { Property = Label.FontSizeProperty, Value = SwitchLabelFontSize },
					}
				};
			}
		}

		public static Style SettingSwitchInstructionStyle {
			get { 
				return new Style (typeof(Label)) {
					Setters = {
						new Setter { Property = Label.FontSizeProperty, Value = SwitchInstructionLabelFontSize },
						new Setter { Property = Label.YAlignProperty, Value = TextAlignment.Center },
						new Setter { Property = Label.TextColorProperty, Value = LightLabelColor },
					}
				};
			}
		}

		// Slider Styles

		public static Style SettingSyncSliderMinLabel {
			get { 
				return new Style (typeof(Label)) {
					Setters = {
						new Setter { Property = Label.FontSizeProperty, Value = SliderMinLabelFontSize },
						new Setter { Property = Label.YAlignProperty, Value = TextAlignment.Center },
						new Setter { Property = Label.TextColorProperty, Value = DarkLabelColor },
					}
				};
			}
		}
		public static Style SettingSyncSliderTimeLabel {
			get { 
				return new Style (typeof(Label)) {
					Setters = {
						new Setter { Property = Label.FontSizeProperty, Value = SwitchInstructionLabelFontSize },
						new Setter { Property = Label.YAlignProperty, Value = TextAlignment.Center },
						new Setter { Property = Label.TextColorProperty, Value = LightLabelColor },
					}
				};
			}
		}

		//Button Style

		public static Style SettingSignOutButton {
			get { 
				return new Style (typeof(Frame)) {
					Setters = {
						new Setter { Property = Frame.OutlineColorProperty, Value = AppStyle.DarkLabelColor },
						new Setter { Property = Frame.BackgroundColorProperty, Value = Color.Transparent },
						new Setter { Property = Frame.HasShadowProperty, Value = false },
					}
				};
			}
		}


		// Page Styles

		public static Style SettingsPageStyle {
			get { 
				return new Style (typeof(Page)) {
					Setters = {
						new Setter { Property = Page.BackgroundColorProperty, Value = BaseColor },
						new Setter { Property = Page.IconProperty, Value = "settings.png" },
						new Setter { Property = Page.TitleProperty, Value = "Settings" }
					}
				};
			}
		}

		public static Style NavigationPageStyle {
			get { 
				return new Style (typeof(NavigationPage)) {
					Setters = {
						new Setter { Property = NavigationPage.BarTextColorProperty, Value = Color.White },
						new Setter { Property = NavigationPage.BarBackgroundColorProperty, Value = BrandColor },
					}
				};
			}


		}
	}
}