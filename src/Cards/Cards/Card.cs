using System;

using Xamarin.Forms;

namespace Cards
{
	public class Card
	{
		public CardStatus Status { get; set; }

		public FileImageSource StatusMessageFileSource { get; set; }

		public string StatusMessage { get; set; }

		public FileImageSource ActionMessageFileSource { get; set; }

		public string ActionMessage { get; set; }

		public FormattedString Title { get; set; }

		public string Description { get; set; }

		public ContentView MessageView { get; set; }

		public ContentView ActionView { get; set; }

		public DateTime DueDate { get; set; }

		public int DirationInMinutes { get; set; }
	}

	public enum CardStatus
	{
		Alert,
		Completed,
		Unresolved
	}
}