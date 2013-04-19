using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoricalSeries_GettingStarted
{
    public class ViewModel
    {

        public ObservableCollection<CustomPoint> SeriesData
        {
            get
            {
                ObservableCollection<CustomPoint> collection = new ObservableCollection<CustomPoint>();
                collection.Add(new CustomPoint { Category = "Apples", Value = 5 });
                collection.Add(new CustomPoint { Category = "Oranges", Value = 9 });
                collection.Add(new CustomPoint { Category = "Pineapples", Value = 8 });
                return collection;
            }
        }
    }
}
