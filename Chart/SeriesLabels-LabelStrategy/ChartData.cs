using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesLabels_LabelStrategy
{
    public class ChartData
    {
        public string Category { get; set; }

        public double Value { get; set; }

        public double Value2 { get; set; }

        public double CalculatedStackedSum
        {
            get
            {
                // you will use this property to visualize the stacked sum outside the bars
                return this.Value + this.Value2;
            }
        }
    }
}
