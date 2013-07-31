using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Commands_CellPointerOverCommand
{
    public class CustomConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (parameter.ToString() == "brush")
            {
                if ((int)value == 0)
                {
                    return new SolidColorBrush(Colors.Red);
                }
                if ((int)value == 1)
                {
                    return new SolidColorBrush(Colors.Yellow);
                }
                else
                {
                    return new SolidColorBrush(Colors.Green);
                }
            }
            else 
            {
                if ((int)value == 0)
                {
                    return "L";
                }
                if ((int)value == 1)
                {
                    return "D";
                }
                else
                {
                    return "W";
                }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}