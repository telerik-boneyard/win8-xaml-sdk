using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionBehavior_GettingStarted
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.SeriesData = new List<CustomPoint>()
            {
                new CustomPoint{ Category = "Apples", Value = 10, CustomProperty = "This is the first point" },
                new CustomPoint{ Category = "Oranges", Value = 32, CustomProperty = "This is the second point"},
                new CustomPoint{ Category = "Pears", Value = 15, CustomProperty = "This is the third point"},
            };
        }

        public List<CustomPoint> SeriesData { get; set; }
    }
}
