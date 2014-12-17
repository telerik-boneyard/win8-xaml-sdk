using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace ExpanderControl.ViewModel
{
	public class MainViewModel : BaseModel
	{
		private Season selectedSeason;
		private List<Season> seasons;
		
		public Season SelectedSeason
		{
			get
			{
				return this.selectedSeason;
			}
			set
			{
				if (this.selectedSeason != value)
				{
					this.selectedSeason = value;
					this.OnPropertyChanged("SelectedSeason");
				}
			}
		}
		public List<Season> Seasons
		{
			get
			{
				return this.seasons;
			}
			set
			{
				if (this.seasons != value)
				{
					this.seasons = value;
					this.OnPropertyChanged("Seasons");
				}
			}
		}
	}
}
