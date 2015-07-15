using System;
using Xamarin.Forms;

namespace InAnger.FindAVet
{
	public static class FindAVetApp
	{
		public static Page GetMainPage()
		{
			return new NavigationPage (new FindAVetPage ()) {
				BarTextColor = Color.White,
				BarBackgroundColor = Color.FromHex ("#F2995D"),
			};
		}
	}
}