using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderControl.ViewModel
{
	public class Season
	{
		public Season(string start, string end, string json)
		{
			this.Start = start;
			this.End = end;
			this.Json = json;
		}

		public string Start { get; set; }
		public string End { get; set; }
		public string Json { get; set; }
	
	}
}
