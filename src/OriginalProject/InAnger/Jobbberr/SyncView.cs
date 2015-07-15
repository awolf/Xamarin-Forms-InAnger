using System;

using Xamarin.Forms;

namespace InAnger.Jobbberr
{
	public class SyncView : ContentView
	{
		private SettingsSwitchView autoSyncSwitch;
		private SyncSliderView SettingSyncSlider;

		public SyncView ()
		{
			SettingSyncSlider = new SyncSliderView ();

			autoSyncSwitch = new SettingsSwitchView ("Auto Sync") { IsToggeled = true };
			autoSyncSwitch.Toggled += (object sender, ToggledEventArgs e) => {
				SettingSyncSlider.IsVisible = e.Value;
			};

			Content = new StackLayout {
				Spacing = 0,
				Children = {
					autoSyncSwitch,
					SettingSyncSlider,
				}
			};
		}
	}
}