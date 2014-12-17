using ExpanderControl.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderControl.Parser
{
	public class FootballParser : GoogleSpreadsheetParser
	{
		//private static string allMatchesTemplate = @"http://spreadsheets.google.com/tq?tqx=out:json&tq=select%20*%20where%20((A%3D{0}%20and%20B%3E%3D9)%20or%20(A%3D{1}%20and%20B%20%3C%209))&key=19kKkaLqPf6Ddp7Xk66mhtGg2YB4sThE8e8VqKzSb0eo";
		private static string teamTemplate = @"http://spreadsheets.google.com/tq?tqx=out:json&tq=select%20*%20where%20(D%20contains%20%22{0}%22%20or%20F%20contains%20%22{0}%22)%20and%20((A%3D{1}%20and%20B%3E%3D9)%20or%20(A%3D{2}%20and%20B%3C9))&key=19kKkaLqPf6Ddp7Xk66mhtGg2YB4sThE8e8VqKzSb0eo";

		async public static Task<List<Team>> GetTeams(Season season)
		{
			JObject obj = await GetJson(season.Url);
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

				Team team = new Team(name, position, wins, draws, losses, scored, received, points);
				teams.Add(team);
			}

			return teams;
		}

		async public static Task<List<Match>> GetMatches(Season season, Team team)
		{
			string json = String.Format(teamTemplate, team.Name, season.Start, season.End);
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

				Match match = new Match(year, month, day, homeTeam, homeScore, awayTeam, awayScore);
				matches.Add(match);
			}

			return matches;
		}

		async public static Task<List<Season>> GetSeasons()
		{
			string jsonUrl = "http://spreadsheets.google.com/a/google.com/tq?key=1ipEKzpj6st75zgWafIf4XrIeGtWrRopNIz5uFlh-zbU";
			JObject obj = await GetJson(jsonUrl);
			List<Season> map = new List<Season>();

			for (int row = 0; row < obj["table"]["rows"].Count(); row++)
			{
				string start = obj["table"]["rows"][row]["c"][0]["v"].ToString();
				string end = obj["table"]["rows"][row]["c"][1]["v"].ToString();
				string json = obj["table"]["rows"][row]["c"][2]["v"].ToString();
				map.Add(new Season(start, end, json));
			}

			return map;
		}
	}
}
