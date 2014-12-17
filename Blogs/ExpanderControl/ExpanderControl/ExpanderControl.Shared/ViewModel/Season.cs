using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderControl.ViewModel
{
	public class Season : BaseModel
	{
		private List<Team> teams;
		private List<Match> matches;
		private int start, end;
		private string url;
		public Season()
		{

		}
		public Season(string start, string end, string jsonUrl)
			: this(int.Parse(start), int.Parse(end), jsonUrl)
		{
		}
		public Season(int start, int end, string jsonUrl)
		{
			this.Start = start;
			this.End = end;
			this.Url = jsonUrl;
		}
		public Season(string season, string jsonUrl)
		{
			string[] s = season.Split('-');
			this.Start = int.Parse(s[0]);
			this.End = int.Parse(s[1]);
			this.Url = jsonUrl;
		}
		public int Start
		{
			get
			{
				return this.start;
			}
			set
			{
				if (this.start != value)
				{
					this.start = value;
					this.OnPropertyChanged("Start");
				}
			}
		}
		public int End
		{
			get
			{
				return this.end;
			}
			set
			{
				if (this.end != value)
				{
					this.end = value;
					this.OnPropertyChanged("End");
				}
			}
		}
		public List<Team> Teams
		{
			get
			{
				return this.teams;
			}
			set
			{
				if (this.teams != value)
				{
					this.teams = value;
					this.OnPropertyChanged("Teams");
				}
			}
		}
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
					this.OnPropertyChanged("Matches");
				}
			}
		}
		public string Url
		{
			get
			{
				return this.url;
			}
			set
			{
				if (this.url != value)
				{
					this.url = value;
					this.OnPropertyChanged("Url");
				}
			}
		}
	}
}
