using System;
using Windows.UI.Xaml.Data;

namespace Columns_TemplateColumnSortDescriptor
{
    public class AgeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (int)value + " years";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}