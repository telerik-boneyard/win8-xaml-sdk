using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Charting;
using Telerik.Core;
using Telerik.UI.Xaml.Controls.Chart;
using Windows.Foundation;
using Windows.UI.Xaml;

namespace SeriesLabels_LabelStrategy
{
    public class CenterOutsideLabelStrategy : ChartSeriesLabelStrategy
    {
        public override LabelStrategyOptions Options
        {
            get
            {
                return LabelStrategyOptions.Arrange;
            }
        }

        public override RadRect GetLabelLayoutSlot(DataPoint point, FrameworkElement visual, int labelIndex)
        {
            visual.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

            double x = point.LayoutSlot.X + ((point.LayoutSlot.Width - visual.ActualWidth) / 2);
            double y = point.LayoutSlot.Y - 20;

            return new RadRect(x, y, visual.ActualWidth, visual.ActualHeight);
        }
    }
}
