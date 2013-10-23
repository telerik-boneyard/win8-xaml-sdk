using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace SingleThumbMode
{
    public class ColorComponentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var color = (ComponentColors)value;

            switch (color)
            {
                case ComponentColors.Red:
                    return new SolidColorBrush { Color = Colors.Red };
                case ComponentColors.Green:
                    return new SolidColorBrush { Color = Colors.Green };
                case ComponentColors.Blue:
                    return new SolidColorBrush { Color = Colors.Blue };
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}