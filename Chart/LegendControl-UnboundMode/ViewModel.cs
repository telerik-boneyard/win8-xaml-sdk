using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendControl_UnboundMode
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.SeriesData = new List<CustomPoint>()
            {
                new CustomPoint{ Category = "Orange", Value = 10},
                new CustomPoint{ Category = "Apple", Value = 14},
                new CustomPoint{ Category = "Lemon", Value = 5},
            };
        }
        public List<CustomPoint> SeriesData
        {
            get;
            set;
        }
    }
}
