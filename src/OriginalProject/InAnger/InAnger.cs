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
				//new InAnger.Jobbberr.JobbberrPage();
				//InAnger.FindAVet.FindAVetApp.GetMainPage();
				//new InAnger.Woofer.WooferPage();
				//new InAnger.HeatMap.HeatMapApp().GetMainPage();
				//new InAnger.HotSauce.HotSauceApp().GetMainPage();
				//new InAnger.MallDash.MallDashApp().GetMainPage();
				new InAnger.Findr.FindrApp().GetMainPage();
		}
	}
}