using System;
using System.Collections.Generic;
using System.Text;

namespace ExpanderControl.ViewModels
{
	public class RedditViewModel
	{

		private List<RedditEntry> entries = new List<RedditEntry>();
		public RedditViewModel()
		{
			var entry = new RedditEntry();
			entry.ImageUrl = "/Images/1.jpg";
			entry.Text = "Today is Oakley's birthday";
			entries.Add(entry);

			entry = new RedditEntry();
			entry.ImageUrl = "/Images/2.jpg";
			entry.Text = "I think someone was a little tired";
			entries.Add(entry);

			entry = new RedditEntry();
			entry.ImageUrl = "/Images/3.jpg";
			entry.Text = "Otter pup";
			entries.Add(entry);

			entry = new RedditEntry();
			entry.ImageUrl = "/Images/4.jpg";
			entry.Text = "Huskies in love";
			entries.Add(entry);

			entry = new RedditEntry();
			entry.ImageUrl = "/Images/5.jpg";
			entry.Text = "Puppy hug!";
			entries.Add(entry);

			entry = new RedditEntry();
			entry.ImageUrl = "/Images/6.jpg";
			entry.Text = "My cat when I first adopted her and 3 years later.";
			entries.Add(entry);

			entry = new RedditEntry();
			entry.ImageUrl = "/Images/7.jpg";
			entry.Text = "50% cat, 50% gentleman, 100% adorable";
			entries.Add(entry);

			entry = new RedditEntry();
			entry.ImageUrl = "/Images/8.jpg";
			entry.Text = " Little Saint, Big Bone";
			entries.Add(entry);

			entry = new RedditEntry();
			entry.ImageUrl = "/Images/9.jpg";
			entry.Text = "This is Charley. Charley reaaaaaally likes cabbage.";
			entries.Add(entry);
		}

		public List<RedditEntry> Entries
		{
			get
			{
				return this.entries;
			}
		}
	}
}
