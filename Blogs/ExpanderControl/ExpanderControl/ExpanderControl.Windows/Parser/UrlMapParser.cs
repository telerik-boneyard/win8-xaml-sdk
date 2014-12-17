using ExpanderControl.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderControl.Parser
{
	public class UrlMapParser : GoogleSpreadsheetParser
	{
		private static string jsonUrl = "http://spreadsheets.google.com/a/google.com/tq?key=1ipEKzpj6st75zgWafIf4XrIeGtWrRopNIz5uFlh-zbU";
		public UrlMapParser()
		{

		}
		async public static Task<Dictionary<string, string>> GetMap()
		{
			JObject obj = await GetJson(jsonUrl);
			Dictionary<string, string> map = new Dictionary<string, string>();

			for (int row = 0; row < obj["table"]["rows"].Count(); row++)
			{
				string start = obj["table"]["rows"][row]["c"][0]["v"].ToString();
				string end = obj["table"]["rows"][row]["c"][1]["v"].ToString();
				string json = obj["table"]["rows"][row]["c"][2]["v"].ToString();
				map.Add(string.Concat(start,"-",end), json);
			}

			return map;
		}
	}
}
