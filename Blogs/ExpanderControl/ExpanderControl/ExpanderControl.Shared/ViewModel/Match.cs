using System;
using System.Collections.Generic;
using System.Text;

namespace ExpanderControl.ViewModel
{
	public class Match : BaseModel
	{
		private string date;
		private int year, month, day, homeScore, awayScore, received;
		private Team homeTeam, awayTeam;
		public Match(string year, string month, string day, string homeTeam, string homeScore, string awayTeam, string awayScore)
		{
			this.Year = int.Parse(year);
			this.Month = int.Parse(month);
			this.Day = int.Parse(day);
			this.HomeTeam = new Team(homeTeam);
			this.HomeScore = int.Parse(homeScore);
			this.AwayTeam = new Team(awayTeam);
			this.AwayScore = int.Parse(awayScore);
		}
		public string Date
		{
			get
			{
				return this.date;
			}
			set
			{
				if (this.date != value)
				{
					this.date = value;
					this.OnPropertyChanged("Date");
				}
			}
		}
		public int Year
		{
			get
			{
				return this.year;
			}
			set
			{
				if (this.year != value)
				{
					this.year = value;
					this.OnPropertyChanged("Year");
				}
			}
		}
		public int Month
		{
			get
			{
				return this.month;
			}
			set
			{
				if (this.month != value)
				{
					this.month = value;
					this.OnPropertyChanged("Month");
				}
			}
		}
		public int Day
		{
			get
			{
				return this.day;
			}
			set
			{
				if (this.day != value)
				{
					this.day = value;
					this.OnPropertyChanged("Day");
				}
			}
		}
		public Team HomeTeam
		{
			get
			{
				return this.homeTeam;
			}
			set
			{
				if (this.homeTeam != value)
				{
					this.homeTeam = value;
					this.OnPropertyChanged("HomeTeam");
				}
			}
		}
		public Team AwayTeam
		{
			get
			{
				return this.awayTeam;
			}
			set
			{
				if (this.awayTeam != value)
				{
					this.awayTeam = value;
					this.OnPropertyChanged("AwayTeam");
				}
			}
		}
		public int HomeScore
		{
			get
			{
				return this.homeScore;
			}
			set
			{
				if (this.homeScore != value)
				{
					this.homeScore = value;
					this.OnPropertyChanged("HomeScore");
				}
			}
		}
		public int AwayScore
		{
			get
			{
				return this.awayScore;
			}
			set
			{
				if (this.awayScore != value)
				{
					this.awayScore = value;
					this.OnPropertyChanged("AwayScore");
				}
			}
		}
		
		public override bool Equals(object obj)
		{
			Match other = (Match)obj;
			return this.Date == other.Date && this.HomeTeam == other.HomeTeam && this.AwayTeam == other.AwayTeam;
		}
	}
}
