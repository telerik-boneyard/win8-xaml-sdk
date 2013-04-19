using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartPalette_HowTo_DefineInXAMLandCSharp
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.SeriesData = new List<CustomPoint>() 
                                                    {
                                                        new CustomPoint{ Category = "first", Value = 1 },
                                                        new CustomPoint{ Category = "second", Value = 2 },
                                                        new CustomPoint{ Category = "third", Value = 3 },

                                                    };
        }
        public List<CustomPoint> SeriesData { get; set; }
    }
}
