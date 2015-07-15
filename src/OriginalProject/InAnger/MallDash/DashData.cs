using System;
using System.Collections.Generic;

namespace InAnger.MallDash
{
	public static class DashData
	{
		public static List<DashSquare> GetDashData ()
		{
			return new List<DashSquare> () {
				new DashSquare () {
					BackgroundImage = "fashionbg.png",
					IconImage = "fashion.png",
					Text = "Fashion",
					Column = 0,
					Row = 0,
					NavigateType = typeof(Page1)
				},
				new DashSquare () {
					BackgroundImage = "childrenbg.png",
					IconImage = "children.png",
					Text = "Children",
					Column = 1,
					Row = 0,
					NavigateType = typeof(Page2)
				},
				new DashSquare () {
					BackgroundImage = "shoesbg.png",
					IconImage = "shoes.png",
					Text = "Shoes",
					Column = 2,
					Row = 0,
					NavigateType = typeof(Page3)
				},
				new DashSquare () {
					BackgroundImage = "luggagebg.png",
					IconImage = "luggage.png",
					Text = "Luggage",
					Column = 0,
					Row = 1,
					NavigateType = typeof(Page4)
				},
				new DashSquare () {
					BackgroundImage = "accessoriesbg.png",
					IconImage = "accessories.png",
					Text = "Accessories",
					Column = 1,
					Row = 1,
					NavigateType = typeof(Page5)
				},
				new DashSquare () {
					BackgroundImage = "housewaresbg.png",
					IconImage = "housewares.png",
					Text = "Housewares",
					Column = 2,
					Row = 1,
					NavigateType = typeof(Page6)
				},
				new DashSquare () { 
					BackgroundImage = "giftsbg.png", 
					IconImage = "gifts.png", 
					Text = "Gifts", 
					Column = 0, 
					Row = 2,
					NavigateType = typeof(Page7)
				},
				new DashSquare () { 
					BackgroundImage = "foodbg.png", 
					IconImage = "food.png", 
					Text = "Food", 
					Column = 1, 
					Row = 2,
					NavigateType = typeof(Page8)
				},
				new DashSquare () {
					BackgroundImage = "restroomsbg.png",
					IconImage = "restrooms.png",
					Text = "Restrooms",
					Column = 2,
					Row = 2,
					NavigateType = typeof(Page9)
				},
				new DashSquare () {
					BackgroundImage = "vendingbg.png",
					IconImage = "vending.png",
					Text = "Vending",
					Column = 0,
					Row = 3,
					NavigateType = typeof(Page10)
				},
				new DashSquare () {
					BackgroundImage = "servicesbg.png",
					IconImage = "services.png",
					Text = "Services",
					Column = 1,
					Row = 3,
					NavigateType = typeof(Page11)
				},
				new DashSquare () { BackgroundImage = "hoursbg.png", 
					IconImage = "hours.png", 
					Text = "Hours", 
					Column = 2, 
					Row = 3,
					NavigateType = typeof(Page12)
				}
			};
		}
	}
}