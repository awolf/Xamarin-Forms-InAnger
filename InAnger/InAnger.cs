using System;
using Xamarin.Forms;

namespace InAnger
{
	public class App : Application
	{
		public App ()
		{
			
			MainPage = 
				//new InAnger.PhoenixPeaks.PhoenixPeaksPage ();
				//new InAnger.JobbberrJobbberrPage();
				InAnger.FindAVet.FindAVetApp.GetMainPage();
		}
	}
}