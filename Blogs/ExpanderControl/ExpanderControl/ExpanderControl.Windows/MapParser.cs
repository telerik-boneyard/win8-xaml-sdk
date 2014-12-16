using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExpanderControl.ViewModel
{
	public class MapParser
	{
		async public static Task<JsonMap> GetMap()
		{
			JsonMap map = new JsonMap();

			var client = new HttpClient();

			var response = await client.GetAsync(new Uri(map.Url));
			var rawResult = await response.Content.ReadAsStringAsync();
			var startIndex = rawResult.IndexOf('{');
			var length = rawResult.Length - startIndex - 2;

			var jsonResponse = rawResult.Substring(startIndex, length);
			JObject obj = JObject.Parse(jsonResponse);

			for (int row = 0; row < obj["table"]["rows"].Count(); row++)
			{
				string season = obj["table"]["rows"][row]["c"][0]["v"].ToString();
				string url = obj["table"]["rows"][row]["c"][1]["v"].ToString();
				map.Add(season, url);
			}

			return map;
		}
	}
}
