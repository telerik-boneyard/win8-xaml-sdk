using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarSeries_GettingStarted
{
    public class ViewModel
    {
        public ObservableCollection<CustomPoint> GetData
        {
            get
            {
                ObservableCollection<CustomPoint> collection = new ObservableCollection<CustomPoint>();
                for (double i = 1; i < 30; i += 1)
                {
                    collection.Add(new CustomPoint() { Category = i, Value = ((0.7) * Math.Cos(20 * i)) });
                }
                return collection;
            }
        }
    }
}
