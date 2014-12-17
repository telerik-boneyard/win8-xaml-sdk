using ExpanderControl.ViewModel;
using Newtonsoft.Json.Linq;
using System.Linq;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text.RegularExpressions;
using Windows.Data.Json;
using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Windows.UI.Xaml;
using ExpanderControl.Parser;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ExpanderControl
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		Dictionary<string, string> map = null;

		public MainPage()
		{
			this.InitializeComponent();
			this.telerikListBox.ItemsSource = new List<Team>();


		}

		async private void ExpanderControl_IsExpandedChanged(object sender, EventArgs e)
		{
			if (this.map == null)
			{
				this.seasonsExpander.IsEnabled = false;
				this.map = await UrlMapParser.GetMap();
				this.seasonsListBox.ItemsSource = this.map;
				this.seasonsExpander.IsEnabled = true;
			}

			if (this.seasonsListBox.SelectedItem != null)
			{
				var kvp = (KeyValuePair<string, string>)this.seasonsListBox.SelectedItem;
				this.seasonsExpander.Header = kvp.Key;
			}
		}

		async private void seasonsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			this.seasonsExpander.IsExpanded = false;
			this.seasonsExpander.IsEnabled = false;
			var kvp = (KeyValuePair<string, string>)e.AddedItems[0];
			telerikListBox.ItemsSource = null;
			telerikListBox.EmptyContent = "Fetching data...";

			string json = kvp.Value;
			telerikListBox.ItemsSource = await new YearTableParser(kvp.Key, kvp.Value).GetAllTeams();

			this.seasonsExpander.IsEnabled = true;
		}

		async private void RadDataBoundListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		async private void ExpanderControl_IsExpandedChanged_1(object sender, EventArgs e)
		{
			Team team = (Team)(sender as ExpanderControl).DataContext;
			team.Matches = await new MatchParser(team.SeasonStart, team.SeasonEnd, team.Name).GetMatches();
		}
	}

}
