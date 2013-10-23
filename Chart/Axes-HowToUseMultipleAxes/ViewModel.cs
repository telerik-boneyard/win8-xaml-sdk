using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axes_HowToUseMultipleAxes
{
    public class ViewModel
    {

        public ObservableCollection<Data> GetData
        {
            get
            {
                ObservableCollection<Data> collection = new ObservableCollection<Data>();
                collection.Add(new Data { LineCategory = "firstPoint", LineValue = 1, BarCategory = DateTime.Now.AddYears(1), BarValue = 10 });
                collection.Add(new Data { LineCategory = "secondPoint", LineValue = 5, BarCategory = DateTime.Now.AddYears(2), BarValue = 11 });
                collection.Add(new Data { LineCategory = "thirdPoint", LineValue = 2, BarCategory = DateTime.Now.AddYears(3), BarValue = 3 });
                return collection;
            }
        }
    }
}
