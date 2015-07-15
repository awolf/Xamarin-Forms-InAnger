using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Cards
{
	public class CardData : List<Card>
	{
		public CardData ()
		{
			Add (
				new Card () { 
					Status = CardStatus.Alert, 
					Description = "Data Structures",
					DueDate = DateTime.Now.AddDays (1),
					DirationInMinutes = 45,
					StatusMessage = "1 Day left!",
					StatusMessageFileSource = StyleKit.Icons.Alert,
					ActionMessage = "Resume",
					ActionMessageFileSource = StyleKit.Icons.Resume,
					Title = new FormattedString () {
						Spans = {
							new Span () {
								Text = "CS-101 Python,"
							},
							new Span () {
								Text = " Exercise 6,",
								FontAttributes = FontAttributes.Bold
							}
						}
					} 
				}
			);

			Add (
				new Card () { 
					Status = CardStatus.Alert, 
					Description = "Modules & Functions",
					DueDate = DateTime.Now.AddDays (3),
					DirationInMinutes = 60,
					StatusMessage = "3 Days left!",
					StatusMessageFileSource = StyleKit.Icons.Alert,
					ActionMessage = "Resume",
					ActionMessageFileSource = StyleKit.Icons.Resume,
					Title = new FormattedString () {
						Spans = {
							new Span () {
								Text = "CS-101 Python,"
							},
							new Span () {
								Text = " Exercise 5,",
								FontAttributes = FontAttributes.Bold
							}
						}
					} 
				}
			);

			Add (
				new Card () { 
					Status = CardStatus.Completed, 
					Description = "Control Flow (if, while and for loop)",
					DueDate = DateTime.Now.AddDays (-5),
					DirationInMinutes = 35,
					StatusMessage = "Assignment Completed",
					StatusMessageFileSource = StyleKit.Icons.Completed,
					ActionMessage = "Report",
					ActionMessageFileSource = StyleKit.Icons.Report,
					Title = new FormattedString () {
						Spans = {
							new Span () {
								Text = "CS-101 Python,"
							},
							new Span () {
								Text = " Exercise 4,",
								FontAttributes = FontAttributes.Bold
							}
						}
					} 
				}
			);

			Add (
				new Card () { 
					Status = CardStatus.Unresolved, 
					Description = "Variables and Constants",
					DueDate = DateTime.Now.AddDays (-8),
					DirationInMinutes = 25,
					StatusMessage = "Unresolved",
					StatusMessageFileSource = StyleKit.Icons.Unresolved,
					ActionMessage = "Start",
					ActionMessageFileSource = StyleKit.Icons.Resume,
					Title = new FormattedString () {
						Spans = {
							new Span () {
								Text = "CS-101 Python,"
							},
							new Span () {
								Text = " Exercise 3,",
								FontAttributes = FontAttributes.Bold
							}
						}
					} 
				}
			);

			Add (
				new Card () { 
					Status = CardStatus.Completed, 
					Description = "Basics",
					DueDate = DateTime.Now.AddDays (-9),
					DirationInMinutes = 35,
					StatusMessage = "Assignment Completed",
					StatusMessageFileSource = StyleKit.Icons.Completed,
					ActionMessage = "Report",
					ActionMessageFileSource = StyleKit.Icons.Report,
					Title = new FormattedString () {
						Spans = {
							new Span () {
								Text = "CS-101 Python,"
							},
							new Span () {
								Text = " Exercise 2,",
								FontAttributes = FontAttributes.Bold
							}
						}
					} 
				}
			);
		}
	}
}