using ExpanderControl.Parser;
using ExpanderControl.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ExpanderControl
{
	public sealed partial class MainPage : Page
	{
		List<Season> map = null;

		public MainPage()
		{
			this.InitializeComponent();
			this.telerikListBox.ItemsSource = new List<Team>();
		}

		async private void TeamExpander_IsExpandedChanged(object sender, EventArgs e)
		{
			Team team = (Team)(sender as ExpanderControl).DataContext;

			var allMatches = await new MatchParser().GetMatches(team.SeasonStart, team.SeasonEnd);

			var engine = new PositionEngine(allMatches, team);

			//var teamMatches = allMatches.Where(match => match.HomeTeam.Contains(team.Name) || match.AwayTeam.Contains(team.Name)).ToList();


			//team.Matches = teamMatches;
		}

		async private void seasons_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			this.seasons.IsDropDownOpen = false;
			this.seasons.IsEnabled = false;

			var season = (Season)e.AddedItems[0];
			telerikListBox.ItemsSource = null;
			telerikListBox.EmptyContent = "Fetching data...";

			telerikListBox.ItemsSource = await new YearTableParser(season).GetAllTeams();

			this.seasons.IsEnabled = true;
		}

		async private void seasons_DropDownOpened(object sender, object e)
		{
			if (this.map == null)
			{
				this.seasons.IsEnabled = false;
				this.map = await UrlMapParser.GetMap();
				this.seasons.ItemsSource = this.map;
				this.seasons.IsEnabled = true;
				this.seasons.IsDropDownOpen = true;
			}
		}
	}

	public class PositionEngine
	{
		public PositionEngine(List<Match> seasonMatches, Team teamOfInterest)
		{
			var rounds = seasonMatches.GroupBy(match => match.Date).ToList();
			var teams = seasonMatches.GroupBy(match => match.HomeTeam).ToList();
			foreach (var team in teams)
			{
				var teamName = team.First().HomeTeam;
			}
			//var teams = seasonMatches.Distinct(new TeamEqualityComparer());
			//foreach (var group in rounds)
			//{

			//}


		}
	}

	public class TeamEqualityComparer : IEqualityComparer<Team>
	{

		public bool Equals(Team t1, Team t2)
		{
			if (t1.Name == t2.Name)
			{
				return true;
			}
			else
			{
				return false;
			}
		}



		public int GetHashCode(Team team)
		{
			int hCode = team.Wins ^ team.Draws ^ team.Losses;
			return hCode.GetHashCode();
		}
	}
}
