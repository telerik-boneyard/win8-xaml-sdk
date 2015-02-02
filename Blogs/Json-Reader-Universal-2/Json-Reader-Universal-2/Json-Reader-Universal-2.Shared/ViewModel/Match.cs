using System;
using System.Collections.Generic;
using System.Text;

namespace JsonReader.ViewModel
{
	public class Match
	{
		private int year, month, day, homeScore, awayScore;
		private string homeTeam, awayTeam;
		public Match(int year, int month, int day, String homeTeam, int homeScore, String awayTeam, int awayScore)
		{
			this.Year = year;
			this.Month = month;
			this.Day = day;
			this.HomeTeam = homeTeam;
			this.HomeScore = homeScore;
			this.AwayTeam = awayTeam;
			this.AwayScore = awayScore;
		}
		public int Year { get; set; }
		public int Month { get; set; }
		public int Day { get; set; }
		public int HomeScore { get; set; }
		public int AwayScore { get; set; }
		public string HomeTeam { get; set; }
		public string AwayTeam { get; set; }
		public string Date
		{
			get
			{
				return string.Format("{0}/{1}/{2}", this.Year, this.Month, this.Day);
			}
		}
		public string Result
		{
			get
			{
				return string.Format("{0} - {1}", this.HomeScore, this.AwayScore);
			}
		}
	}
}
