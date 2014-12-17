using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderControl.Parser
{
	public class GoogleSpreadsheetParser
	{
		async protected static Task<JObject> GetJson(string url)
		{
			var client = new HttpClient();

			var response = await client.GetAsync(new Uri(url));
			var rawResult = await response.Content.ReadAsStringAsync();
			var startIndex = rawResult.IndexOf('{');
			var length = rawResult.Length - startIndex - 2;

			var jsonResponse = rawResult.Substring(startIndex, length);
			return JObject.Parse(jsonResponse);
		}
	}
}
