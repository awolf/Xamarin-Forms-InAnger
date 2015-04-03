using System;

using Xamarin.Forms;
using InAnger.PhoenixPeaks;
using InAnger.Jobbberr;
using InAnger.Vets;

namespace InAnger
{
	public class App : Application
	{
		public App ()
		{
			
			MainPage = 
				//new PhoenixPeaksPage ();
				//new JobbberrPage();
				VetsApp.GetMainPage();
		}
	}
}