using System;
using System.Collections.Generic;
using System.Text;

namespace ExpanderControl.ViewModel
{
    public class Team
    {
        public Team(int position, string name, int wins, int draws, int losses, int scored, int received, int points)
        {
            this.Position = position;
            this.Name = name;
            this.Wins = wins;
            this.Draws = draws;
            this.Losses = losses;
			this.Scored = scored;
			this.Received = received;
            this.Points = points;
        }
        public string Name { get; set; }
        public int Position { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
		public int Scored { get; set; }
		public int Received { get; set; }
        public int Points { get; set; }
    }
}
