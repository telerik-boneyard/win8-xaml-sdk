using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderControl.ViewModel
{
	public class Team : INotifyPropertyChanged
	{
		public Team(string name, int wins, int draws, int losses, int scored, int received)
		{
			this.Name = name;
			this.Wins = wins;
			this.Draws = draws;
			this.Losses = losses;
			this.Scored = scored;
			this.Received = received;
		}
		public Team(int position, string name, int wins, int draws, int losses, int scored, int received, int points, string seasonStart, string seasonEnd)
		{
			this.Position = position;
			this.Name = name;
			this.Wins = wins;
			this.Draws = draws;
			this.Losses = losses;
			this.Scored = scored;
			this.Received = received;
			this.Points = points;
			this.SeasonStart = seasonStart;
			this.SeasonEnd = seasonEnd;
		}
		public string Name { get; set; }
		public int Position { get; set; }
		public int Wins { get; set; }
		public int Draws { get; set; }
		public int Losses { get; set; }
		public int Scored { get; set; }
		public int Received { get; set; }
		public int Points { get; set; }
		public string SeasonStart { get; set; }
		public string SeasonEnd { get; set; }

		private List<Match> matches;
		public List<Match> Matches
		{
			get
			{
				return this.matches;
			}
			set
			{
				this.matches = value;
				this.RaisePropertyChanged("Matches");
			}
		}
		public event PropertyChangedEventHandler PropertyChanged;
		private void RaisePropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
