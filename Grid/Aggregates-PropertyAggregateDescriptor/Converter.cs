using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Aggregates_PropertyAggregateDescriptor
{
    public class Converter : DependencyObject, IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            GroupHeaderContext context = value as GroupHeaderContext;
            var currentGroup = context.Group;
            var grid = context.Grid;
            var currentView = grid.GetDataView();
            return String.Format("The total sum is : {0}", currentView.GetAggregateValue(0, currentGroup));

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

    }
}
