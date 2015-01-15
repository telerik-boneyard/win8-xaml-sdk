using Json_Reader_Universal.ViewModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Json_Reader_Universal
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		private ObservableCollection<Team> finalTable = new ObservableCollection<Team>();

		public MainPage()
		{
			this.InitializeComponent();
			this.listBox.ItemsSource = this.finalTable;
		}

		async private void DownloadButton_Click(object sender, RoutedEventArgs e)
		{
			this.finalTable.Clear();
			var jsonObject = await DownloadWebpageTask.GetJson();
			for (int row = 0; row < jsonObject["rows"].Count(); row++)
			{
				Team team = new Team();

				team.Position = int.Parse(jsonObject["rows"][row]["c"][0]["v"].ToString());
				team.Name = jsonObject["rows"][row]["c"][1]["v"].ToString();
				team.Wins = int.Parse(jsonObject["rows"][row]["c"][3]["v"].ToString());
				team.Draws = int.Parse(jsonObject["rows"][row]["c"][4]["v"].ToString());
				team.Losses = int.Parse(jsonObject["rows"][row]["c"][5]["v"].ToString());
				team.Points = int.Parse(jsonObject["rows"][row]["c"][19]["v"].ToString());
				this.finalTable.Add(team);
			}
		}
	}
}
