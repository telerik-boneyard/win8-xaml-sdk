using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesLabels_LabelDefinitions
{
    public class ViewModel
    {
        public ViewModel()
        {
            List<CustomPoint> collection = new List<CustomPoint>();
            collection.Add(new CustomPoint { Category = "Apples", Value = 10, LabelProperty = "First Point" });
            collection.Add(new CustomPoint { Category = "Oranges", Value = 8, LabelProperty = "Second Point" });
            collection.Add(new CustomPoint { Category = "Pineapples", Value = 21, LabelProperty = "Third Point" });
            this.SeriesData = collection;
        }
        public List<CustomPoint> SeriesData { get; set; }
    }
}
