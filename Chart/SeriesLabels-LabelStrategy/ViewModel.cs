using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesLabels_LabelStrategy
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private List<ChartData> data;

        public ViewModel()
        {
            this.Data = this.GetData();
        }

        public List<ChartData> Data
        {
            get
            {
                return this.data;
            }
            set
            {
                if (this.data != value)
                {
                    this.data = value;
                    this.OnPropertyChanged("Data");
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private List<ChartData> GetData()
        {
            List<ChartData> data = new List<ChartData>();
            data.Add(new ChartData() { Category = "A", Value = 10, Value2 = 20 });
            data.Add(new ChartData() { Category = "B", Value = 5, Value2 = 5 });
            data.Add(new ChartData() { Category = "C", Value = 15, Value2 = 5 });
            data.Add(new ChartData() { Category = "D", Value = 20, Value2 = 10 });
            data.Add(new ChartData() { Category = "E", Value = 25, Value2 = 15 });
            data.Add(new ChartData() { Category = "F", Value = 30, Value2 = 10 });

            return data;
        }
    }
}
