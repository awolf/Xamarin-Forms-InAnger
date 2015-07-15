using System;
using Xamarin.Forms;

namespace InAnger.MallDash
{
	public class MallDashApp
	{
		public Page GetMainPage ()
		{
			return new NavigationPage (new MallDashPage ()) {
				BarBackgroundColor = Color.Black,
				BarTextColor = Color.White
			};
		}
	}
}