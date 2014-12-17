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
		private MainViewModel viewModel = new MainViewModel();

		public MainPage()
		{
			this.InitializeComponent();
			this.DataContext = this.viewModel;
		}

		async private void TeamExpander_IsExpandedChanged(object sender, EventArgs e)
		{
			var team = (Team)(sender as ExpanderControl).DataContext;
			var season = this.viewModel.SelectedSeason;
			team.Matches = await FootballParser.GetMatches(season, team);
			foreach (var match in team.Matches)
			{
				if (match.HomeTeam.Equals(team))
					match.HomeTeam.IsOfInterest = true;
				if (match.AwayTeam.Equals(team))
					match.AwayTeam.IsOfInterest = true;

			}
			//var allMatches = await new MatchParser().GetMatches(team.SeasonStart, team.SeasonEnd);

			//var engine = new PositionEngine(allMatches, team);

			//var teamMatches = allMatches.Where(match => match.HomeTeam.Contains(team.Name) || match.AwayTeam.Contains(team.Name)).ToList();


			//team.Matches = teamMatches;
		}

		async private void SelectionChanged_Seasons(object sender, SelectionChangedEventArgs e)
		{
			var selectedSeason = (Season)e.AddedItems[0];
			this.viewModel.SelectedSeason = selectedSeason;
			selectedSeason.Teams = await FootballParser.GetTeams(selectedSeason);

			//this.seasons.IsDropDownOpen = false;
			//this.seasons.IsEnabled = false;

			//telerikListBox.ItemsSource = null;
			//telerikListBox.EmptyContent = "Fetching data...";

			//telerikListBox.ItemsSource = await new FootballParser(season).GetAllTeams();

			//this.seasons.IsEnabled = true;
		}

		async private void DropDownOpened_Seasons(object sender, object e)
		{

		}

		async private void Button_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			if (this.viewModel.Seasons == null)
			{
				this.comboSeasons.Header = "Downloading map";
				this.viewModel.Seasons = await FootballParser.GetSeasons();
				this.comboSeasons.Header = "Download complete";
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


			foreach (var match in seasonMatches)
			{

			}

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
