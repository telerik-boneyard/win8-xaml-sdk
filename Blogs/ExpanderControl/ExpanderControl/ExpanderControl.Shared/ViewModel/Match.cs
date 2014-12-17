using System;
using System.Collections.Generic;
using System.Text;

namespace ExpanderControl.ViewModel
{
    public class Match
    {
		public Match(int year, int month, int day, string homeTeam, int homeScore, string awayTeam, int awayScore)
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
		public string HomeTeam { get; set; }
		public int HomeScore { get; set; }
		public string AwayTeam { get; set; }
		public int AwayScore { get; set; }
    }
}
