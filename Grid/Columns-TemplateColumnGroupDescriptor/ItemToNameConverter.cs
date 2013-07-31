using System;
using Windows.UI.Xaml.Data;

namespace Columns_TemplateColumnGroupDescriptor
{
    public class ItemToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var obj = value as Data;
            return obj.LastName + ", " + obj.FirstName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}