using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Charting;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PointTemplateSelectorInBarSeries
{
    public class CustomPointTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            CategoricalDataPoint dataPoint = item as CategoricalDataPoint;

            if (dataPoint.Value > 17)
            {
                return this.FirstTemplate;
            }
            else
            {
                return this.SecondTemplate;
            }

        }
        public DataTemplate FirstTemplate { get; set; }
        public DataTemplate SecondTemplate { get; set; }
    }
}
