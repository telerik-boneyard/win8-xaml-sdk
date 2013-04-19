using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianChartGrid_Example
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.SeriesData = new List<CustomPoint>()
            {
                new CustomPoint{ Category = "Apples", Value = 10 },
                new CustomPoint{ Category = "Oranges", Value = 32 },
                new CustomPoint{ Category = "Pears", Value = 15 },
            };
        }
        public List<CustomPoint> SeriesData { get; set; }
    }
}
