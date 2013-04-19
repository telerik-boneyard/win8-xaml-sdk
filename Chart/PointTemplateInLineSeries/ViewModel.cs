using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointTemplateInLineSeries
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.SeriesData = new List<CustomPoint>()
            {
                new CustomPoint{ Category = "first", Value = 10},
                new CustomPoint{ Category = "second", Value = 32},
                new CustomPoint{ Category = "third", Value = 15},
            };
        }
        public List<CustomPoint> SeriesData { get; set; }
    }
}
