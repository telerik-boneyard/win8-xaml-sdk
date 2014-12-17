using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExpanderControl.ViewModel
{
    public class BaseModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
    }
}
