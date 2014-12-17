using ExpanderControl.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderControl.Parser
{
	public class YearTableParser : GoogleSpreadsheetParser
	{
		private string json;
		private string start, end;
		public YearTableParser(string season, string json)
		{
			this.json = json;
			string[] s = season.Split('-');
			this.start = s[0];
			this.end = s[1];
		}
		async public Task<List<Team>> GetAllTeams()
		{
			JObject obj = await GetJson(json);
			List<Team> teams = new List<Team>();

			for (int row = 0; row < obj["table"]["rows"].Count(); row++)
			{
				string position = obj["table"]["rows"][row]["c"][0]["v"].ToString();
				string name = obj["table"]["rows"][row]["c"][1]["v"].ToString();
				string wins = obj["table"]["rows"][row]["c"][3]["v"].ToString();
				string draws = obj["table"]["rows"][row]["c"][4]["v"].ToString();
				string losses = obj["table"]["rows"][row]["c"][5]["v"].ToString();
				string scored = obj["table"]["rows"][row]["c"][6]["v"].ToString();
				string received = obj["table"]["rows"][row]["c"][7]["v"].ToString();
				string points = obj["table"]["rows"][row]["c"][19]["v"].ToString();

				Team newTeam = new Team(int.Parse(position), name, int.Parse(wins), int.Parse(draws), int.Parse(losses), int.Parse(scored), int.Parse(received), int.Parse(points), start, end);
				teams.Add(newTeam);
			}

			return teams;
		}
	}
}
