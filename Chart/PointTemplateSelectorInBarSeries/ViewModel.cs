using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointTemplateSelectorInBarSeries
{
    class ViewModel
    {
        public ViewModel()
        {
            this.SeriesData = new List<CustomPoint>()
            {
                new CustomPoint{ Category = "first", Value = 12},
                new CustomPoint{ Category = "second", Value = 36},
                new CustomPoint{ Category = "third", Value = 9},
                new CustomPoint{ Category = "fourth", Value = 22},
                new CustomPoint{ Category = "fifth", Value = 24},
                new CustomPoint{ Category = "sixth", Value = 16},
            };
        }
        public List<CustomPoint> SeriesData { get; set; }
    }
}
