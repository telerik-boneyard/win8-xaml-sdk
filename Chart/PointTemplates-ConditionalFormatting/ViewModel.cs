using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointTemplates_ConditionalFormatting
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.SeriesData = new List<CustomPoint>()
            {

            };
        }
        public List<CustomPoint> SeriesData { get; set; }
    }
}
