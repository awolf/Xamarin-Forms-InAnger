using System;
using Xamarin.Forms;

namespace InAnger.Findr
{
	public class FindrApp
	{
		public Page GetMainPage ()
		{
			return new NavigationPage (new FindrMapPage ()) {
				BarBackgroundColor = Color.FromHex("E6A93D"),
				BarTextColor = Color.White
			};
		}
	}
}