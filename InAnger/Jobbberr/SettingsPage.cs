using System;
using Xamarin.Forms;

namespace InAnger.Jobbberr
{
	public class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			Style = AppStyle.SettingsPageStyle;

			var pageTitle = new Frame () {
				Style = AppStyle.PageTitleLabelFrameStyle,
				Padding = new Thickness(0,Device.OnPlatform(15,0,0),0,10),
				Content = new Label { 
					Style = AppStyle.PageTitleLabelStyle,
					Text = "Settings",
				}
			};

			var signoutButton = new Button () {
				VerticalOptions = LayoutOptions.EndAndExpand,
				HorizontalOptions = LayoutOptions.Center,
				Text = "Sign Out",
				TextColor = AppStyle.DarkLabelColor,
			};

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness (20),
				Children = {
					pageTitle,
					new BoxView() {
						HeightRequest = 1,
						BackgroundColor = AppStyle.DarkLabelColor,
					},
					new SettingsUserView(),
					new SyncView (),
					new SettingsSwitchView ("GPS"),
					new SettingsSwitchView ("Jobs Alert"),
					signoutButton,
					new StatusBarView()
				}
			};
		}
	}
}