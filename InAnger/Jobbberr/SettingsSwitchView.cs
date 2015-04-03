using System;

using Xamarin.Forms;

namespace InAnger.Jobbberr
{
	public class SettingsSwitchView : ContentView
	{
		private Switch toggle;

		public event EventHandler<ToggledEventArgs> Toggled;

		public bool IsToggeled { 
			get{  
				return toggle.IsToggled;
			} 
			set{ 
				toggle.IsToggled = value;
			}
		}

		public SettingsSwitchView (string labelText)
		{
			CreateToggle ();

			Content = new StackLayout { 
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.Fill,
				Spacing = 10,
				Padding = new Thickness(0,5),
				Children = {
					new Label () { 
						Style = AppStyle.SettingSwitchLabelStyle,
						Text = labelText
					},
					new Label () {
						HorizontalOptions = LayoutOptions.EndAndExpand,
						Style = AppStyle.SettingSwitchInstructionStyle,
						Text = "OFF"
					},
					toggle,
					new Label () { 
						Style = AppStyle.SettingSwitchInstructionStyle,
						Text = "ON"
					}
				}
			};
		}

		private void CreateToggle() 
		{
			toggle = new Switch () {};
			toggle.Toggled += (object sender, ToggledEventArgs e) => {
				if (Toggled != null)
				{
					Toggled.Invoke(this, e);
				}
			};
		}
	}
}