using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScatterSeries_GettingStarted
{
    public class ViewModel
    {

        public ObservableCollection<CustomPoint> GetData
        {
            get
            {
                ObservableCollection<CustomPoint> collection = new ObservableCollection<CustomPoint>();
                collection.Add(new CustomPoint { XValue = 2, YValue = 3 });
                collection.Add(new CustomPoint { XValue = 5, YValue = 6 });
                collection.Add(new CustomPoint { XValue = 8, YValue = 3 });
                collection.Add(new CustomPoint { XValue = 10, YValue = 5 });
                collection.Add(new CustomPoint { XValue = 14, YValue = 1 });
                return collection;
            }
        }
    }
}
