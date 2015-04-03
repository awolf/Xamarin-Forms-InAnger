using System;
using Xamarin.Forms;

namespace InAnger.Vets
{
	public static class VetsApp
	{
		public static Page GetMainPage()
		{
			return new NavigationPage (new VetPage ()) {
				BarTextColor = Color.White,
				BarBackgroundColor = Color.FromHex ("#F2995D"),
			};
		}
	}
}