using JsonReader.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace JsonReader
{
	public sealed partial class MainPage : Page
	{
		private ObservableCollection<Match> matches = new ObservableCollection<Match>();
		private QueriesViewModel queriesVM = new QueriesViewModel();
		public MainPage()
		{
			this.InitializeComponent();
			this.queriesListBox.DataContext = this.queriesVM;
			queriesExpander.DataContext = this.queriesVM;
			this.matchesListBox.ItemsSource = this.matches;
		}

		async private void queriesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			this.queriesExpander.IsExpanded = false;
			this.queriesExpander.IsEnabled = false;

			this.matches.Clear();
			var jsonObject = await DownloadWebpageTask.GetJson(queriesVM.SelectedQuery.Url);
			for (int row = 0; row < jsonObject["rows"].Count(); row++)
			{
				var year = int.Parse(jsonObject["rows"][row]["c"][0]["v"].ToString());
				var month = int.Parse(jsonObject["rows"][row]["c"][1]["v"].ToString());
				var day = int.Parse(jsonObject["rows"][row]["c"][2]["v"].ToString());
				var homeTeam = jsonObject["rows"][row]["c"][3]["v"].ToString();
				var homeScore = int.Parse(jsonObject["rows"][row]["c"][4]["v"].ToString());
				var awayTeam = jsonObject["rows"][row]["c"][5]["v"].ToString();
				var awayScore = int.Parse(jsonObject["rows"][row]["c"][6]["v"].ToString());
				Match match = new Match(year, month, day, homeTeam, homeScore, awayTeam, awayScore);
				this.matches.Add(match);
			}

			this.queriesExpander.IsEnabled = true;
		}
	}
}
