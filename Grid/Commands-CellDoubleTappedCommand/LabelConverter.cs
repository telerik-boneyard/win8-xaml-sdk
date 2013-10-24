using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Charting;
using Windows.UI.Xaml.Data;

namespace Commands_CellDoubleTappedCommand
{
    public class LabelConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, string language)
        {
            return String.Format("{0}: {1}", (value as CategoricalDataPoint).Category, (value as CategoricalDataPoint).Value);
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}