using System;
using Xamarin.Forms;

namespace InAnger.Jobbberr
{

	public class JobsNavigationPage : NavigationPage
	{
		public JobsNavigationPage (Page root) :base(root)
		{
			Style = AppStyle.NavigationPageStyle;
		}
	}
}