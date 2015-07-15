using System;
using Xamarin.Forms;

namespace InAnger.Jobbberr
{
	public class JobbberrPage : MasterDetailPage
	{
		public JobbberrPage ()
		{
			Title = "Jobs";

			Master = new SettingsPage ();
			Detail = new JobsNavigationPage(new HomePage());
		}
	}
}