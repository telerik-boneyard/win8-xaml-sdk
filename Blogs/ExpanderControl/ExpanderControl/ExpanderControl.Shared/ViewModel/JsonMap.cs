using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderControl.ViewModel
{
	public class JsonMap : Dictionary<string, string>
	{
		private string url = "http://spreadsheets.google.com/a/google.com/tq?key=1ipEKzpj6st75zgWafIf4XrIeGtWrRopNIz5uFlh-zbU";
		public JsonMap()
		{
			
		}

		public string Url { get { return this.url; } }
	}
}
