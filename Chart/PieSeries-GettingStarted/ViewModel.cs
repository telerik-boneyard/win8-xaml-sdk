using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieSeries_GettingStarted
{
    public class ViewModel
    {
        public ObservableCollection<CustomPoint> GetData
        {
            get
            {
                ObservableCollection<CustomPoint> collection = new ObservableCollection<CustomPoint>();
                collection.Add(new CustomPoint { Value = 6 });
                collection.Add(new CustomPoint { Value = 20 });
                collection.Add(new CustomPoint { Value = 3 });
                collection.Add(new CustomPoint { Value = 9 });
                return collection;
            }
        }
    }
}
