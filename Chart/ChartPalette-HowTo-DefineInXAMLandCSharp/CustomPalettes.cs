using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Chart;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace ChartPalette_HowTo_DefineInXAMLandCSharp
{
    public class CustomPalettes : ChartPalette
    {
        public CustomPalettes()
        {
            // fill
            this.FillEntries.Brushes.Add(new SolidColorBrush(Colors.White));
            this.FillEntries.Brushes.Add(new SolidColorBrush(Colors.Gray));
            this.FillEntries.Brushes.Add(new SolidColorBrush(Colors.DarkGreen));   
            // stroke
            this.StrokeEntries.Brushes.Add(new SolidColorBrush(Colors.White));
            this.StrokeEntries.Brushes.Add(new SolidColorBrush(Colors.Gray));
            this.StrokeEntries.Brushes.Add(new SolidColorBrush(Colors.DarkGreen));
        }
    }

}
