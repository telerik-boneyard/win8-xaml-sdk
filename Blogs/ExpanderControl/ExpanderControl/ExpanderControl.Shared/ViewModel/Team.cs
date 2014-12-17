using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderControl.ViewModel
{
	public class Team : BaseModel
	{
		private string name;
		private int position, wins, draws, losses, scored, received, points;
		public Team(string name)
		{
			this.Name = name;
		}
		public Team(string name, string position, string wins, string draws, string losses, string scored, string received, string points)
		{
			this.Name = name;
			this.SetPositionFromText(position);
			this.SetWinsFromText(wins);
			this.SetDrawsFromText(draws);
			this.SetLossesFromText(losses);
			this.SetScoredFromText(scored);
			this.SetReceivedFromText(received);
			this.SetPointsFromText(points);
		}
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (this.name != value)
				{
					this.name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}
		public int Position
		{
			get
			{
				return this.position;
			}
			set
			{
				if (this.position != value)
				{
					this.position = value;
					this.OnPropertyChanged("Position");
				}
			}
		}
		public int Wins
		{
			get
			{
				return this.wins;
			}
			set
			{
				if (this.wins != value)
				{
					this.wins = value;
					this.OnPropertyChanged("Wins");
				}
			}
		}
		public int Draws
		{
			get
			{
				return this.draws;
			}
			set
			{
				if (this.draws != value)
				{
					this.draws = value;
					this.OnPropertyChanged("Draws");
				}
			}
		}
		public int Losses
		{
			get
			{
				return this.losses;
			}
			set
			{
				if (this.losses != value)
				{
					this.losses = value;
					this.OnPropertyChanged("Losses");
				}
			}
		}
		public int Scored
		{
			get
			{
				return this.scored;
			}
			set
			{
				if (this.scored != value)
				{
					this.scored = value;
					this.OnPropertyChanged("Scored");
				}
			}
		}
		public int Received
		{
			get
			{
				return this.received;
			}
			set
			{
				if (this.received != value)
				{
					this.received = value;
					this.OnPropertyChanged("Received");
				}
			}
		}
		public int Points
		{
			get
			{
				return this.points;
			}
			set
			{
				if (this.points != value)
				{
					this.points = value;
					this.OnPropertyChanged("Points");
				}
			}
		}
		protected void SetPositionFromText(string position)
		{
			this.Position = int.Parse(position);
		}
		protected void SetWinsFromText(string wins)
		{
			this.Wins = int.Parse(wins);
		}
		protected void SetDrawsFromText(string draws)
		{
			this.Draws = int.Parse(draws);
		}
		protected void SetLossesFromText(string losses)
		{
			this.Losses = int.Parse(losses);
		}
		protected void SetScoredFromText(string scored)
		{
			this.Scored = int.Parse(scored);
		}
		protected void SetReceivedFromText(string received)
		{
			this.Received = int.Parse(received);
		}
		protected void SetPointsFromText(string points)
		{
			this.Points = int.Parse(points);
		}
		public override bool Equals(object obj)
		{
			Team other = (Team)obj;
			return this.name == other.name;
		}

		private List<Match> matches;
		public List<Match> Matches
		{
			get
			{
				return this.matches;
			}
			set
			{
				if (this.matches != value)
				{
					this.matches = value;
					OnPropertyChanged("Matches");
				}
			}
		}

		private bool isOfInterest;
		public bool IsOfInterest
		{
			get
			{
				return this.isOfInterest;
			}
			set
			{
				if (this.isOfInterest != value)
				{
					this.isOfInterest = value;
					this.OnPropertyChanged("IsOfInterest");
				}
			}
		}

		public void Highlight()
		{
			foreach (var match in this.Matches)
			{
				if (match.HomeTeam == this)
					this.IsOfInterest = true;
				if (match.AwayTeam == this)
					this.IsOfInterest = true;
			}
		}
	}
}
