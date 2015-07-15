using System;

using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace InAnger.MallDash
{

	public class DashSquare
	{
		public string IconImage { get; set; }

		public string BackgroundImage { get; set; }

		public string Text { get; set; }

		public int Column { get; set; }

		public int Row { get; set; }

		public Type NavigateType { get; set; }
	}
}