using ExpanderControl.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderControl.Parser
{
	public class MatchParser : GoogleSpreadsheetParser
	{
		private string allMatchesTemplate = @"http://spreadsheets.google.com/tq?tqx=out:json&tq=select%20*%20where%20((A%3D{0}%20and%20B%3E%3D9)%20or%20(A%3D{1}%20and%20B%20%3C%209))&key=19kKkaLqPf6Ddp7Xk66mhtGg2YB4sThE8e8VqKzSb0eo";
		private string teamTemplate = @"http://spreadsheets.google.com/tq?tqx=out:json&tq=select%20*%20where%20(D%20contains%20%22{0}%22%20or%20F%20contains%20%22{0}%22)%20and%20((A%3D{1}%20and%20B%3E%3D9)%20or%20(A%3D{2}%20and%20B%3C9))&key=19kKkaLqPf6Ddp7Xk66mhtGg2YB4sThE8e8VqKzSb0eo";
		
		async public Task<List<Match>> GetMatches(string start, string end)
		{
			string json = String.Format(this.allMatchesTemplate, start, end);
			return await this.GetMatches(json);
		}
		async public Task<List<Match>> GetMatches(string start, string end, string team)
		{
			string json = String.Format(this.teamTemplate, team, start, end);
			return await this.GetMatches(json);
		}

		async public Task<List<Match>> GetMatches(string json)
		{
			List<Match> matches = new List<Match>();

			JObject obj = await GetJson(json);

			for (int row = 0; row < obj["table"]["rows"].Count(); row++)
			{
				string year = obj["table"]["rows"][row]["c"][0]["v"].ToString();
				string month = obj["table"]["rows"][row]["c"][1]["v"].ToString();
				string day = obj["table"]["rows"][row]["c"][2]["v"].ToString();
				string homeTeam = obj["table"]["rows"][row]["c"][3]["v"].ToString();
				string homeScore = obj["table"]["rows"][row]["c"][4]["v"].ToString();
				string awayTeam = obj["table"]["rows"][row]["c"][5]["v"].ToString();
				string awayScore = obj["table"]["rows"][row]["c"][6]["v"].ToString();

				Match match = new Match(int.Parse(year), int.Parse(month), int.Parse(day), homeTeam, int.Parse(homeScore), awayTeam, int.Parse(awayScore));
				matches.Add(match);
			}

			return matches;
		}
	}
}
