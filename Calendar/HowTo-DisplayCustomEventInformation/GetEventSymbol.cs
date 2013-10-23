using System;
using System.Linq;
using Telerik.UI.Xaml.Controls.Input;
using Telerik.UI.Xaml.Controls.Input.Calendar;
using Windows.UI.Xaml.Data;

namespace HowTo_DisplayCustomEventInformation
{
    public class GetEventSymbol : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var cellModel = value as CalendarCellModel;

            // Get a reference to the calendar container
            var calendar = cellModel.Presenter as RadCalendar;

            // Then you can get a reference to its DataContext (i.e. the page view model that holds the event information)
            var events = (calendar.DataContext as ViewModel).Events;

            // return custom label for event cells
            var eventInfo = events.Where(e => e.Date == cellModel.Date).FirstOrDefault();
            if (eventInfo != null)
            {
                return eventInfo.Symbol;
            }

            // return default label for regular cells
            return cellModel.Label;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}