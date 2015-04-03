using System;

using Xamarin.Forms;
using System.Collections.Generic;
using ImageCircle.Forms.Plugin.Abstractions;

namespace InAnger.FindAVet
{
	public class FindAVetPage : ContentPage
	{
		public static Color BrandColor = Color.FromHex ("#F2995D");

		public FindAVetPage ()
		{
			Title = "Choose a Vet";
			var searchBar = new SearchBar { 
				Placeholder = "Search by Name ", 
				BackgroundColor = Color.White, CancelButtonColor = BrandColor,
			};

			var vetlist = new ListView {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate (typeof(VetCell)),
				ItemsSource = VetData.GetData (),
				SeparatorColor = Color.FromHex ("#ddd"),
			};

			var layout = new StackLayout {
				Children = {
					searchBar,
					vetlist
				}
			};

			Content = layout;
		}
	}
}