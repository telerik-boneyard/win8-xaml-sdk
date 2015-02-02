using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace JsonReader.ViewModel
{
	public class QueriesViewModel : INotifyPropertyChanged
	{
		private Query selectedQuery;
		public QueriesViewModel()
		{
			this.Queries = new List<Query>();
			Query q = new Query();

			q.Description = "Season 2013-2014 matches";
			q.Url = QueryStrings.selectSeason2013_2014;
			this.Queries.Add(q);

			q = new Query();
			q.Description = "Matches before 1900";
			q.Url = QueryStrings.selectAllBefore1900;
			this.Queries.Add(q);

			q = new Query();
			q.Description = "Aston Villa wins between 1990 and 2000";
			q.Url = QueryStrings.selectWinsAstonVilla1900_2000;
			this.Queries.Add(q);

			q = new Query();
			q.Description = "All Liverpool wins since 1888";
			q.Url = QueryStrings.selectWinsLiverpool;
			this.Queries.Add(q);

			q = new Query();
			q.Description = "All matches since 1888";
			q.Url = QueryStrings.selectAll;
			this.Queries.Add(q);

			this.selectedQuery = this.Queries[0];
		}
		public Query SelectedQuery
		{
			get
			{
				return this.selectedQuery;
			}
			set
			{
				if (this.selectedQuery != value)
				{
					this.selectedQuery = value;
					this.OnPropertyChanged("SelectedQuery");
				}
			}
		}
		public List<Query> Queries { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
