using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolarChartGrid_Example
{
    public class ViewModel
    {
        public ViewModel()
        {
            double a = 0.5;
            var b = (Math.PI / 180);
            List<CustomPoint> collection = new List<CustomPoint>();
            for (int i = 1; i < 5 * 360; i += 10)
            {
                collection.Add(new CustomPoint() { Angle = i, Value = (a * Math.Cos(20 * i * b)) });
            }
            this.SeriesData = collection;
        }
        public List<CustomPoint> SeriesData { get; set; }
    }
}
