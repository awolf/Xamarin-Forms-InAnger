using System;
using System.Collections.Generic;

namespace InAnger.HeatMap
{
	public static class AppData
	{
		public static List<string> Days {
			get { 
				return new List<string> () { "Sun", "Mon", "Tue", "Wed", "Thr", "Fri", "Sat" };
			}
		}

		public static List<string> Hours {
			get { 
				return new List<string> () {
					"12 AM", "1 AM", "2 AM", "3 AM", "4 AM", "5 AM", 
					"6 AM",	"7 AM", "8 AM", "9 AM", "10 AM", "11 AM", 
					"12 PM", "1 PM",	"2 PM",	"3 PM",	"4 PM", "5 PM", 
					"6 PM", "7 PM", "8 PM", "9 PM", "10 PM", "11 PM"
				};
			}
		}

		public static int[,] Values {
			get {

				return new int[7, 24] { {
						0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
					}, { 
						1, 1, 0, 1, 2, 3, 3, 3, 2, 2, 2, 1, 1, 2, 1, 1, 0, 1, 0, 0, 0, 0, 1, 1
					}, { 
						1, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1
					}, { 
						0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
					}, { 
						0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
					}, { 
						1, 1, 1, 0, 1, 2, 2, 2, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
					}, { 
						0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
					}
				};
			}
		}
	}
}

