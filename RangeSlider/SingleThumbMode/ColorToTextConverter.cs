using System;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace SingleThumbMode
{
    public class ColorToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var brush = value as SolidColorBrush;

            if (brush != null)
            {
              return   brush.Color.ToString();
            }
            
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}